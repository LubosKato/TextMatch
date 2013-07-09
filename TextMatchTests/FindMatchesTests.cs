using NUnit.Framework;
using TextMatchLogic;

namespace TextMatchTests
{
    [TestFixture]
    public class FindMatchesTests : TestSetup
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
        }

        [Test]
        public void Test_SuccessFull_Match_For_First_Valid_Text()
        {
            logic.SubText = subTextValid;
            var result = logic.Process();
            Assert.AreEqual("1, 26, 51", result);
            Assert.AreEqual(3, result.GetNumberOfOccurences());
        }

        [Test]
        public void Test_SuccessFull_Match_For_First_Valid_Text_Upper_Case()
        {
            logic.SubText = subTextUpperCaseValid;
            var result = logic.Process();
            Assert.AreEqual("1, 26, 51", result);
            Assert.AreEqual(3, result.GetNumberOfOccurences());
        }

        [Test]
        public void Test_SuccessFull_Match_For_Second_Valid_Text()
        {
            logic.SubText = subTextValid1;
            var result = logic.Process();
            Assert.AreEqual("3, 28, 53, 78, 82", result);
            Assert.AreEqual(5, result.GetNumberOfOccurences());
        }

        [Test]
        public void Test_NOT_SuccessFull_Match_For_First_InValid_Text()
        {
            logic.SubText = subTextInvalid;
            Assert.AreEqual("There is no output", logic.Process());
        }

        [Test]
        public void Test_NOT_SuccessFull_Match_For_Second_InValid_Text()
        {
            logic.SubText = subTextInvalid1;
            Assert.AreEqual("There is no output", logic.Process());
        }

        [Test]
        public void Test_Both_Input_Texts_Are_Null()
        {
            var result = logic.Process();
            Assert.IsNotNull(result);
            Assert.AreEqual("There is no output", result);
        }

        [Test]
        public void Test_Big_Main_Text()
        {
            var logic = new ProcessTextMatch() { MainText = BigMainText, SubText = subTextValid };
            var result = logic.Process();
            Assert.IsNotNull(result);
            Assert.AreEqual(303, result.GetNumberOfOccurences()); // (100 + 1) * 3 = 303
        }
    }
}
