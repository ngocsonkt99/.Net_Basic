using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _17072921_UngNgocSon_N131;

namespace UT3
{
    [TestClass]
    public class TestCuocDT3DRV
    {
        [TestMethod]
        public void TestMethod1()
        {
            _17072921_UngNgocSon_N131.CuocDT31 cdt = new _17072921_UngNgocSon_N131.CuocDT31();
            double actual = cdt.CuocDT3(3, 2000, true, );
            double expected = 3800; //3420
            Assert.AreEqual(expected, actual, 0.1);
        }


        [TestMethod]
        public void TestMethod2()
        {
            _17072921_UngNgocSon_N131.CuocDT31 cdt = new _17072921_UngNgocSon_N131.CuocDT31();
            double actual = cdt.CuocDT3(12, 2000, true, );
            double expected = 8800; //7920
            Assert.AreEqual(expected, actual, 0.1);
        }


        [TestMethod]
        public void TestMethod3()
        {
            _17072921_UngNgocSon_N131.CuocDT31 cdt = new _17072921_UngNgocSon_N131.CuocDT31();
            double actual = cdt.CuocDT3(22, 2000, true, );
            double expected = 12400; //14436
            Assert.AreEqual(expected, actual, 0.1);
        }

        [TestMethod]
        public void TestMethod4()
        {
            _17072921_UngNgocSon_N131.CuocDT31 cdt = new _17072921_UngNgocSon_N131.CuocDT31();
            double actual = cdt.CuocDT3(22, 2000, false, );
            double expected = 13640;  //16040
            Assert.AreEqual(expected, actual, 0.1);
        }

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\DaTaCuocDT3.csv", "DaTaCuocDT3#csv",
            DataAccessMethod.Sequential),
            DeploymentItem("DaTaCuocDT3.csv"), TestMethod]
        public void CuocDTDataDriven()
        {
            _17072921_UngNgocSon_N131.CuocDT31 c = new _17072921_UngNgocSon_N131.CuocDT31();

            int soPhut = Convert.ToInt32(TestContext.DataRow[0].ToString());
            float phiCoDinh = float.Parse(TestContext.DataRow[1].ToString());
            bool noiBo = Convert.ToBoolean(TestContext.DataRow[2].ToString());
            float expectResult = float.Parse(TestContext.DataRow[3].ToString());
            float soTienTLExpected = float.Parse(TestContext.DataRow[4].ToString());
            float soTienTL = 0;
            float actualResult = _17072921_UngNgocSon_N131.CuocDT31(soPhut, phiCoDinh, noiBo, out soTienTL);
            Assert.AreEqual(soTienTLExpected, soTienTL);
            Assert.AreEqual(expectResult, actualResult);

      
          
        }

    }
}