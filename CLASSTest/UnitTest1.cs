using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestAPlusB()
        {
            lBR.CLASS cls = new lBR.CLASS();
            cls.a = 1;
            cls.b = -2;
            cls.APlusB();
            Assert.AreEqual(cls.c,-1);
        }
        [Test]
        public void TestCMinusChislo()
        {
            lBR.CLASS cls = new lBR.CLASS();
            cls.c = 10;
            cls.CMinusChislo(2);
            Assert.AreEqual(cls.c, 8);
        }
    }
}