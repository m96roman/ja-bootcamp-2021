const ShowCookies = () => {

    const dataBasket = JSON.parse(sessionStorage.getItem("basket"));

    if (dataBasket !== null) {
        const counter = dataBasket.basketProducts.length;
        const divCounter = document.querySelector('.basket-counter');
        divCounter.classList.add('basket-counter');
        divCounter.textContent = `${counter} product(s)`;
    }

    const data = JSON.parse(localStorage.getItem("products"));

    const productsContainer = document.querySelector('.main-container');

    data.productList.find(element => {

        if (element.category === "cookie") {

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

        }
    })
}

module.exports = { ShowCookies };