using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebStoreServer.Models;
using WebStoreServer.Helper;
using Newtonsoft.Json;

namespace WebStoreServer.Controllers
{
    public class AuthController : ApiController
    {
        private WebStoreServerContext db = new WebStoreServerContext();

        [HttpPost]
        public async Task<IHttpActionResult> Register([FromBody]UserInfo userInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            db.UserDetails.Add(userInfo.Details);
            db.Users.Add(userInfo.User);

            await db.SaveChangesAsync();

            return Ok();
        }
    }
}