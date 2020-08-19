using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BottlesOfBeer
{
    [TestClass]
    [UseReporter(typeof(DiffReporter))]
    public class BottlesTest
    {
        [TestMethod]
        public void TestTheFirstVerse()
        {
            Approvals.Verify(new Bottles().Verse(99));
        }

        [TestMethod]
        public void TestAnotherVerse()
        {
            Approvals.Verify(new Bottles().Verse(3));
        }

        [TestMethod]
        public void TestVerse2()
        {
            Approvals.Verify(new Bottles().Verse(2));
        }

        [TestMethod]
        public void TestVerse1()
        {
            Approvals.Verify(new Bottles().Verse(1));
        }

        [TestMethod]
        public void TestVerse0()
        {
            Approvals.Verify(new Bottles().Verse(0));
        }

        [TestMethod]
        public void TestACoupleOfVerses()
        {
            Approvals.Verify(new Bottles().Verses(99, 98));
        }

        [TestMethod]
        public void TestAFewVerses()
        {
            Approvals.Verify(new Bottles().Verses(2, 0));
        }

        [TestMethod]
        public void TestTheWholeSong()
        {
            Approvals.Verify(new Bottles().Song());
        }
    }
}