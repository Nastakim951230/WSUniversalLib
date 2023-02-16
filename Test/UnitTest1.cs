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
        //Проверяет что при вводе не всех правильных значений метод  возратит результат -1
        public void NotCorrectResultIsWrong()
        {

            int poductType = 4;
            int materialType = 2;
            int count = 4;
            double witdh = 11;
            double height = 30;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.IsTrue(actual == -1);
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
            Assert.IsTrue(actual > -9223372036854775808 && actual< 9223372036854775808);
        }

        [TestMethod]
        //Проверяет что результат не округляется в большую сторону
        public void TheResultIsRoundedUp()
        {

            int poductType = 1;
            int materialType = 1;
            int count = 10;
            double witdh = 5;
            double height = 25;
            double except = 1380; //1379.125
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.AreNotEqual(except, actual);
        }
        //Сложные тесты
        [TestMethod]
        //Проверяет что при вводе самых больших чисел ответ будет корректный
        public void CorrecteRsultForLargeNumbers()
        {

            int poductType = 3;
            int materialType = 1;
            int count = 999999999;
            double witdh = 9999999999999999999;
            double height = 9999999999999999999;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.IsFalse(actual ==-1);
        }

        [TestMethod]
        //Проверяет что при вводе самых маленьки чисел ответ будет корректный
        public void CorrecteRsultForSmallNumbers()
        {

            int poductType = 3;
            int materialType = 1;
            int count = 0;
            double witdh = 0;
            double height = 0;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.AreEqual(0,actual);
        }
          
        [TestMethod]
        //Проверка на не существующий тип данных продукции
        public void Non_existintProductDataType()
        {

            int poductType = 421;
            int materialType = 1;
            int count = 20;
            double witdh = 65;
            double height = 120;
            double except = -1;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        //Проверка на не существующий тип данных материла
        public void Non_existintMaterialDataType()
        {

            int poductType = 1;
            int materialType = 102;
            int count = 20;
            double witdh = 65;
            double height = 120;
            double except = -1;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        //Проверка на отрицательное число 
        public void NegativeNumber()
        {

            int poductType = 1;
            int materialType = 2;
            int count = -20;
            double witdh = 65;
            double height = 120;
            double except = -1;
            double actual = Class1.MaterialFromMarriage(count, witdh, height, poductType, materialType);
            Assert.AreEqual(except, actual);
        }
    }
}
