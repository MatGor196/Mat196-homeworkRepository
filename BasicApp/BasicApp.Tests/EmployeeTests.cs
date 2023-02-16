namespace BasicApp.Tests
{
    public class Tests
    {
        [Test]
        public void AddScoreSumScoreTest()
        {
            // arrange
            Employee emp = new Employee();
            var result = 0;

            // act
            emp.AddScore(15);
            emp.AddScore(40);
            emp.AddScore(65);
            result = emp.SumScore();

            // assert
            Assert.AreEqual(120, result);
        }

        [Test]
        public void MinScoreTest()
        {
            // arrange
            Employee emp = new Employee();

            // act
            emp.AddScore(15);
            emp.AddScore(40);
            emp.AddScore(65);

            var stat = emp.GetStatistics();

            //assert
            Assert.AreEqual(stat.MinScore, 15);
        }

        [Test]
        public void MaxScoreTest()
        {
            // arrange
            Employee emp = new Employee();

            // act
            emp.AddScore(15);
            emp.AddScore(40);
            emp.AddScore(65);

            var stat = emp.GetStatistics();

            //assert
            Assert.AreEqual(stat.MaxScore, 65);
        }

        [Test]
        public void AverageScoreTest()
        {
            // arrange
            Employee emp = new Employee();

            // act
            emp.AddScore(15);
            emp.AddScore(40);
            emp.AddScore(65);

            var stat = emp.GetStatistics();

            //assert
            Assert.AreEqual(stat.AverageScore, 40);
        }

        [Test]
        public void AverageScoreForEmptyEmployeeTest()
        {
            // arrange
            Employee emp = new Employee();

            // act
            var stat = emp.GetStatistics();

            //assert
            Assert.AreEqual(stat.AverageScore, 0);
        }

        [Test]
        public void AverageScoreLetterTest()
        {
            // arrange
            Employee emp1 = new Employee();
            emp1.AddScore("A");
            emp1.AddScore("c");
            emp1.AddScore("a");
            emp1.AddScore("C");

            Employee emp2 = new Employee();
            emp2.AddScore("a");
            emp2.AddScore("b");
            emp2.AddScore("C");
            emp2.AddScore("D");

            // act
            var stat1 = emp1.GetStatistics();
            var stat2 = emp2.GetStatistics();

            //assert
            Assert.AreEqual(stat1.AverageScoreLetter, 'B');
            Assert.AreEqual(stat2.AverageScoreLetter, 'B');
        }
    }
}