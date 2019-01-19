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

        public List<string> WrzytajDaneSkoczni()
        {
            List<string> nazwy = query.getSkocznieNazwy();
            List<string> miasta = query.getSkocznieMiasta();
            List<string> kPkt = query.getSkocznieK();
            List<string> skocznie = new List<string>();


            for (int i = 0; i < nazwy.Count; ++i)
            {
                skocznie.Add(nazwy[i] + " Miasto : " + miasta[i] + " Punkt K: " + kPkt[i]);
            }
            return skocznie;
        }

        public List<string> WczytajDaneZawodnikow()
        {
            List<string> imiona = query.getZawodnicyImiona();
            List<string> nazwiska = query.getZawodnicyNazwiska();
            List<string> wzrost = query.getZawodnicyWzrost();

            List<string> zawodnicy = new List<string>();

            for (int i = 0; i < imiona.Count; ++i)
            {
                zawodnicy.Add(imiona[i] + " " + nazwiska[i] + " Wzrost : " + wzrost[i]);
            }
            return zawodnicy;
        }
        public List<string> WczytajDaneTrenerow()
        {
            List<string> imiona = query.getTrenerzyImiona();
            List<string> nazwiska = query.getTrenerzyNazwiska();
            List<string> trenerzy = new List<string>();

            ElementsList.Content = "";

            for (int i = 0; i < imiona.Count; ++i)
            {
                trenerzy.Add(imiona[i] + " " + nazwiska[i]);
            }
            return trenerzy;
        }

        public zawodnicy pobierzIdZawodnika(int id)
        { 
            return query.getSkoczek(id);
        }

       
    }
}

