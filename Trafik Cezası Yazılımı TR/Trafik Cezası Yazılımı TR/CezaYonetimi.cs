using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafik_Cezası_Yazılımı_TR
{
        public class CezaYonetimi
        {
            public List<Ceza> Cezalar { get; private set; } = new List<Ceza>();

            public void CezaEkle(Ceza ceza)
            {
                Cezalar.Add(ceza);
            }

            public List<Ceza> OdenenCezalar()
            {
                return Cezalar.Where(c => c.OdenmeDurumu).ToList();
            }

            public List<Ceza> OdenmemisCezalar()
            {
                return Cezalar.Where(c => !c.OdenmeDurumu).ToList();
            }

            public decimal ToplamBorc(string surucuAdi)
            {
                return Cezalar
                    .Where(c => c.SurucuAdi.ToLower() == surucuAdi.ToLower() && !c.OdenmeDurumu)
                    .Sum(c => c.Tutar);
            }
        }
    }