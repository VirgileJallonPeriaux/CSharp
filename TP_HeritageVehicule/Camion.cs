using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Heritage
{
    class Camion : Vehicule
    {
        private bool _semiRemorque;
        private int _essieux;

        public Camion(string immatriculation, int anneeConstruction, string marque, string modele, bool semiRemorque, int essieux) : base(immatriculation, anneeConstruction, marque, modele)
        {
            _semiRemorque = semiRemorque;
            _essieux = essieux;
        }

        public override void Afficher()
        {
            Console.WriteLine( (_semiRemorque ? "Semi-remorque" : "Camion") + " avec " + _essieux + " essieux");
            base.Afficher();
        }
    }
}
