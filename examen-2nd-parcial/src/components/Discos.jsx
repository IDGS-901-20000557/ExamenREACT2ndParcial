import { Link, useParams } from "react-router-dom";
import './Discos.css'
import { useCallback, useEffect, useState } from "react";
import Swal from "sweetalert2";

const Discos = () => {
    const { nombre } = useParams();
    const [discos, setDiscos] = useState([]);

    const searchDisco = useCallback(async () => {
        if (nombre === '') {
            getDiscos();
        } else {
            const api = await fetch(`https://localhost:7140/api/Discos/search/${nombre}`);
            const data = await api.json();
            if (!data || Object.keys(data).length === 0) {
                Swal.fire({
                    icon: "error",
                    title: "Oops...",
                    text: "No se encontraron discos con ese nombre"
                });
            } else {
                setDiscos(data);
            }
        }
    }, [nombre, setDiscos]);

    const searchDiscoButton = useCallback(async () => {
        const name = document.getElementById('txtDisco').value;
        if (name === '') {
            getDiscos();
        } else {
            const api = await fetch(`https://localhost:7140/api/Discos/search/${name}`);
            const data = await api.json();
            if (!data || Object.keys(data).length === 0) {
                Swal.fire({
                    icon: "error",
                    title: "Oops...",
                    text: "No se encontraron discos con ese nombre"
                });
            } else {
                setDiscos(data);
            }
        }
    }, [setDiscos]);

    useEffect(() => {
        searchDisco();
    }, [searchDisco]);

    const getDiscos = async () => {
        const url = 'https://localhost:7140/api/Discos/GetAll';
        const resp = await fetch(url);
        const data = await resp.json();
        setDiscos(data);
    };

    return (
        <div className="container">
            <div className="card">
                <div className="card__form">
                    <input placeholder="Busca tus discos por nombre" name="txtDisco" id="txtDisco" type="text" />
                    <button className="search-button" onClick={searchDiscoButton}>Buscar</button>
                </div>
            </div>
            <br /><br />
            <div className="disc-container">
                {discos.map((disco, index) => (
                    <div className="disc-card" key={index}>
                        <div className="disc-image">
                            <img src={disco.imagen} alt="" />
                        </div>
                        <Link to={`/item/${disco.id}`} style={{ textDecoration: 'none', color: 'inherit' }}>
                            <div className="disc-content">
                                <div className="disc-category"> {disco.nombre} </div>
                                <div className="disc-heading"> {disco.descripcion}</div>
                                <div className="disc-author">Precio: {disco.precio}</div>
                            </div>
                        </Link>
                    </div>
                ))}
            </div>
        </div>
    );
};

export default Discos;
