using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinetix
{
    internal class MovieReserved
    {
        private int Id;
        private string Name;
        private string ImageSrc;

        public int IdMovie { get => Id; set => Id = value; }
        public string Username { get => Name; set => Name = value; }
        public string Src { get => ImageSrc; set => ImageSrc = value; }
    }
}
