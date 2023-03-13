using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjeciciosEdabit;
namespace TestsEdabit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual(2, Program.Sum(1, 1));
        }
        [TestMethod]
        public void TestAdition()
        {
            Assert.AreEqual(2, Program.Addition(1));
        }
        [TestMethod]
        public void TestTriArea()
        {
            Assert.AreEqual(1, Program.TriArea(1, 2));
        }

        [TestMethod]
        public void TestMonthName()
        {
            Assert.AreEqual("January", Program.MonthName(1));
            Assert.AreEqual("June", Program.MonthName(6));
        }

        [TestMethod]
        public void TestFindMinMax()
        {
            double min = 6;
            double max = 8;

            double[] test = new double[] { min, max };

            Assert.AreEqual(test[0], Program.FindMinMax(new double[] { 8, 6 })[0]);
            Assert.AreEqual(test[1], Program.FindMinMax(new double[] { 8, 6 })[1]);
        }

        [TestMethod]
        public void TestGetAbsSum()
        {
            Assert.AreEqual(2, Program.GetAbsSum(new int[] { -1, 1 }));
        }
        [TestMethod]
        public void TestArrayOfMultiples()
        {
            int num = 5;
            int lenght = 5;

            int[] test = Program.ArrayOfMultiples(num, lenght);
            int[] correctResult = new int[] { 5, 10, 15, 20, 25 };

            for (int i = 0; i < test.Length; i++)
            {
                Assert.AreEqual(test[i], correctResult[i]);
            }
        }

        [TestMethod]
        public void TestReverseCase()
        {
            string testString = "asdASDasd";
            string correctResult = "ASDasdASD";

            Assert.AreEqual(correctResult, Program.ReverseCase(testString));
        }

        [TestMethod]
        public void TestIndexOfCapitals()
        {
            string testString = "asdASDasd";
            int[] correctResult = new int[] { 3, 4, 5 };

            int[] methodResult = Program.IndexOfCapitals(testString);

            for (int i = 0; i < methodResult.Length; i++)
            {
                Assert.AreEqual(correctResult[i], methodResult[i]);
            }
        }
        [TestMethod]
        public void TestReverseAndNot()
        {
            int test = 123;
            string correcResult = "321123";

            Assert.AreEqual(correcResult, Program.ReverseAndNot(test));
        }

        [TestMethod]
        public void TestUncensor()
        {
            string txt = "Wh*r* d*d my v*w*ls g*?";
            string vowel = "eeioeo";

            string correctResult = "Where did my vowels go?";

            Assert.AreEqual(correctResult, Program.Uncensor(txt, vowel));
        }

        [TestMethod]
        public void TestIsSmooth()
        {
            string testTxtTrue = "Marta appreciated deep perpendicular right trapezoids";
            string testTxtFalse = "Someone is outside the doorway";

            Assert.IsTrue(Program.IsSmooth(testTxtTrue));
            Assert.IsFalse(Program.IsSmooth(testTxtFalse));
        }

        [TestMethod]
        public void TestFiboWord()
        {
            Assert.AreEqual("invalid", Program.FiboWord(1));


            Assert.AreEqual("b, a, ab", Program.FiboWord(3));

            Assert.AreEqual("b, a, ab, aba, abaab, abaababa, abaababaabaab", Program.FiboWord(7));
        }

        //[TestMethod] ACA FALTA UNO DIFICIL el de "Working 9 to 5"
        //public void Test()
        //{

        //}

        [TestMethod]
        public void TestLicense()
        {
            Assert.AreEqual(40, Program.License("Eric", 2, "Adam Caroline Rebecca Frank"));
            Assert.AreEqual(100, Program.License("Zebediah", 1, "Bob Jim Becky Pat"));
            Assert.AreEqual(20, Program.License("Aaron", 3, "Jane Max Olivia Sam"));
        }

        [TestMethod]
        public void TestKaprekar()
        {
            Assert.AreEqual(5, Program.Kaprekar(6621));
            Assert.AreEqual(4, Program.Kaprekar(6554));
            Assert.AreEqual(3, Program.Kaprekar(1234));
        }
        [TestMethod]
        public void TestPalindromeDescendant()
        {
            Assert.IsFalse(Program.PalindromeDescendant(11211230));
            Assert.IsTrue(Program.PalindromeDescendant(13001120));
            Assert.IsTrue(Program.PalindromeDescendant(23336014));
            Assert.IsTrue(Program.PalindromeDescendant(11));
        }

    }
}
