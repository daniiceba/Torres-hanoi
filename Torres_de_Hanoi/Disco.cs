﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        public int valor { get; set; }

        public Disco(int Valor)
        {
            this.valor = Valor;
        }
        public override string ToString()
        {
            return valor.ToString();
        }

    }
}
