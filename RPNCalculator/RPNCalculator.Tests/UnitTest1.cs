using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPNCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expr = "1,2,3,+,-";
            string operands = "+,-";
            RPNCalc obj = new RPNCalc();
            int result = obj.Calculate(expr, operands);
            Assert.AreEqual(-4, result);

        }
    }

    public class RPNCalc
    {

        public int Calculate(string expr, string operands)
        {
            Stack<int> itemStack = new Stack<int>();

            var oprList = operands.Split(',');
            var itemList = expr.Split(',');
            int[] finalList = null;

            for (int i = 0; i < itemList.Length; i++)
            {

                if (!oprList.Contains(itemList[i]))
                {
                    itemStack.Push(Convert.ToInt32(itemList[i]));
                }
                else
                {
                    switch (itemList[i])
                    {
                        case "+":
                            itemStack.Push(itemStack.Pop() + itemStack.Pop());
                            break;
                        case "-":
                            var x = itemStack.Pop();
                            var y = itemStack.Pop();
                            itemStack.Push(y-x);
                            break;
                    }
                }
            }

            return itemStack.Pop();
        }
    }
}
