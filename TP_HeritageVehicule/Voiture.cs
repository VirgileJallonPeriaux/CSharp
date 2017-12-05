using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex3
{
    class Voiture:Vehicule
    {
        private bool _decapotable;
        private bool _climatisation;

        public Voiture(string immatriculation, int anneeConstruction, string marque, string modele, bool decapotable, bool climatisation):base(immatriculation,anneeConstruction,marque,modele)
        {
            _decapotable = decapotable;
            _climatisation = climatisation;
        }

        public override void Afficher()
        {
            string decapotableS = "Non décapotable";
            if (_decapotable) { decapotableS = "décapotable"; }
            string climatisationS = "Sans climatisation";
            if (_climatisation) { climatisationS = "Avec climatisation"; }
            Console.WriteLine("Voiture "+decapotableS+" "+climatisationS);
            base.Afficher();
        }

    }
}
