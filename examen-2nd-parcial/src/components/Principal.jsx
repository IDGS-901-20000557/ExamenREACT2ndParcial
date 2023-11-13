//import React from 'react'
// import { useCallback, useState } from 'react';
import { Link } from 'react-router-dom';
import './Principal.css'
import { useState } from 'react';
// import Swal from 'sweetalert2';
// import Discos from './Discos';

const Principal = () => {
    const [inputValue, setInputValue] = useState('');

    const handleInputChange = (event) => {
        setInputValue(event.target.value);
    };
    return (
        <div className="container">
            <div className="card">
                <img src="/logo.png" alt="Imagen de discografía" className="card__image" />
                <span className="card__title">Discografía Claustro</span>
                <p className="card__content">Descubre y busca tus discos favoritos en la discografía de Claustro.</p>
                <div className="card__form">
                    <input
                        placeholder="Busca tus discos por nombre"
                        name="txtDisco"
                        id="txtDisco"
                        type="text"
                        value={inputValue}
                        onChange={handleInputChange}
                    />
                    <Link to={`/items/${inputValue}`}>
                        <button className="search-button" >Buscar</button>

                    </Link>
                </div>
            </div>
        </div >
    );

}

export default Principal