using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPOOex6
{
    class Distancia
    {
        private double milhas;
        private double quilometros;

        public void setMilhas(int p)
        {
            milhas = p;
        }

        public double getMilhas()
        {
            return milhas;
        }

        public double getQuilometros()
        {
            return quilometros;
        }

        public void converterDistancia()
        {
            quilometros = milhas * 1852;
        }
    }
}
