﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Oiseau:IVolant
    {
        string nom = "";

        public string Description()
        {
            return $"je suis un oiseau de nom {nom}";
        }
    }
}
