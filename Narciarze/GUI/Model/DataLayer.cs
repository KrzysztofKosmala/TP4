using Narciarze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Model
{
    class DataLayer
    {
        Querry querry = new Querry();
        public IEnumerable<String> SkocznieReviews
        {
            get
            {
                List<String> reviews = querry.ListaSkoczni();
                return reviews;
            }
        }

        public IEnumerable<String> SkoczkowieReviews
        {
            get
            {
                List<String> skoczkowie = querry.ListaSkoczkow();
                return skoczkowie;
            }
        }

        public IEnumerable<String> TrenerzyReviews
        {
            get
            {
                List<String> trenerzy = querry.ListaTrenerow();
                return trenerzy;
            }
        }
    }
}
