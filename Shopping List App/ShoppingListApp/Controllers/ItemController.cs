using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppingListApp.Controllers
{
    public class ItemController : ApiController
    {
        [HttpGet]
        [Route("api/shoppinglist/items")]
        public HttpResponseMessage Getall()
        {
            var data = SpListService.GetItems();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


       

            [HttpPost]
            [Route("api/shoppinglist/items/add")]
            public HttpResponseMessage Add(ItemDTO sl)
            {
                SpListService.Add(sl);
                return Request.CreateResponse(HttpStatusCode.OK);
            }



           
            [HttpDelete]
            [Route("api/shoppinglist/items/delete/{id}")]
            public HttpResponseMessage Delete(int id)
            {
                var isDeleted = SpListService.Delete(id);
               

                return Request.CreateResponse(HttpStatusCode.OK, "deleted");
            }
        }
}
