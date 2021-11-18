const { append } = require("./form");

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