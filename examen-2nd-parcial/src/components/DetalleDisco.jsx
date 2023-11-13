import { useEffect, useState } from 'react';
import './DetalleDisco.css';
import { useParams } from 'react-router-dom';

const DetalleDisco = () => {
    const idDisco = useParams().id;
    const [disco, setDisco] = useState([]);

    const getDisco = async () => {
        const url = `https://localhost:7140/api/Discos/Get/${idDisco}`;
        const resp = await fetch(url);
        const data = await resp.json();
        setDisco(data);
    };

    useEffect(() => {
        getDisco();
    }, [idDisco]);

    return (
        <div className="carda">
            <div className="imageation">
                <img src={disco.imagen} alt="" />
            </div>
            <div className="content">
                <h1>{disco.nombre}</h1>
                <p>{disco.artista}</p>
                <p>Descripción: {disco.descripcion}</p>
                <p>Precio: {disco.precio}</p>
                <p>Género: {disco.genero}</p>
                <div className="controlls">
                    <a href=""><i className="fa fa-backward" aria-hidden="true"></i></a>
                    <a href=""><i className="fa fa-pause" aria-hidden="true"></i></a>
                    <a href=""><i className="fa fa-forward" aria-hidden="true"></i></a>
                </div>
            </div>
        </div>
    );
};

export default DetalleDisco;
