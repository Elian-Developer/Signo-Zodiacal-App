using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppZodiac.Service
{
    public class SignoZodiacoService
    {
        public static string DeterminarSigno(int dia, int mes)
        {
            string SignoZodiacal = "";

            if (dia >= 21 && mes == 3 || dia <= 20 && mes == 4)
            {
                SignoZodiacal = "Aries";
            }

            if (dia >= 21 && mes == 4 || dia <= 21 && mes == 5)
            {
                SignoZodiacal = "Tauro";
            }
            if (dia >= 22 && mes == 5 || dia <= 21 && mes == 6)
            {
                SignoZodiacal = "Géminis";
            }
            if (dia >= 22 && mes == 6 || dia <= 22 && mes == 7)
            {
                SignoZodiacal = "Cáncer";
            }
            if (dia >= 23 && mes == 7 || dia <= 23 && mes == 8)
            {
                SignoZodiacal = "Leo";
            }
            if (dia >= 24 && mes == 8 || dia <= 23 && mes == 9)
            {
                SignoZodiacal = "Virgo";
            }
            if (dia >= 24 && mes == 9 || dia <= 23 && mes == 10)
            {
                SignoZodiacal = "Libra";
            }
            if (dia >= 24 && mes == 10 || dia <= 22 && mes == 11)
            {
                SignoZodiacal = "Escorpión";
            }
            if (dia >= 23 && mes == 11 || dia <= 21 && mes == 12)
            {
                SignoZodiacal = "Sagitario";
            }
            if (dia >= 22 && mes == 12 || dia <= 20 && mes == 1)
            {
                SignoZodiacal = "Capricornio";
            }
            if (dia >= 21 && mes == 1 || dia <= 18 && mes == 2)
            {
                SignoZodiacal = "Acuario";
            }
            if (dia >= 19 && mes == 2 || dia <= 20 && mes == 3)
            {
                SignoZodiacal = "Piscis";
            }

            return SignoZodiacal;
        }
    }
}
