using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        private CzyPalindrom _czyPalindrom;
       
  
        [TestMethod()]
        public void CzyPalindromTest()
        {
            _czyPalindrom = new CzyPalindrom();
            Assert.AreEqual(true,_czyPalindrom.SprawdzPoprawnosc(55));
        }
    }
}