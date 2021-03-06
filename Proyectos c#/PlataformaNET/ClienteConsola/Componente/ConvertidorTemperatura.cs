﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coppel.funciones;

namespace Coppel
{
    namespace funciones
    {
        public class ConvertidorTemperatura
        {
            public enum TipoConversion : byte
            {
                NoAsignado,
                DeCaF,
                DeFaC
            }

            public double GradosC { get; set; }
            public double GradosF { get; set; }
            public TipoConversion Conversion { get; set; }

            public double Convertir()
            {
                double resultado = 0.0;

                switch (Conversion)
                {
                    case TipoConversion.DeCaF:
                        resultado = (GradosC * 1.8) + 32;
                        break;
                    case TipoConversion.DeFaC:
                        resultado = (GradosC - 32) / 1.8;
                        break;
                }

                return resultado;
            }

        }
    }  
}
