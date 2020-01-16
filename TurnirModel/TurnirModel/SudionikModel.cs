using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirModel
{
    class SudionikModel
    {
        public EkipaModel NatjecateljskaEkipa { get; set; }
        public double Rezultat { get; set; }
        public UtakmicaModel PrethodnaUtakmica { get; set; }

    }
}
