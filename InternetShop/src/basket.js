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
    } else {
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

    const divCounter = document.querySelector('.basket-counter');

    divCounter.classList.add('basket-counter');

    divCounter.textContent = `${counter} product(s)`;

    data.basketProducts.forEach((element) => {

        let tableRow = document.createElement("tr");

        let tdTitle = document.createElement("td");
        tdTitle.classList.add('basket-title');
        tdTitle.textContent = element.title;

        tableRow.appendChild(tdTitle);

        let innerImg = document.createElement("img");
        innerImg.classList.add("table-image");
        innerImg.src = element.imageUrl;

        let tdImg = document.createElement("td");
        tdImg.appendChild(innerImg);
        tdImg.classList.add('basket-img');

        tableRow.appendChild(tdImg);

        let tdCategory = document.createElement("td");
        tdCategory.classList.add('basket-category');
        tdCategory.textContent = element.category;

        tableRow.appendChild(tdCategory);

        let tdPrice = document.createElement("td");
        tdPrice.classList.add('basket-price');
        tdPrice.textContent = element.price;

        tableRow.appendChild(tdPrice);

        tableBody.appendChild(tableRow);

    });
}

module.exports = { AddToBasket, AppendToBasket };