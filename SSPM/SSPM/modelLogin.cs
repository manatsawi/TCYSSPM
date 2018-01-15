using System;
using System.Collections.Generic;
using System.Text;

namespace SSPM
{
    class modelLogin : ImodelLogin()
    {
        public string user { get; set; }
        public string pass { get; set; }
    }
}
