﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using console_chess.tabuleiro;

namespace xadrez
{
    class Rei : Peca  
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        { 
        }
            public override string ToString()
        {
            return "R";
        }
    }
    
}
