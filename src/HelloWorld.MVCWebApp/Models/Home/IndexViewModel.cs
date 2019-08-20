using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.MVCWebApp.Models.Home
{
    public class IndexViewModel
    {
        public string Name { get; set; }

        public IndexViewModel()
        {
            Name = "World";
        }
    }
}
