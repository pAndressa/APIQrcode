using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIQrcode.Models
{
    public class DadosQR
    {
        public string Texto { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public string UrlImagem { get; set; }

        public DadosQR()
        {

        }
    }
}
