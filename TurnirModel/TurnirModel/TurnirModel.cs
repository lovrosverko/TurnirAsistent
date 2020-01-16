using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirModel
{
    public class TurnirModel
    {
        public string NazivTurnira { get; set; }
        public decimal Kotizacija { get; set; }
        public List<EkipaModel> PrijavljeniTimovi { get; set; } = new List<EkipaModel>();
        public List<NagradaModel> Nagrade { get; set; } = new List<NagradaModel>();
        public List<List<UtakmicaModel>> Kola { get; set; } = new List<List<UtakmicaModel>>();

    }
}
