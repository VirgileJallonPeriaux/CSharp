using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex3
{
    class Camion:Vehicule
    {
        private bool _semiRemorque;
        private int _essieux;

        public Camion(string immatriculation, int anneeConstruction, string marque, string modele, bool semiRemorque, int essieux):base(immatriculation,anneeConstruction,marque,modele)
        {
            _semiRemorque = semiRemorque;
            _essieux = essieux;
        }

        public override void Afficher()
        {
            string semiRemorqueS = "Camion";
            if (_semiRemorque) { semiRemorqueS = "Semi remorque"; }
            Console.WriteLine(semiRemorqueS+" avec "+_essieux+" essieux");
            base.Afficher();
        }

    }
}
