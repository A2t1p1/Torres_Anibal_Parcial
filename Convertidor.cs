using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_Anibal_Parcial
{
    class Convertidor
    {
        public string[] tipo = { "Monedas", "Almacenamiento" };
        public string[][] etiquetas =
        {
            new string[]{"Dolares","Colones","Yenes","Rupias","Peso(Chileno)","Peso(Argentino)","Bitcoin"},
            new string[]{"Megabyte", "Bit", "Byte", "Kilobyte", "Gigabyte", "Terabyte"}
        };
        public double[][] valores = {
        new double[]{1,8.75,111.27,69.75,667.08,19.36,39.69,0.00026},
        new double[]{1, 8388608, 1048576, 1024, 0.0009765625, 0.00000095367431660625}
        };
        public double Convertir(int de, int a ,double cantidad, int opcion)
        {
            return Math.Round(valores[opcion][a] / valores[opcion][de] * cantidad, 2);

        }

    }

}
