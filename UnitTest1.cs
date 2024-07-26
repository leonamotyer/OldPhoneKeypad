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
        [Test]
        public void Test6()
        {
            string expected = "LEONA";
            string actual = OldPhonePadTranslator.OldPhonePad("55533666 662#");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test7()
        {
            string expected = "LILY";
            string actual = OldPhonePadTranslator.OldPhonePad("555444555999#");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test8()
        {
            string expected = "ARYA";
            string actual = OldPhonePadTranslator.OldPhonePad("27779992#");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test9()
        {
            string expected = "IRON";
            string actual = OldPhonePadTranslator.OldPhonePad("444777666 66#");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test10()
        {
            string expected = "AIO";
            string actual = OldPhonePadTranslator.OldPhonePad("2444666#");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test11()
        {
            string expected = "THANK YOU FOR YOUR TIME";
            string actual = OldPhonePadTranslator.OldPhonePad("84426655099966688033366677709996668877708444633#");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test12()
        {
            string expected = "DID YOU HEAR ABOUT THE GUY THAT GOT INJURED IN THE PEEKABOO ACCIDENT";
            string actual = OldPhonePadTranslator.OldPhonePad("3444309996668804433277702 2266688 8084433048899908442804666804446658877733 30444660844330733 33552 22666 66602 222 2224443 33668#");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test13()
        {
            string expected = "INTERVIEW FOR THE ANSWER";
            string actual = OldPhonePadTranslator.OldPhonePad("44466833777888444339033366677708443302667777933777#");
            Assert.AreEqual(expected, actual);
        }



    } 
}