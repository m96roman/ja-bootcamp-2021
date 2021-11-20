import React, { useState } from 'react';
import image from "../img/1.jpg";
import { useAppSelector} from '../../app/hooks';
import { allProducts, IProductItem } from './productsSlice';
import styles from './Products.module.css';


export function ProductItem() {

  const products = useAppSelector(allProducts);
  const productList = products.counter.prodList;
  const category = products.counter.activeCategory;
  let resulted : Array<IProductItem> = productList ;

  if(category !== "allSweets" ){
    resulted = productList.filter(element=>element.name === category);
  }

  return (
    <div className={styles.main_container}>
      {resulted.map(element =>
        <div className={styles.product_container}>
          <h3> {element.name}</h3>
          <img className={styles.product_image} src={image} />
          <p>{element.description}</p>
          <p>{element.price}</p>
        </div>
      )}
    </div>
  )
}
