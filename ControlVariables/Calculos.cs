using System;

namespace RelojeriaColas.ControlVariables
{
    public static class Calculos
    {
        public static bool EsPrimoRelativo(int numero1, int numero2)
        {
            int resto;
            while (numero2 != 0)
            {
                resto = numero1 % numero2;
                numero1 = numero2;
                numero2 = resto;
            }
            return numero1 == 1 || numero1 == -1;
        }
        public static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static double TruncateDigits(double value, int precission)
        {
            var multiplier = (double)Math.Pow(10, precission);
            return Math.Truncate(value * multiplier) / multiplier;
        }
    }
}
