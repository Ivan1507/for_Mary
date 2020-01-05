using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using laborat4;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AvtoSalon()
        {
            FirmCol.addFile();
            List<Firm> firms = FirmCol.get_firms();
            int SizeN = firms.Count;
            string[] a = { "Луидор", "Краснодар", "Красноземная", "Россия", "23", "23.10.2006", "luidor.ru", "2500000", "34", "605342" };
            frmCreator.add_avtosalon(a);
            firms = FirmCol.get_firms();
            int SizeK = firms.Count;
            Assert.AreEqual(SizeN + 1, SizeK);
        }
        [TestMethod]
        public void FiltrTown()
        {
            LogExpFactory factory = new LogExpFactory();
            FirmMngr firmManager = new FirmMngr();
            FiltrContr filtrContr = new FiltrContr(firmManager);
            FirmCol.addFile();
            factory.add_filter("Город", "Москва", "string", 3);
            LogExpEnum filters = factory.get_filters();
            filtrContr.sort(filters);
            List<Firm> colavto = firmManager.get_firms();

            if (colavto.Count == 3)
            {
                Assert.AreEqual("Москва", colavto[1].Field[4].get_value());
            }
        }
         [TestMethod]
        public void FilterDateOtkr()
        {
            LogExpFactory factory = new LogExpFactory();
            FirmMngr firmManager = new FirmMngr();
            FiltrContr filter_contr = new FiltrContr(firmManager);
            FirmCol.addFile();
            factory.add_filter("Дата открытия", "08.02.2011", "string", 3);
            LogExpEnum filters = factory.get_filters();
            filter_contr.sort(filters);
            List<Firm> colavto = firmManager.get_firms();

            if (colavto.Count == 3)
            {
                Assert.AreEqual("19.11.2016", colavto[0].Field[1].get_value());
            }
        }
    }
 }

