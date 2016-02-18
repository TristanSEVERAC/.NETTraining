using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class Calculator
    {

        private string name;


        //Constructeur surchargé
        public Calculator(string Name)
        {
            this.name = Name;
        }

        //Constructeur par défaut
        public Calculator()
        {
        }

        public string Name { get; set; }

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
