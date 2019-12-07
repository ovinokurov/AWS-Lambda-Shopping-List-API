using LamdaShoppingListAPI.Models;
using System.Collections.Generic;

namespace LamdaShoppingListAPI.Services
{
    public interface IShoppingListService
    {
        Dictionary<string, int> GetItemsFromShoppingList();
        void AddItemsToShoppingList(ShoppingListModel shoppingList);
        void RemoveItem(string name);
    }
}
