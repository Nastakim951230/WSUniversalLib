using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Проверяет положительный ли результат
        public void PositiveNumber()
        {

            int poductType = 2;
            int materialType = 1;
            int count = 8;
            double witdh = 11;
            double height = 30;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.IsTrue(actual >= 0);
        }

        [TestMethod]
        //Проверяет на правильный результат 
        public void PositivRezultat()
        {

            int poductType = 2;
            int materialType = 1;
            int count = 8;
            double witdh = 11;
            double height = 30;
            double except = 6619.8;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.AreEqual(except,actual);
        }
        [TestMethod]
        //Проверяет на не правильный результат 
        public void Rezultat()
        {

            int poductType = 2;
            int materialType = 1;
            int count = 8;
            double witdh = 11;
            double height = 30;
            double except = 7619.8;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.AreNotEqual(except, actual);
        }

        [TestMethod]
        //Проверяет что результат не равен null
        public void NoNullRezultat()
        {

            int poductType = 3;
            int materialType = 2;
            int count = 4;
            double witdh = 11;
            double height = 30;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.IsNotNull( actual);
        }
        [TestMethod]
        //Проверяет что возращает правильный тип данных
        public void CorrectType()
        {

            int poductType = 3;
            int materialType = 2;
            int count = 4;
            double witdh = 11;
            double height = 30;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.IsInstanceOfType(actual,typeof(double));
        }
        [TestMethod]
        //Проверяет что возращает неправильный тип данных
        public void NoCorrectType()
        {

            int poductType = 3;
            int materialType = 2;
            int count = 4;
            double witdh = 11;
            double height = 30;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.IsNotInstanceOfType(actual, typeof(int));
        }

        [TestMethod]
        //Проверяет что при вводе всех правильных значенийб метод не возратит результат -1
        public void CorrectResultIsNotWrong()
        {

            int poductType = 3;
            int materialType = 2;
            int count = 4;
            double witdh = 11;
            double height = 30;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.IsFalse(actual==-1);
        }
        [TestMethod]
        //Проверяет что результат не выходит за пределы double
        public void CorrectResultTypeMAxAndMinValue()
        {

            int poductType = 3;
            int materialType = 2;
            int count = 4;
            double witdh = 2000;
            double height = 5000;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.IsTrue(actual > (-1.79*Math.Pow(10,308)) && (1.79 * Math.Pow(10, 308)) < actual);
        }
    }
}
