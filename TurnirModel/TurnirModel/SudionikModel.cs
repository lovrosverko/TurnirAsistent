using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirModel
{
    class SudionikModel
    {
        /// <summary>
        /// Predstavlja jednu ekipu u utakmici
        /// </summary>
        public EkipaModel NatjecateljskaEkipa { get; set; }
        /// <summary>
        /// Predstavlja rezultat za ovu ekipu
        /// </summary>
        public double Rezultat { get; set; }
        /// <summary>
        /// Predstavlja prethodnu utakmicu u kojoj je 
        /// ova ekipa pobijedila
        /// </summary>
        public UtakmicaModel PrethodnaUtakmica { get; set; }

    }
}
