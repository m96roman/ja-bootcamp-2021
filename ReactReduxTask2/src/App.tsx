import React from 'react';
import './App.css';
import {ProductItem} from './features/components/ProductItem';
import {ProductForm} from './features/components/ProductForm';
import {Navbar} from './features/components/Navbar';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <h1 className="App-title">Bakery Shop</h1>
      <nav className="navbar">
        <Navbar/>
      </nav>
      </header>
      <div className="main-container">
          <ProductForm/>     
          <ProductItem /> 
        </div>
    </div>
  );
}

export default App;
