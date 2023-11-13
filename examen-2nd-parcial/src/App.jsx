//import React from 'react'
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import Principal from './components/Principal'
import DetalleDisco from './components/DetalleDisco'
import Discos from './components/Discos'

const App = () => {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Principal />} />
        <Route path="/items/:nombre" element={<Discos />} />
        <Route path="/item/:id" element={<DetalleDisco />} />
      </Routes>
    </BrowserRouter>
  )
}

export default App