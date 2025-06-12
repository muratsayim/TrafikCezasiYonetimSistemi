using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafik_Cezası_Yazılımı_TR
{
        public abstract class Ceza
        {
            public string SurucuAdi { get; set; }
            public decimal Tutar { get; protected set; }
            public bool OdenmeDurumu { get; private set; }
            public DateTime Tarih { get; set; }
            public string Yer { get; set; }
            public string Aciklama { get; set; }

            public void Ode()
            {
                OdenmeDurumu = true;
            }

            public abstract string CezaTipi { get; }

            public override string ToString()
            {
                return $"{SurucuAdi} - {CezaTipi} - {Tutar} ₺ - {(OdenmeDurumu ? "Ödendi" : "Ödenmedi")} - {Tarih.ToShortDateString()} - {Yer} - {Aciklama}";
            }
        }

        public class HizCezasi : Ceza
        {
            public override string CezaTipi => "Hız Cezası";
            public HizCezasi() => Tutar = 250m;
        }

        public class ParkCezasi : Ceza
        {
            public override string CezaTipi => "Park Cezası";
            public ParkCezasi() => Tutar = 150m;
        }

        public class KirmiziIsikCezasi : Ceza
        {
            public override string CezaTipi => "Kırmızı Işık Cezası";
            public KirmiziIsikCezasi() => Tutar = 350m;
        }
    }