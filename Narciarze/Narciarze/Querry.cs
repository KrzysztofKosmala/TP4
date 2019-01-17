using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Narciarze
{
    public class Querry
    {
        AdventureWorksDataContext db = new AdventureWorksDataContext();


        public string getSkoczek(int id)
        {
            string skoczek = (from zawodnicy in db.zawodnicy
                              where zawodnicy.id_skoczka == id
                              select zawodnicy.imie).First().ToString();
            return skoczek;
        }



        public List<string> ListaSkoczkow()
        {
            var skoczkowie = from zawodnicy in db.zawodnicy
                              select zawodnicy.imie;

            List<string> skoczkowieLista = skoczkowie.ToList();

            return skoczkowieLista;
        }

        public string getSkocznia(int id)
        {
            string skocznia = (from skocznie in db.skocznie
                               where skocznie.id_skoczni == id
                               select skocznie.nazwa).First().ToString();
            return skocznia;
        }

        public List<string> ListaSkoczni()
        {
            var skoczniee = from skocznie in db.skocznie
                             select skocznie.nazwa;

            List<string> skocznieLista = skoczniee.ToList();

            return skocznieLista;
        }

        public string getTrener(int id)
        {
            string trener = (from trenerzy in db.trenerzy
                               where trenerzy.id_trenera == id
                               select trenerzy).First().ToString();
            return trener;
        }

        public List<string> ListaTrenerow()
        {
            
            var trener = from trenerzy in db.trenerzy
                            select trenerzy.imie_t;

            List<string> trenerzyLista = trener.ToList();

            return trenerzyLista;
        }


    }
}
