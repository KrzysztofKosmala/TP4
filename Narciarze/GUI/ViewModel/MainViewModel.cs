using Narciarze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModel
{
    class MainViewModel
    {
        public ElementsListViewModel ElementsList { get; private set; }
        public Querry query = new Querry();

        public MainViewModel()
        {
            ElementsList = new ElementsListViewModel();
        }

        public void WrzytajDaneSkoczni()
        {
            List<string> nazwy = query.getSkocznieNazwy();
            List<string> miasta = query.getSkocznieMiasta();
            List<string> kPkt = query.getSkocznieK();

            ElementsList.Content = "";

            for (int i = 0; i < nazwy.Count; ++i)
            {
                ElementsList.Content += nazwy[i] + " " + miasta[i] + " pkt K "
                                     + kPkt[i] + Environment.NewLine;
            }
        }

        public void WczytajDaneZawodnikow()
        {
            List<string> imiona = query.getZawodnicyImiona();
            List<string> nazwiska = query.getZawodnicyNazwiska();
            List<string> wzrost = query.getZawodnicyWzrost();

            ElementsList.Content = "";

            for (int i = 0; i < imiona.Count; ++i)
            {
                ElementsList.Content += imiona[i] + " " + nazwiska[i] + " wzrost: "
                                     + wzrost[i] + Environment.NewLine;
            }
        }
        public void WczytajDaneTrenerow()
        {
            List<string> imiona = query.getTrenerzyImiona();
            List<string> nazwiska = query.getTrenerzyNazwiska();

            ElementsList.Content = "";

            for (int i = 0; i < imiona.Count; ++i)
            {
                ElementsList.Content += imiona[i] + " "+nazwiska[i] + Environment.NewLine;
            }
        }

       
    }
}

