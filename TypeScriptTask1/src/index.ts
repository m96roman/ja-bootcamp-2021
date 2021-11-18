//  import _ from 'lodash';

import * as _ from 'lodash';

import {ShowHardCodedProducts} from "./data";
import {append} from "./append";
import {getFormData} from "./form";
import {AddToBasket} from "./basket";
import {AppendToBasket} from "./basket";
import {ShowCookies} from "./cookies";
import {ShowCakes} from "./cakes";
import {ShowMuffins} from "./muffins";


(window as any)!.ShowHardCodedProducts = ShowHardCodedProducts;
(window as any)!.append = append;
(window as any)!.getFormData = getFormData;
(window as any)!.AddToBasket = AddToBasket;
(window as any)!.AppendToBasket = AppendToBasket;
(window as any)!.ShowCookies = ShowCookies;
(window as any)!.ShowCakes = ShowCakes;
(window as any)!.ShowMuffins = ShowMuffins;






