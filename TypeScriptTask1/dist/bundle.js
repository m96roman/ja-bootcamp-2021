/******/ (() => { // webpackBootstrap
/******/ 	"use strict";
/******/ 	var __webpack_modules__ = ({

/***/ "./src/append.ts":
/*!***********************!*\
  !*** ./src/append.ts ***!
  \***********************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "append": () => (/* binding */ append)
/* harmony export */ });
/* harmony import */ var _basket__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./basket */ "./src/basket.ts");

var append = function () {
    var dataBasket = JSON.parse(sessionStorage.getItem("basket"));
    if (dataBasket !== null) {
        var counter = dataBasket.basketProducts.length;
        var divCounter = document.querySelector('.basket-counter');
        divCounter.classList.add('basket-counter');
        divCounter.textContent = "".concat(counter, " product(s)");
    }
    var data = JSON.parse(localStorage.getItem("products"));
    var productsContainer = document.querySelector('.main-container');
    data.productList.forEach(function (element) {
        var prodContainer = document.createElement("div");
        prodContainer.classList.add('product-container');
        var divTitle = document.createElement("div");
        divTitle.classList.add('title');
        divTitle.textContent = element.title;
        prodContainer.appendChild(divTitle);
        var divImage = document.createElement("img");
        divImage.src = element.imageUrl;
        divImage.classList.add('product-image');
        divImage.textContent = element.imageUrl;
        prodContainer.appendChild(divImage);
        var divDescription = document.createElement("div");
        divDescription.classList.add('product-description');
        divDescription.textContent = element.description;
        prodContainer.appendChild(divDescription);
        var divPrice = document.createElement("div");
        divPrice.classList.add('product-price');
        divPrice.textContent = "Price:" + " " + element.price;
        prodContainer.appendChild(divPrice);
        var divCategory = document.createElement("div");
        divCategory.classList.add('product-category');
        divCategory.textContent = "Category:" + " " + element.category;
        prodContainer.appendChild(divCategory);
        var divButton = document.createElement("input");
        divButton.type = "button";
        divButton.classList.add('product-button');
        divButton.value = "Add";
        divButton.id = element.id.toString();
        divButton.onclick = function () {
            (0,_basket__WEBPACK_IMPORTED_MODULE_0__.AddToBasket)(divButton.id);
        };
        prodContainer.appendChild(divButton);
        productsContainer.appendChild(prodContainer);
    });
};



/***/ }),

/***/ "./src/basket.ts":
/*!***********************!*\
  !*** ./src/basket.ts ***!
  \***********************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "AppendToBasket": () => (/* binding */ AppendToBasket),
/* harmony export */   "AddToBasket": () => (/* binding */ AddToBasket)
/* harmony export */ });
var AddToBasket = function (id) {
    var basketProducts = [];
    var prodId = id;
    var storageBasketItems = {};
    var data = JSON.parse(localStorage.getItem("products"));
    var basketData = JSON.parse(sessionStorage.getItem("basket"));
    data.productList.find(function (element) {
        if (element.id.toString() === prodId) {
            basketProducts.push(element);
        }
    });
    if (basketData === null) {
        storageBasketItems = { basketProducts: basketProducts };
    }
    else {
        basketData.basketProducts.forEach(function (element) {
            basketProducts.push(element);
        });
        storageBasketItems = { basketProducts: basketProducts };
    }
    ;
    sessionStorage.setItem("basket", JSON.stringify(storageBasketItems));
};
var AppendToBasket = function () {
    var data = JSON.parse(sessionStorage.getItem("basket"));
    var counter = data.basketProducts.length;
    var tableBody = document.querySelector('.table-body');
    var divCounter = document.querySelector('.basket-counter');
    divCounter.classList.add('basket-counter');
    divCounter.textContent = "".concat(counter, " product(s)");
    data.basketProducts.forEach(function (element) {
        var tableRow = document.createElement("tr");
        var tdTitle = document.createElement("td");
        tdTitle.classList.add('basket-title');
        tdTitle.textContent = element.title;
        tableRow.appendChild(tdTitle);
        var innerImg = document.createElement("img");
        innerImg.classList.add("table-image");
        innerImg.src = element.imageUrl;
        var tdImg = document.createElement("td");
        tdImg.appendChild(innerImg);
        tdImg.classList.add('basket-img');
        tableRow.appendChild(tdImg);
        var tdCategory = document.createElement("td");
        tdCategory.classList.add('basket-category');
        tdCategory.textContent = element.category;
        tableRow.appendChild(tdCategory);
        var tdPrice = document.createElement("td");
        tdPrice.classList.add('basket-price');
        tdPrice.textContent = element.price.toString();
        tableRow.appendChild(tdPrice);
        tableBody.appendChild(tableRow);
    });
};
// (window as any)!.AddToBasket = AddToBasket;




/***/ }),

/***/ "./src/cakes.ts":
/*!**********************!*\
  !*** ./src/cakes.ts ***!
  \**********************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ShowCakes": () => (/* binding */ ShowCakes)
/* harmony export */ });
/* harmony import */ var _basket__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./basket */ "./src/basket.ts");

var ShowCakes = function () {
    var dataBasket = JSON.parse(sessionStorage.getItem("basket"));
    if (dataBasket !== null) {
        var counter = dataBasket.basketProducts.length;
        var divCounter = document.querySelector('.basket-counter');
        divCounter.classList.add('basket-counter');
        divCounter.textContent = "".concat(counter, " product(s)");
    }
    var data = JSON.parse(localStorage.getItem("products"));
    var productsContainer = document.querySelector('.main-container');
    data.productList.find(function (element) {
        if (element.category === "cake") {
            var prodContainer = document.createElement("div");
            prodContainer.classList.add('product-container');
            var divTitle = document.createElement("div");
            divTitle.classList.add('title');
            divTitle.textContent = element.title;
            prodContainer.appendChild(divTitle);
            var divImage = document.createElement("img");
            divImage.src = element.imageUrl;
            divImage.classList.add('product-image');
            divImage.textContent = element.imageUrl;
            prodContainer.appendChild(divImage);
            var divDescription = document.createElement("div");
            divDescription.classList.add('product-description');
            divDescription.textContent = element.description;
            prodContainer.appendChild(divDescription);
            var divPrice = document.createElement("div");
            divPrice.classList.add('product-price');
            divPrice.textContent = "Price:" + " " + element.price;
            prodContainer.appendChild(divPrice);
            var divCategory = document.createElement("div");
            divCategory.classList.add('product-category');
            divCategory.textContent = "Category:" + " " + element.category;
            prodContainer.appendChild(divCategory);
            var divButton_1 = document.createElement("input");
            divButton_1.type = "button";
            divButton_1.classList.add('product-button');
            divButton_1.value = "Add";
            divButton_1.id = element.id.toString();
            divButton_1.onclick = function () {
                (0,_basket__WEBPACK_IMPORTED_MODULE_0__.AddToBasket)(divButton_1.id);
            };
            prodContainer.appendChild(divButton_1);
            productsContainer.appendChild(prodContainer);
        }
    });
};



/***/ }),

/***/ "./src/cookies.ts":
/*!************************!*\
  !*** ./src/cookies.ts ***!
  \************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ShowCookies": () => (/* binding */ ShowCookies)
/* harmony export */ });
/* harmony import */ var _basket__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./basket */ "./src/basket.ts");

var ShowCookies = function () {
    var dataBasket = JSON.parse(sessionStorage.getItem("basket"));
    if (dataBasket !== null) {
        var counter = dataBasket.basketProducts.length;
        var divCounter = document.querySelector('.basket-counter');
        divCounter.classList.add('basket-counter');
        divCounter.textContent = "".concat(counter, " product(s)");
    }
    var data = JSON.parse(localStorage.getItem("products"));
    var productsContainer = document.querySelector('.main-container');
    data.productList.find(function (element) {
        if (element.category === "cookie") {
            var prodContainer = document.createElement("div");
            prodContainer.classList.add('product-container');
            var divTitle = document.createElement("div");
            divTitle.classList.add('title');
            divTitle.textContent = element.title;
            prodContainer.appendChild(divTitle);
            var divImage = document.createElement("img");
            divImage.src = element.imageUrl;
            divImage.classList.add('product-image');
            divImage.textContent = element.imageUrl;
            prodContainer.appendChild(divImage);
            var divDescription = document.createElement("div");
            divDescription.classList.add('product-description');
            divDescription.textContent = element.description;
            prodContainer.appendChild(divDescription);
            var divPrice = document.createElement("div");
            divPrice.classList.add('product-price');
            divPrice.textContent = "Price:" + " " + element.price;
            prodContainer.appendChild(divPrice);
            var divCategory = document.createElement("div");
            divCategory.classList.add('product-category');
            divCategory.textContent = "Category:" + " " + element.category;
            prodContainer.appendChild(divCategory);
            var divButton_1 = document.createElement("input");
            divButton_1.type = "button";
            divButton_1.classList.add('product-button');
            divButton_1.value = "Add";
            divButton_1.id = element.id.toString();
            divButton_1.onclick = function () {
                (0,_basket__WEBPACK_IMPORTED_MODULE_0__.AddToBasket)(divButton_1.id);
            };
            prodContainer.appendChild(divButton_1);
            productsContainer.appendChild(prodContainer);
        }
    });
};



/***/ }),

/***/ "./src/data.ts":
/*!*********************!*\
  !*** ./src/data.ts ***!
  \*********************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ShowHardCodedProducts": () => (/* binding */ ShowHardCodedProducts)
/* harmony export */ });
// const { append } = require("./form");
var productList = [
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
        description: "Tasty muffin",
        price: 8,
        imageUrl: "../img/2.jpg",
        category: "muffin"
    },
    {
        id: 3,
        title: "Chicken muffin",
        description: "Tasty muffin",
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
    {
        id: 5,
        title: "Lolly-pop cake",
        description: "Tasty cake",
        price: 10,
        imageUrl: "../img/6.jpg",
        category: "cake"
    },
    {
        id: 6,
        title: "Chocolate cookies",
        description: "Tasty cookies",
        price: 10,
        imageUrl: "../img/8.jpg",
        category: "cookie"
    },
    {
        id: 7,
        title: "Chocolate cookies",
        description: "Tasty cookies",
        price: 10,
        imageUrl: "../img/9.jpg",
        category: "cookie"
    },
];
var ShowHardCodedProducts = function () {
    if (localStorage.length === 0) {
        var storageItems = { productList: productList };
        localStorage.setItem("products", JSON.stringify(storageItems));
    }
    else {
        var storageItems = JSON.parse(localStorage.getItem("products"));
        localStorage.setItem("products", JSON.stringify(storageItems));
    }
};



/***/ }),

/***/ "./src/form.ts":
/*!*********************!*\
  !*** ./src/form.ts ***!
  \*********************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "getFormData": () => (/* binding */ getFormData)
/* harmony export */ });
// const { ShowHardCodedProducts } = require("./data");
var newProductList = [];
var dataBasket = JSON.parse(sessionStorage.getItem("basket"));
if (dataBasket !== null) {
    var counter = dataBasket.basketProducts.length;
    var divCounter = document.querySelector('.basket-counter');
    divCounter.classList.add('basket-counter');
    divCounter.textContent = "".concat(counter, " product(s)");
}
var getFormData = function () {
    var productTitle = document.getElementsByClassName("product_form--product_title")[0].value;
    var productDescription = document.getElementsByClassName("product_form--product_description")[0].value;
    var productPrice = document.getElementsByClassName("product_form--product_price")[0].value;
    var productImage = document.getElementsByClassName("product_form--product_image")[0].value;
    var productCategory = document.getElementsByClassName("product_form--product_category")[0].value;
    var productDetails = {
        id: Math.floor(Math.random() * 23) + 7,
        title: productTitle,
        description: productDescription,
        price: productPrice,
        imageUrl: productImage,
        category: productCategory
    };
    var data = JSON.parse(localStorage.getItem("products"));
    newProductList = data.productList;
    newProductList.push(productDetails);
    var storageItems = { productList: newProductList };
    localStorage.setItem("products", JSON.stringify(storageItems));
};



/***/ }),

/***/ "./src/muffins.ts":
/*!************************!*\
  !*** ./src/muffins.ts ***!
  \************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ShowMuffins": () => (/* binding */ ShowMuffins)
/* harmony export */ });
/* harmony import */ var _basket__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./basket */ "./src/basket.ts");

var ShowMuffins = function () {
    var dataBasket = JSON.parse(sessionStorage.getItem("basket"));
    if (dataBasket !== null) {
        var counter = dataBasket.basketProducts.length;
        var divCounter = document.querySelector('.basket-counter');
        divCounter.classList.add('basket-counter');
        divCounter.textContent = "".concat(counter, " product(s)");
    }
    var data = JSON.parse(localStorage.getItem("products"));
    var productsContainer = document.querySelector('.main-container');
    data.productList.find(function (element) {
        if (element.category === "muffin") {
            var prodContainer = document.createElement("div");
            prodContainer.classList.add('product-container');
            var divTitle = document.createElement("div");
            divTitle.classList.add('title');
            divTitle.textContent = element.title;
            prodContainer.appendChild(divTitle);
            var divImage = document.createElement("img");
            divImage.src = element.imageUrl;
            divImage.classList.add('product-image');
            divImage.textContent = element.imageUrl;
            prodContainer.appendChild(divImage);
            var divDescription = document.createElement("div");
            divDescription.classList.add('product-description');
            divDescription.textContent = element.description;
            prodContainer.appendChild(divDescription);
            var divPrice = document.createElement("div");
            divPrice.classList.add('product-price');
            divPrice.textContent = "Price:" + " " + element.price;
            prodContainer.appendChild(divPrice);
            var divCategory = document.createElement("div");
            divCategory.classList.add('product-category');
            divCategory.textContent = "Category:" + " " + element.category;
            prodContainer.appendChild(divCategory);
            var divButton_1 = document.createElement("input");
            divButton_1.type = "button";
            divButton_1.classList.add('product-button');
            divButton_1.value = "Add";
            divButton_1.id = element.id.toString();
            divButton_1.onclick = function () {
                (0,_basket__WEBPACK_IMPORTED_MODULE_0__.AddToBasket)(divButton_1.id);
            };
            prodContainer.appendChild(divButton_1);
            productsContainer.appendChild(prodContainer);
        }
    });
};



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
/******/ 	/* webpack/runtime/define property getters */
/******/ 	(() => {
/******/ 		// define getter functions for harmony exports
/******/ 		__webpack_require__.d = (exports, definition) => {
/******/ 			for(var key in definition) {
/******/ 				if(__webpack_require__.o(definition, key) && !__webpack_require__.o(exports, key)) {
/******/ 					Object.defineProperty(exports, key, { enumerable: true, get: definition[key] });
/******/ 				}
/******/ 			}
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/hasOwnProperty shorthand */
/******/ 	(() => {
/******/ 		__webpack_require__.o = (obj, prop) => (Object.prototype.hasOwnProperty.call(obj, prop))
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/make namespace object */
/******/ 	(() => {
/******/ 		// define __esModule on exports
/******/ 		__webpack_require__.r = (exports) => {
/******/ 			if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 				Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 			}
/******/ 			Object.defineProperty(exports, '__esModule', { value: true });
/******/ 		};
/******/ 	})();
/******/ 	
/************************************************************************/
var __webpack_exports__ = {};
// This entry need to be wrapped in an IIFE because it need to be isolated against other modules in the chunk.
(() => {
/*!**********************!*\
  !*** ./src/index.ts ***!
  \**********************/
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _data__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./data */ "./src/data.ts");
/* harmony import */ var _append__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./append */ "./src/append.ts");
/* harmony import */ var _form__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./form */ "./src/form.ts");
/* harmony import */ var _basket__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./basket */ "./src/basket.ts");
/* harmony import */ var _cookies__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./cookies */ "./src/cookies.ts");
/* harmony import */ var _cakes__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./cakes */ "./src/cakes.ts");
/* harmony import */ var _muffins__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./muffins */ "./src/muffins.ts");
//  import _ from 'lodash';








window.ShowHardCodedProducts = _data__WEBPACK_IMPORTED_MODULE_0__.ShowHardCodedProducts;
window.append = _append__WEBPACK_IMPORTED_MODULE_1__.append;
window.getFormData = _form__WEBPACK_IMPORTED_MODULE_2__.getFormData;
window.AddToBasket = _basket__WEBPACK_IMPORTED_MODULE_3__.AddToBasket;
window.AppendToBasket = _basket__WEBPACK_IMPORTED_MODULE_3__.AppendToBasket;
window.ShowCookies = _cookies__WEBPACK_IMPORTED_MODULE_4__.ShowCookies;
window.ShowCakes = _cakes__WEBPACK_IMPORTED_MODULE_5__.ShowCakes;
window.ShowMuffins = _muffins__WEBPACK_IMPORTED_MODULE_6__.ShowMuffins;

})();

/******/ })()
;
//# sourceMappingURL=bundle.js.map