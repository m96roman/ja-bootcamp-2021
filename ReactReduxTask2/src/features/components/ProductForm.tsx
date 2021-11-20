import React, { useState } from 'react';
import { useAppDispatch } from '../../app/hooks';
import { IProductItem, createProduct } from './productsSlice';
import styles from './Products.module.css';
import image from "../img/1.jpg";

export function ProductForm() {

    const dispatch = useAppDispatch();
    
    const [name, setName] = useState("");
    const [description, setDescription] = useState("");
    const [price, setPrice] = useState("");

    const productInfo : IProductItem = {
         name: name,
         image: image,
         description: description,
         price: Number(price) 
    }
   
    return (
        <div className={styles.create_product_form}>
            <p>Product name</p>
            <input
                className={styles.text_box}
                aria-label="Product Name"
                value={name}
                onChange={(e) => setName(e.target.value)}
            />
             <p>Description</p>
                    <input
                className={styles.text_box}
                aria-label="Description"
                value={description}
                onChange={(e) => setDescription(e.target.value)}
            />
             <p>Product price</p>
                    <input
                className={styles.text_box}
                aria-label="Price"
                value={price}
                onChange={(e) => setPrice(e.target.value)}
            />
            <button
                className={styles.button}
                onClick={() => dispatch(createProduct(productInfo))}
            >
                Create product
            </button>
        </div>
    );
}