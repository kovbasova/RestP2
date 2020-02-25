using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestP2.Models;

namespace RestP2.Controllers
{
    public class GoodsController : ApiController
    {

        private ShopEntities db = new ShopEntities();
        // /api/Goods
        public IHttpActionResult Get()
        {
            try
            {
                var goods = db.Goods.ToArray();
                return Ok(goods);
            }
            catch(Exception exc)
            {
                return InternalServerError(exc);
            }
        }

        public IHttpActionResult Post([FromBody] Goods goods)
        {
            try
            {
                var newGoods = db.Goods.Add(goods);
                db.SaveChanges();
                return Ok(newGoods);
            }
            catch (Exception exc)
            {
                return InternalServerError(exc);
            }
        }

        public IHttpActionResult Delete(int Id)
        {
            try
            {
                var goods = db.Goods.Find(Id);
                if (goods == null)
                    return NotFound();
                db.Goods.Remove(goods);
                db.SaveChanges();
                return Ok(goods);
            }
            catch (Exception exc)
            {
                return InternalServerError(exc);
            }
        }

        public IHttpActionResult Patch(int Id, [FromBody] Goods newGoods)
        {
            try
            {
                var goods = db.Goods.Find(Id);
                if (goods == null)
                    return NotFound();
                goods.Name = newGoods.Name;
                goods.Price = newGoods.Price;
                goods.Vendor = newGoods.Vendor;
                goods.Stock = newGoods.Stock;
                db.SaveChanges();
                return Ok();
            }
            catch (Exception exc)
            {
                return InternalServerError(exc);
            }
        }

    }
}
