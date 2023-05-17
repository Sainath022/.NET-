using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace firstmvc.Controllers
{
    public class Helloworldcontroller : Controller
    {
        public string Display()
        {
            return "HELLO WORLD...";
        }

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

    }
}
