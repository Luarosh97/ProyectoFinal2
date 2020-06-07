using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class Response
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Object Objeto { get; set; }
    }
}
