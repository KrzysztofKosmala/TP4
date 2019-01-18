using Microsoft.VisualStudio.TestTools.UnitTesting;
using Narciarze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narciarze.Tests
{
    [TestClass()]
    public class QuerryTests
    {
        [TestMethod()]
        public void getSkoczekImieTest()
        {

            Querry query = new Querry();
            string expected = "Marcin";
            string result;

            result = query.getSkoczek(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ListaSkoczkowTest()
        {
            Querry query = new Querry();
            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Marcin" };
            result = query.ListaSkoczkow();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getSkoczniaNazwaTest()
        {
            Querry query = new Querry();
            string expected = "Wielka Krokiew";
            string result;

            result = query.getSkocznia(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ListaSkoczniTest()
        {
            Querry query = new Querry();
            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Wielka Krokiew" };
            result = query.ListaSkoczni();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getTrenerTest()
        {
            Querry query = new Querry();
            string expected = "Alexander";
            string result;

            result = query.getTrener(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ListaTrenerowTest()
        {
            Querry query = new Querry();

            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Alexander" };
            result = query.ListaTrenerow();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getSkocznieNazwyTest()
        {
            Querry query = new Querry();

            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Wielka Krokiew" };
            result = query.ListaSkoczni();

            Assert.AreEqual(expected[0], result[0]);
        }

        

        [TestMethod()]
        public void getSkocznieMiastaTest()
        {
            Querry query = new Querry();

            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Zakopane" };
            result = query.getSkocznieMiasta();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getZawodnicyImionaTest()
        {
            Querry query = new Querry();

            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Marcin" };
            result = query.getZawodnicyImiona();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getZawodnicyNazwiskaTest()
        {
            Querry query = new Querry();

            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "BACHLEDA" };
            result = query.getZawodnicyImiona();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getZawodnicyWzrostTest()
        {
            Querry query = new Querry();

            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "166" };
            result = query.getZawodnicyWzrost();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getTrenerzyImionaTest()
        {
            Querry query = new Querry();

            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Alexander" };
            result = query.getTrenerzyImiona();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getTrenerzyNazwiskaTest()
        {
            Querry query = new Querry();

            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Pointer" };
            result = query.getTrenerzyNazwiska();

            Assert.AreEqual(expected[0], result[0]);
        }
    }
}