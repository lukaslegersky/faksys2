using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using faksys2.Data;

namespace faksys2.Lidi
{
    public class Komu
    {
            public int Id { get; set; }

            public string Odberatel { get; set; }

            public string Adresa { get; set; }

            public string Ic { get; set; }

            public string Dic { get; set; }

            public string Tel { get; set; }

            public string Email { get; set; }

            public string CisUc { get; set; }







        public override string ToString()
            {
                return $"{Id} {Odberatel} {Adresa} {Ic} {Dic} {Tel} {Email} {CisUc}";
            }
        }
    }
