namespace HomeworkOneLibrary.Tests
{
    [TestClass()]
    public class WorkingWithGreetingTests
    {
        [DataRow("heeeeeellllllooooo", "hello", true)]  
        [DataRow("hlelo", "hello", false)]              
        [DataRow("HELLO", "hello", true)]              
        [DataRow("hello", "hello", true)]
        [DataRow("123123", "hello", false)]             
        [DataRow("Good Morning", "hello", false)]       
        [DataRow("Hello world!", "hello", true)]
        [DataRow("12314", "1234", true)]
        [TestMethod()]
        public void GetAnswer_CorrectParams_Success(string word, string example, bool expectedAnswer)
        {
            var actualAnswer = WorkingWithGreeting.GetAnswer(word, example);

            Assert.AreEqual(expectedAnswer, actualAnswer, $"слова {word} и {example} не совпадают");
        }

        [DataRow("", "hello", true)]
        [DataRow("hello", "",  false)]
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void GetAnswer_InvalidParams_ThrowsException(string word, string example, bool expectedAnswer)
        {
            var actualAnswer = WorkingWithGreeting.GetAnswer(word, example);

            Assert.Fail("не выброшено исключение валидации");
        }
    }
}