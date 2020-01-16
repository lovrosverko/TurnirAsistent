using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirModel
{
    public class UtakmicaModel
    {
        public List<SudionikModel> Natjecatelji { get; set; } = new List<SudionikModel>();
        public EkipaModel Pobjednik { get; set; }
        public int BrojRunde { get; set; }
    }
}
