using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Heritage
{
    class Vehicule
    {
        private string _immatriculation;
        private int _anneeConstruction;
        private string _marque;
        private string _modele;

        public Vehicule(string immatriculation, int anneeConstruction, string marque, string modele)
        {
            _immatriculation = immatriculation;
            _anneeConstruction = anneeConstruction;
            _marque = marque;
            _modele = modele;
        }

        public virtual void Afficher()
        {
            Console.WriteLine("Immatriculation : " + _immatriculation);
            Console.WriteLine("Année de construction : " + _anneeConstruction);
            Console.WriteLine("Marque : " + _marque);
            Console.WriteLine("Modele : " + _modele + "\n");
        }
    }
}
