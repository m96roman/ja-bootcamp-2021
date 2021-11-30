/**
 * @jest-environment jsdom
 */
'use strict';

const {ShowHardCodedProducts} = require("../data.js"); 


const fakeLocalStorage = (function() {
    let store = {};
  
    return {
      getItem: function(key) {
        return store[key] || null;
      },
      setItem: function(key, value) {
        store[key] = value.toString();
      },
      removeItem: function(key) {
        delete store[key];
      },
      clear: function() {
        store = {};
      }
    };
  })();


  describe('storage', () => {
    beforeAll(() => {
      Object.defineProperty(window, 'localStorage', {
        value: fakeLocalStorage,
      });
    });
  
    it('saves the key to the storage', () => {
        ShowHardCodedProducts('key', 'fake-value');
  
        expect(window.localStorage.getItem('key')).toEqual('fake-value');
    });
  });
