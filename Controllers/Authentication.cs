using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Authentication.Controllers
{
    public class AuthenticationController : Controller
    {

        [HttpGet]
        public string showRegistrationPage()
        {
            return "hi";
        }
    }
}