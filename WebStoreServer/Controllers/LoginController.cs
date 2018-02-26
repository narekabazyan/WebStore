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

namespace WebStoreServer.Controllers
{
    public class LoginController : ApiController
    {
        private WebStoreServerContext db = new WebStoreServerContext();


        // GET: api/Login/5
        [ResponseType(typeof(User))]
        public async Task<IHttpActionResult> GetUser(int id)
        {
            User user = await db.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // POST: api/Login
        [ResponseType(typeof(User))]
        public async Task<HttpResponseMessage> PostUser(User user)
        {
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            var contact = await db.Users.FirstOrDefaultAsync(x => x.Email == user.Email && x.Password == user.Password);
            if (contact is null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            var userInfo = await db.UserDetails.FirstOrDefaultAsync(x => x.UserId == contact.Id);
            userInfo.User = null;
            return Request.CreateResponse(HttpStatusCode.OK, userInfo);
        }

        // DELETE: api/Login/5
        [ResponseType(typeof(User))]
        public async Task<IHttpActionResult> DeleteUser(int id)
        {
            User user = await db.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            db.Users.Remove(user);
            await db.SaveChangesAsync();

            return Ok(user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserExists(int id)
        {
            return db.Users.Count(e => e.Id == id) > 0;
        }
    }
}