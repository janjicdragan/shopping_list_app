using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppingList.Controllers
{
    public class ShoppingListController : ApiController
    {
        public static List<Models.ShoppingList> shoppingLists = new List<Models.ShoppingList>
        {
            new Models.ShoppingList() {Id = 0, Name = "Groceries", Items = {
                new Models.Item() { Id = 0, Name = "Milk", ShoppingListId = 0},
                new Models.Item() { Id = 1,Name = "Cornflakes", ShoppingListId = 0},
                new Models.Item() { Id = 2, Name = "Bread", ShoppingListId = 0} 
                } 
            },
            new Models.ShoppingList() {Id = 1, Name = "Hardware"}
        };
        // GET: api/ShoppingList/5
        public IHttpActionResult Get(int id)
        {
            Models.ShoppingList result = shoppingLists.FirstOrDefault(s => s.Id == id);

            if(result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // POST: api/ShoppingList
        public IEnumerable Post([FromBody]Models.ShoppingList newList)
        {
            newList.Id = shoppingLists.Count;
            shoppingLists.Add(newList);

            return shoppingLists;
        }
    }
}
