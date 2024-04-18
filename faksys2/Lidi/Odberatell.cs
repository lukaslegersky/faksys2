using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faksys2.Lidi
{
    public class Odberatell
    {
    
            public int Id { get; set; }

            public string Typpolozky { get; set; }

            public string Cena { get; set; }

            public string Zplatnost { get; set; }

            public string Odberatel { get; set; }


            public override string ToString()
            {
                return $"{Id} {Odberatel} {Typpolozky} {Cena} {Zplatnost}";
            }
        }
    }

