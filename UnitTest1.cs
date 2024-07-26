using IronCodingChallenge;


namespace TestOldPhone
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            string expected = "E";
            string actual = OldPhonePadTranslator.OldPhonePad("33#");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2()
        {
            string expected = "B";
            string actual = OldPhonePadTranslator.OldPhonePad("227*#");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test3()
        {
            string expected = "HELLO";
            string actual = OldPhonePadTranslator.OldPhonePad("4433555 555666#");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test4()
        {
            string expected = "TURING";
            string actual = OldPhonePadTranslator.OldPhonePad("8 88777444666*664#");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test5()
        {
            string expected = "CAB";
            string actual = OldPhonePadTranslator.OldPhonePad("222 2 22#");
            Assert.AreEqual(expected, actual);
        } 
    } 
}