// const { ShowHardCodedProducts } = require("./data");

let newProductList = [];

const dataBasket = JSON.parse(sessionStorage.getItem("basket"));
    
if (dataBasket !== null) {
    const counter = dataBasket.basketProducts.length;
    const divCounter = document.querySelector('.basket-counter');
    divCounter.classList.add('basket-counter');
    divCounter.textContent = `${counter} product(s)`; 
}

const getFormData = () => {

    let productTitle = (<HTMLInputElement>document.getElementsByClassName("product_form--product_title")[0]).value;
    let productDescription = (<HTMLInputElement>document.getElementsByClassName("product_form--product_description")[0]).value;
    let productPrice = (<HTMLInputElement>document.getElementsByClassName("product_form--product_price")[0]).value;
    let productImage = (<HTMLInputElement>document.getElementsByClassName("product_form--product_image")[0]).value;
    let productCategory = (<HTMLInputElement>document.getElementsByClassName("product_form--product_category")[0]).value;

    let productDetails = {
        id: Math.floor(Math.random() * 23) + 7,
        title: productTitle,
        description: productDescription,
        price: productPrice,
        imageUrl: productImage,
        category: productCategory
    }

    const data = JSON.parse(localStorage.getItem("products"));
  
    newProductList = data.productList;
    
    newProductList.push(productDetails); 
   
    const  storageItems = { productList: newProductList};

    localStorage.setItem("products", JSON.stringify(storageItems))
}

export {getFormData};