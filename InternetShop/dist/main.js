/******/ (() => { // webpackBootstrap
/******/ 	var __webpack_modules__ = ({

/***/ "./src/append.js":
/*!***********************!*\
  !*** ./src/append.js ***!
  \***********************/
/***/ ((module) => {

const append = () => {

    const dataBasket = JSON.parse(sessionStorage.getItem("basket"));
    if (dataBasket !== null) {
        const counter = dataBasket.basketProducts.length;
        const divCounter = document.querySelector('.basket-counter');
        divCounter.classList.add('basket-counter');
        divCounter.textContent = `${counter} product(s)`;
    }


    const data = JSON.parse(localStorage.getItem("products"));

    const productsContainer = document.querySelector('.main-container');

    data.productList.forEach((element) => {

        let prodContainer = document.createElement("div");
        prodContainer.classList.add('product-container');

        let divTitle = document.createElement("div");
        divTitle.classList.add('title');
        divTitle.textContent = element.title;
        prodContainer.appendChild(divTitle);

        let divImage = document.createElement("img");
        divImage.src = element.imageUrl;
        divImage.classList.add('product-image');
        divImage.textContent = element.imageUrl;
        prodContainer.appendChild(divImage);

        let divDescription = document.createElement("div");
        divDescription.classList.add('product-description');
        divDescription.textContent = element.description;
        prodContainer.appendChild(divDescription);

        let divPrice = document.createElement("div");
        divPrice.classList.add('product-price');
        divPrice.textContent = "Price:" + " " + element.price;
        prodContainer.appendChild(divPrice);

        let divCategory = document.createElement("div");
        divCategory.classList.add('product-category');
        divCategory.textContent = "Category:" + " " + element.category;
        prodContainer.appendChild(divCategory);

        let divButton = document.createElement("input");
        divButton.type = "button";
        divButton.classList.add('product-button');
        divButton.value = "Add";
        divButton.id = element.id;

        divButton.onclick = function () {
            AddToBasket(this);
        };

        prodContainer.appendChild(divButton);

        productsContainer.appendChild(prodContainer);

    });

}

module.exports = { append };

/***/ }),

/***/ "./src/basket.js":
/*!***********************!*\
  !*** ./src/basket.js ***!
  \***********************/
/***/ ((module) => {

const AddToBasket = (elem) => {

    let basketProducts = [];
    let prodId = elem.id;
    let storageBasketItems = {};

    const data = JSON.parse(localStorage.getItem("products"));
    const basketData = JSON.parse(sessionStorage.getItem("basket"));

    data.productList.find(element => {
        if (element.id == prodId) {
            basketProducts.push(element);
        }
    });

    if (basketData === null) {
        storageBasketItems = { basketProducts };
    }else{ 
        basketData.basketProducts.forEach(element => {
            basketProducts.push(element);
        });
        storageBasketItems = { basketProducts };
    };

    sessionStorage.setItem("basket", JSON.stringify(storageBasketItems))
}

const AppendToBasket = () => {

    const data = JSON.parse(sessionStorage.getItem("basket"));
    const counter = data.basketProducts.length;
    const tableBody = document.querySelector('.table-body');
    const divCounter =  document.querySelector('.basket-counter');
    divCounter.classList.add('basket-counter');
    divCounter.textContent = `${counter} product(s)`;
   
    data.basketProducts.forEach((element) => {
        let tableRow = document.createElement("tr");
        let tdTitle = document.createElement("td");
        tdTitle.classList.add('basket-title');
        tdTitle.textContent = element.title;
        tableRow.appendChild(tdTitle);
        
        let tdImg = document.createElement("td");
        let innerImg = document.createElement("img");
        innerImg.classList.add("table-image");
        innerImg.src = element.imageUrl;
        tdImg.appendChild(innerImg);
        tdImg.classList.add('basket-img');
        tableRow.appendChild(tdImg);
        
        let tdCategory= document.createElement("td");
        tdCategory.classList.add('basket-category');
        tdCategory.textContent = element.category;
        tableRow.appendChild(tdCategory);

        let tdPrice= document.createElement("td");
        tdPrice.classList.add('basket-price');
        tdPrice.textContent = element.price;
        tableRow.appendChild(tdPrice);

        tableBody.appendChild(tableRow);

    });
}
module.exports = { AddToBasket, AppendToBasket };

/***/ }),

/***/ "./src/data.js":
/*!*********************!*\
  !*** ./src/data.js ***!
  \*********************/
/***/ ((module, __unused_webpack_exports, __webpack_require__) => {

const { append } = __webpack_require__(/*! ./form */ "./src/form.js");

const productList = [
    {
        id: 1,
        title: "Clown muffin",
        description: "Tasty muffin for kids with jam filler.",
        price: 7,
        imageUrl: "../img/muffin1.jpg",
        category: "muffin"
    },
    {
        id: 2,
        title: "Rabbit muffin",
        description: "Tasty muffin for kids with jam filler.",
        price: 8,
        imageUrl: "../img/2.jpg",
        category: "muffin"
    },
    {
        id: 3,
        title: "Chicken muffin",
        description: "Tasty muffin for kids with jam filler.",
        price: 5,
        imageUrl: "../img/3.jpg",
        category: "muffin"
    },
    {
        id: 4,
        title: "Berry cake",
        description: "Tasty cake",
        price: 10,
        imageUrl: "../img/4.jpg",
        category: "cake"
    },
];


const ShowHardCodedProducts = () => {

     if (localStorage.length === 0) {
        const storageItems = { productList };
        localStorage.setItem("products", JSON.stringify(storageItems))
    }
    else {
        const storageItems = JSON.parse(localStorage.getItem("products"));
        localStorage.setItem("products", JSON.stringify(storageItems))
    }
}

module.exports = { ShowHardCodedProducts };

/***/ }),

/***/ "./src/form.js":
/*!*********************!*\
  !*** ./src/form.js ***!
  \*********************/
/***/ ((module, __unused_webpack_exports, __webpack_require__) => {

const { ShowHardCodedProducts } = __webpack_require__(/*! ./data */ "./src/data.js");

let newProductList = [];

const getFormData = () => {
    let productTitle = document.getElementsByClassName("product_form--product_title")[0].value;
    let productDescription = document.getElementsByClassName("product_form--product_description")[0].value;
    let productPrice = document.getElementsByClassName("product_form--product_price")[0].value;
    let productImage = document.getElementsByClassName("product_form--product_image")[0].value;
    let productCategory = document.getElementsByClassName("product_form--product_category")[0].value;


    let productDetails = {
        id: Math.floor(Math.random() * 16) + 5,
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

module.exports = { getFormData };

/***/ })

/******/ 	});
/************************************************************************/
/******/ 	// The module cache
/******/ 	var __webpack_module_cache__ = {};
/******/ 	
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/ 		// Check if module is in cache
/******/ 		var cachedModule = __webpack_module_cache__[moduleId];
/******/ 		if (cachedModule !== undefined) {
/******/ 			return cachedModule.exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = __webpack_module_cache__[moduleId] = {
/******/ 			// no module.id needed
/******/ 			// no module.loaded needed
/******/ 			exports: {}
/******/ 		};
/******/ 	
/******/ 		// Execute the module function
/******/ 		__webpack_modules__[moduleId](module, module.exports, __webpack_require__);
/******/ 	
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/ 	
/************************************************************************/
var __webpack_exports__ = {};
// This entry need to be wrapped in an IIFE because it need to be isolated against other modules in the chunk.
(() => {
/*!**********************!*\
  !*** ./src/index.js ***!
  \**********************/
const {getFormData} = __webpack_require__(/*! ./form */ "./src/form.js");
const {append} = __webpack_require__(/*! ./append */ "./src/append.js");
const {ShowHardCodedProducts} = __webpack_require__(/*! ./data */ "./src/data.js");
const {AddToBasket} = __webpack_require__(/*! ./basket */ "./src/basket.js");
const {AppendToBasket} = __webpack_require__(/*! ./basket */ "./src/basket.js");
const {ShowMuffins} = __webpack_require__(/*! ./basket */ "./src/basket.js");

window.ShowMuffins = ShowMuffins;
window.AppendToBasket = AppendToBasket;
window.AddToBasket = AddToBasket;
window.append = append;
window.getFormData = getFormData;
window.ShowHardCodedProducts = ShowHardCodedProducts;


})();

/******/ })()
;
//# sourceMappingURL=main.js.map