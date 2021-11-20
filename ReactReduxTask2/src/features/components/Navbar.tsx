import React, { useState } from 'react';
import { useAppSelector, useAppDispatch } from '../../app/hooks';
import { ProductItem } from './ProductItem';
import { allSweets, allProducts, IProductItem, filter } from './productsSlice';
import styles from './Products.module.css';

export function Navbar(){
    const products = useAppSelector(allProducts);
    const dispatch = useAppDispatch();
    const test = "muffin";
  
    const category = {};

    return(<div>
             <button
                className={styles.button}
                onClick={() =>dispatch(filter("allSweets"))}
            >
               All sweets
            </button>  
            <button
                className={styles.button}
                onClick={() => dispatch(filter("Muffin"))}
            >
               Muffins
            </button>    
            <button
                className={styles.button}
                onClick={() => dispatch(filter("Cake"))}
            >
               Cakes
            </button> 
            <button
                className={styles.button}
                onClick={() => dispatch(filter("Cookie"))}
            >
               Cookies
            </button>
        </div>      
    );
}