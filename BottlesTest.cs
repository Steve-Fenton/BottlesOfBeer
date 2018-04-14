using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BottlesOfBeer
{
    [TestClass]
    public class BottlesTest
    {
        [TestMethod]
        [UseReporter(typeof(DiffReporter))]
        public void TestTheFirstVerse()
        {
            Approvals.Verify(new Bottles().Verse(99));
        }

        [TestMethod]
        [UseReporter(typeof(DiffReporter))]
        public void TestAnotherVerse()
        {
            Approvals.Verify(new Bottles().Verse(3));
        }

        [TestMethod]
        [UseReporter(typeof(DiffReporter))]
        public void TestVerse2()
        {
            Approvals.Verify(new Bottles().Verse(2));
        }

        [TestMethod]
        [UseReporter(typeof(DiffReporter))]
        public void TestVerse1()
        {
            Approvals.Verify(new Bottles().Verse(1));
        }

        [TestMethod]
        [UseReporter(typeof(DiffReporter))]
        public void TestVerse0()
        {
            Approvals.Verify(new Bottles().Verse(0));
        }

        [TestMethod]
        [UseReporter(typeof(DiffReporter))]
        public void TestACoupleOfVerses()
        {
            Approvals.Verify(new Bottles().Verses(99, 98));
        }

        [TestMethod]
        [UseReporter(typeof(DiffReporter))]
        public void TestAFewVerses()
        {
            Approvals.Verify(new Bottles().Verses(2, 0));
        }

        [TestMethod]
        [UseReporter(typeof(DiffReporter))]
        public void TestTheWholeSong()
        {
            Approvals.Verify(new Bottles().Song());
        }
    }
}