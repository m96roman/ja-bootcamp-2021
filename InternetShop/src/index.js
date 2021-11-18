const {getFormData} = require("./form");
const {append} = require("./append");
const {ShowHardCodedProducts} = require("./data");
const {AddToBasket} = require("./basket");
const {AppendToBasket} = require("./basket");
const {ShowMuffins} = require("./muffins");
const {ShowCakes} = require("./cakes");
const {ShowCookies} = require("./cookies");

window.ShowCookies = ShowCookies;
window.ShowCakes = ShowCakes;
window.ShowMuffins = ShowMuffins;
window.AppendToBasket = AppendToBasket;
window.AddToBasket = AddToBasket;
window.append = append;
window.getFormData = getFormData;
window.ShowHardCodedProducts = ShowHardCodedProducts;

