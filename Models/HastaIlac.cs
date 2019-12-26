﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HastaIlac
    {
        public class Ogrenci
        {
            public int HastailacID { get; set; }

            //[Column(TypeName ="varchar")]
            //[MaxLength(50)]
            //[Required]
            public int verilis { get; set; }
            //[Column(TypeName = "varchar")]
            //[MaxLength(75)]
            //[Required]
            public int bitis { get; set; }
            //[Column(TypeName = "varchar")]
            //[MaxLength(10)]
            //[Required]
            public string sonkullanım { get; set; }
            //[Column(TypeName = "varchar")]
            //[MaxLength(10)]
            //[Required]
            public string kullanımsekli { get; set; }
            //[Column(TypeName = "varchar")]
            //[MaxLength(10)]
            //[Required]

            public int IlacId { get; set; }

            public IlacBilgi Ilacı { get; set; }

        }
    }
}
