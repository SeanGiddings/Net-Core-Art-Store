using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Net_Core_Art_Store.Pages
{
    public class DetailModel : PageModel
    {
        public string productTitle { get; set; }

        public void OnGet()
        {
            @ViewData["productTitle"] = "Hello World";
        }
    }
}
