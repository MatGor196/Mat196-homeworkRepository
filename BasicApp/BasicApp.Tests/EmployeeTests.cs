namespace BasicApp.Tests
{
    public class Tests
    {
        [Test]
        public void AddScoreSumScoreTest()
        {
            // arrange
            Employee emp = new Employee("name", "surname", 0);
            var result = 0;

            // act
            emp.AddScore(1);
            emp.AddScore(3);
            emp.AddScore(-3);
            emp.AddScore(2);
            result = emp.SumScore();

            // assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void MinScoreTest()
        {
            // arrange
            Employee emp = new Employee("name", "surname", 0);

            // act
            emp.AddScore(1);
            emp.AddScore(3);
            emp.AddScore(-3);
            emp.AddScore(2);

            var stat = emp.GetStatistics();

            //assert
            Assert.AreEqual(stat.MinScore, -3);
        }

        [Test]
        public void MaxScoreTest()
        {
            // arrange
            Employee emp = new Employee("name", "surname", 0);

            // act
            emp.AddScore(1);
            emp.AddScore(3);
            emp.AddScore(-3);
            emp.AddScore(2);

            var stat = emp.GetStatistics();

            //assert
            Assert.AreEqual(stat.MaxScore, 3);
        }

        [Test]
        public void AverageScoreTest()
        {
            // arrange
            Employee emp = new Employee("name", "surname", 0);

            // act
            emp.AddScore(1);
            emp.AddScore(3);
            emp.AddScore(-3);
            emp.AddScore(2);

            var stat = emp.GetStatistics();

            //assert
            Assert.AreEqual(stat.AverageScore, 0.75);
        }

        [Test]
        public void AverageScoreForEmptyEmployeeTest()
        {
            // arrange
            Employee emp = new Employee("name", "surname", 0);

            // act
            var stat = emp.GetStatistics();

            //assert
            Assert.AreEqual(stat.AverageScore, float.MinValue);
        }
    }
}