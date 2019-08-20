using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorld.RazorPagesWebApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        public IndexModel()
        {
            InitModel();
        }

        private void InitModel()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "World";
            }
        }

        public void OnGet()
        {

        }
    }
}
