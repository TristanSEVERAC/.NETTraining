using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class StringCalculator : Calculator
    {

         //Constructeur surchargé
        public StringCalculator(string Name)
        {
           
        }

        @Override
        public double Sum(double[] valeurs)
        {
            double resultat = 0;
            foreach (double valeur in valeurs)
            {
                resultat += valeur;
            }
            return resultat;

        }
    }
}
