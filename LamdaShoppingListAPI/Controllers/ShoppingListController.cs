using LamdaShoppingListAPI.Models;
using LamdaShoppingListAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LamdaShoppingListAPI.Controllers
{
    [Route("api/v2/shoppingList")]
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }

        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var result = _shoppingListService.GetItemsFromShoppingList();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddItemToShoppingList([FromBody]ShoppingListModel shoppingList)
        {
            _shoppingListService.AddItemsToShoppingList(shoppingList);
            return Ok(); 
        }

        [HttpDelete]
        public IActionResult DeleteItemsFromShoppingList([FromBody]ShoppingListModel shoppingList)
        {
            _shoppingListService.RemoveItem(shoppingList.Name);
            return Ok();
        }
    }


}