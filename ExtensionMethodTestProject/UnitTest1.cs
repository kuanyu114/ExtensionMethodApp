using ExtensionMethodApp;
namespace ExtensionMethodTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TruncateTest1()
        {
            string a = "ddfeae".Truncate(5, "aaaaaaa");
            Assert.IsTrue( a == "ddfea");
        }
        [Test]
        public void GetSubArrayTest1()
        {
            string[] a = new string[] {"aa","bb","cc"}.GetSubArray(1, 2);
            Assert.AreEqual(a ,new string[] { "bb", "cc" });
        }
        [Test]
        public void GetSubArrayTest2()
        {
            string[] a = new string[] { "aa", "bb", "cc" }.GetSubArray(-1, -1);
            Assert.AreEqual(a, new string[] { });
        }
        [Test]
        public void GetSubArrayTest3()
        {
            string[] a = new string[] { "aa", "bb", "cc" }.GetSubArray(2, 1);
            Assert.AreEqual(a, new string[] { "bb", "cc" });
        }
        [Test]
        public void GetSubArrayTest4()
        {
            string[] a = new string[] { "aa", "bb", "cc" }.GetSubArray(1, 5);
            Assert.AreEqual(a, new string[] { "bb", "cc" });
        }
    }
}