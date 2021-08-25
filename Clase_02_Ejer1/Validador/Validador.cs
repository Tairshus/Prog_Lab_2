using System;

namespace Validadores
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }
    }
}
