using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarKliens.DTOs
{
    internal class KonyvtarakDTO
    {
        public int Id { get; set; }
        public string KonyvtarNev { get; set; }
        public int Irsz { get; set; }
        public string Cim { get; set; } = null!;
        public string Telepnev { get; set; }
        public string Megyenev { get; set; }
    }
}
