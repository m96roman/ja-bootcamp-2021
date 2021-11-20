import { createSlice, PayloadAction } from '@reduxjs/toolkit';
import { RootState, AppThunk } from '../../app/store';
import { fetchCount } from './counterAPI';
import { Router} from "react-router-dom";


export interface IProductItem {
  name: string,
  image: string,
  description: string,
  price: number
}

export const initialState = {
  activeCategory: "AllSweets",
  prodList: [{
    name: "Muffin",
    image: "some path",
    description: "With jam filler.",
    price: 35
  },
  {
    name: "Muffin",
    image: "some path",
    description: "With jam filler.",
    price: 37
  },
  {
    name: "Muffin",
    image: "some path",
    description: "With jam filler.",
    price: 180
  },
  {
    name: "Cake",
    image: "some path",
    description: "With jam filler.",
    price: 200
  },
  {
    name: "Cake",
    image: "some path",
    description: "With jam filler.",
    price: 210
  },
  {
    name: "Cookie",
    image: "some path",
    description: "With jam filler.",
    price: 70
  },
  {
    name: "Cookie",
    image: "some path",
    description: "With jam filler.",
    price: 80
  },] 
}

export const filtered: Array<IProductItem> = [];

export const counterSlice = createSlice({
  name: 'products',
  initialState,
  reducers: {
    allSweets: (state) => {
      return state;
    },
    createProduct: (state, action: PayloadAction<IProductItem>) => {
      state.prodList.push(action.payload)
      return state;
    },
    filter: (state, action: PayloadAction<string>) => {
      state.activeCategory = action.payload;
    }
  },
});


export const { allSweets, createProduct, filter } = counterSlice.actions;

export const allProducts = (state: RootState) => state;
export const filteredProducts = (filtered: RootState) => filtered;

export default counterSlice.reducer;
