using Microsoft.VisualStudio.TestTools.UnitTesting;
using q1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1.Tests
{
    [TestClass()]
    public class NumCountTests
    {
        INumCount NumCount;

        public NumCountTests()
        {
            NumCount = new NumCount();
        }

        [TestMethod()]
        public void NumSort_Mult_033_Input_Int_SortDesc_Out_Double()
        {
            string[] amountList = { "1","2","-1","-2" };
            string[] except = { "0.66", "0.33","-0.33", "-0.66" };
            var ans = NumCount.NumSort(amountList);
            CollectionAssert.AreEqual(except, ans);
        }

        [TestMethod()]
        public void NumSort_Mult_033_Input_SortDesc_Out_0()
        {
            string[] amountList = { "-", "-0.5", "-1", "-" };
            string[] except = { "0", "0", "-0.165", "-0.33" };
            var ans = NumCount.NumSort(amountList);
            CollectionAssert.AreEqual(except, ans);
        }

        [TestMethod()]
        public void NumSort_Input_StringEmpty_Out_AggregateException()
        {
            string[] amountList = { "1", " ", "-1", "-2" };
            string except = "輸入格式錯誤";
            try
            {
                var ans = NumCount.NumSort(amountList);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(except,ex.Message);
            }
        }

        [TestMethod()]
        public void NumSort_Input_NotDouble_Out_AggregateException()
        {
            string[] amountList = { "1", "Test", "-1", "-2" };
            string except = "輸入格式錯誤";
            try
            {
                var ans = NumCount.NumSort(amountList);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(except, ex.Message);
            }
        }
    }
}