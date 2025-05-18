using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET  method : /HelloWorld
        public IActionResult Index()
        {
            return View();
        }

        // GET  method : /HelloWorld/Welcome
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
                
        }



        //Controller/ActionName/Parameter
    }
}
