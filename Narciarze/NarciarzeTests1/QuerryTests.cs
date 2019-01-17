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
            Assert.Fail();
        }

        [TestMethod()]
        public void getSkocznieNazwyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getSkocznieKTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getSkocznieMiastaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getZawodnicyImionaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getZawodnicyNazwiskaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getZawodnicyWzrostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getTrenerzyImionaTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getTrenerzyNazwiskaTest()
        {
            Assert.Fail();
        }
    }
}