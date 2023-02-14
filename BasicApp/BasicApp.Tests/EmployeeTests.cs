namespace BasicApp.Tests
{
    public class Tests
    {
        [Test]
        public void AddAndSumScoreTest1()
        {
            // arange
            Employee emp = new Employee("name", "surname", 0);
            int result = 0;

            // act
            emp.AddScore(1);
            emp.AddScore(2);
            emp.AddScore(3);
            result = emp.SumScore();

            // assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void AddAndSumScoreTest2()
        {
            // arange
            Employee emp = new Employee("name", "surname", 0);
            int result = 0;

            // act
            emp.AddScore(3);
            emp.AddScore(5);
            emp.AddScore(-8);
            result = emp.SumScore();

            // assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void AddAndSumScoreTest3()
        {
            // arange
            Employee emp = new Employee("name", "surname", 0);
            int result = 0;

            // act
            emp.AddScore(7);
            emp.AddScore(-2);
            emp.AddScore(-15);
            result = emp.SumScore();

            // assert
            Assert.AreEqual(-10, result);
        }
    }
}