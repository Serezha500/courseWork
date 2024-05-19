using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;
using courseWork;

namespace Tests
{
    [TestClass]
    public class UnitTest2
    {
        public void SetPol(uint min, uint max, uint days, bool upCase, bool specSym)
        {
            Password.MinLength = min;
            Password.MaxLength = max;
            Password.Days = days;
            Password.UpCase = upCase;
            Password.SpecSym = specSym;
        }
        [TestMethod]
        public void TestMethodPassword1()
        {
            SetPol(3, 10, 5, false, false);
            Assert.AreEqual(true, Password.CheckPassword("qe4eq8"));
            Assert.AreEqual(false, Password.CheckPassword("qe"));
        }
        [TestMethod]
        public void TestMethodPassword2()
        {
            SetPol(3, 10, 5, true, false);
            Assert.AreEqual(true, Password.CheckPassword("qee15EQE"));
            Assert.AreEqual(false, Password.CheckPassword("qee15EQ#"));
        }
        [TestMethod]
        public void TestMethodPassword3()
        {
            SetPol(3, 10, 5, true, true);
            Assert.AreEqual(true, Password.CheckPassword("eEQeQE!#"));
            Assert.AreEqual(false, Password.CheckPassword("eEQeQE!#eqeqeq"));
        }
        [TestMethod]
        public void TestMethodPassword4()
        {
            SetPol(3, 10, 5, false, true);
            Assert.AreEqual(true, Password.CheckPassword("ee84!#"));
            Assert.AreEqual(false, Password.CheckPassword("eEQe!!"));
        }

    }
}
