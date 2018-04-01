using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Heritage
{
    class Voiture : Vehicule
    {
        private bool _decapotable;
        private bool _climatisation;

        public Voiture(string immatriculation, int anneeConstruction, string marque, string modele, bool decapotable, bool climatisation) : base(immatriculation, anneeConstruction, marque, modele)
        {
            _decapotable = decapotable;
            _climatisation = climatisation;
        }

        public override void Afficher()
        {
            Console.WriteLine("Voiture" +( _decapotable ? "" : " non") + " décapotable " + (_climatisation ? "avec" : "sans") + " climatisation");
            base.Afficher();
        }
    }
}
