using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AplicacionMovil.Models;
namespace XamarinLogin.Controllers
{
    [RoutePrefix("api/Login")]
    public class LoginController : ApiController
    {
        UHConsultaEntities db = new UHConsultaEntities();  
        
        [HttpPost]
        [ActionName("XAMARIN_REG")]
        // POST: api/Login  
        public HttpResponseMessage Xamarin_reg(string username, string password)
        {
            contraseña pass = new contraseña();
            usuario user = new usuario();
            user.email = username;
            pass.pass = password;
            db.contraseña.Add(pass);
            db.usuario.Add(user);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Accepted, "Successfully Created");
        }
        [HttpGet]
        [ActionName("XAMARIN_Login")]
        // GET: api/Login/5  
        public HttpResponseMessage Xamarin_login(string username, string password)
        {
            var user = db.usuario.Where(x => x.email == username).FirstOrDefault();

            var pass = db.contraseña.Where(x => x.pass == password).FirstOrDefault();
            if (user  == null || pass == null)
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized, "Please Enter valid UserName and Password");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Accepted, "Success");
            }

        }
    }
}