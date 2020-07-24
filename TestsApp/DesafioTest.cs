using System;
using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using Service.Questions;

namespace TestsApp
{
    [TestClass]
    public class DesafioTest
    {
        [TestMethod]
        public void TestDesafio1()
        {
            QuestionFactory<IQuestion>.Register(1, () => new FirstQuestion("Renan", "Tavares"));
            IQuestion question = QuestionFactory<IQuestion>.Create(1);
            var result = question.Execute();
            var count = result.ListOfResults.Count;
            Assert.AreEqual(100, count, "Válido");
        }

        [TestMethod]
        public void TestDesafio2()
        {
            QuestionFactory<IQuestion>.Register(2, () => new SecondQuestion(new int[] { 1, 2, 3, 4, 5 }));
            IQuestion question = QuestionFactory<IQuestion>.Create(2);
            var result = question.Execute();
            Assert.AreEqual(55, result.ListResultsInt[0], "Válido");
        }

        [TestMethod]
        public void TestDesafio3()
        {
            QuestionFactory<IQuestion>.Register(3, () => new ThirdQuestion());
            IQuestion question = QuestionFactory<IQuestion>.Create(3);
            var result = question.Execute();
            Assert.AreEqual(10946, result.ListResultsInt[0], "Válido");
        }

        [TestMethod]
        public void TestDesafio4()
        {
            QuestionFactory<IQuestion>.Register(4, () => new FourthQuestion(TreeDomain.GenerateTree(), 9));
            IQuestion question = QuestionFactory<IQuestion>.Create(4);
            var result = question.Execute();
            int[] actual = result.ListResultsInt.ToArray();
            Array.Reverse(actual);
            CollectionAssert.AreEqual(new int[] { 1, 4, 2, 12, 13, 9 }, actual);
        }

        [TestMethod]
        public void TestDesafio6()
        {
            QuestionFactory<IQuestion>.Register(6, () => new SixthQuestion("SKY"));
            IQuestion question = QuestionFactory<IQuestion>.Create(6);
            var result = question.Execute();
            Assert.AreEqual(10, result.ListResultsInt[0], "Válido");
        }
    }
}
