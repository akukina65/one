using ClassLibrary1;
namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Class1 class1 = new Class1();
        //    List<double> input = new List<double>() { -1, -2, -3 };
        //    double expectedAverage = -2;

        //    // Act
        //    double actualAverage = class1.Kas(input);

        //    // Assert
        //    Assert.AreEqual(expectedAverage, actualAverage, 0.001);
        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    Class1 class1 = new Class1();
        //    List<double> input1 = new List<double>() { 1, 2, 3 };

        //    // Act
        //    double actualAverage1 = class1.Kas(input1);

        //    // Assert
        //    Assert.IsTrue(double.IsNaN(actualAverage1));
        //}

        //[TestMethod]
        //public void TestMethod3()
        //{
        //    Class1 class2 = new Class1();
        //    string str = "кот";

        //    // Act
        //    bool actualAverage1 = class2.Kas1(str);

        //    // Assert
        //   Assert.AreEqual(false, actualAverage1);
        //}

        //[TestMethod]
        //public void TestMethod4()
        //{
        //    Class1 class3 = new Class1();
        //    string str = "кот";
        //    string str1 = "котпва";

        //    string v = "кот";
        //    // Act
        //    string actualAverage1 = class3.IsPalindrome( str, str1);

        //    // Assert
        //    Assert.AreEqual(actualAverage1, v);
        //}



        //[TestMethod]
        //public void Test4()
        //{
        //    Class1 class5 = new Class1();
        //    List<double> list = new List<double>() { -5, -1, 4, 2, 7, 0 };
        //    double d = class5.Kas(list);
        //    double avg = -3;
        //    Assert.AreEqual(d, avg, 0.0001);

        //}

        //[TestMethod]
        //public void Las()
        //{
        //    Class1 class6 = new Class1();
        //    List<double> list = new List<double>() { -4, 5, 6, 12, 87, 0 };
        //    double max = class6.Kas2(list);
        //    double max1 = 87;
        //    Assert.AreEqual(max, max1);

        //}

        //[TestMethod]
        //public void Las2()
        //{
        //    Class1 class6 = new Class1();
        //    List<double> list = null;

        //    Assert.IsNull(list, "Список не должен быть равен null");
        //}
        //[TestMethod]
        //public void gas()
        //{
        //    Class1 class1 = new Class1();
        //    List<double> list = new List<double>() { 4, 6, 12, 78, -3, 3, 5, 0 };
        //   int g =  class1.Las(list);
        //    int h = 5;
        //    Assert.AreEqual(g, h);
        //}

        [TestMethod]
        public void Kasd()
        {
            string str = "арфа";
            string str1 = "фара";
            Class1 class5 = new Class1();
           bool l =  class5.has(str, str1);
            Assert.AreEqual(l,true);

        }

    }

    
    
}
