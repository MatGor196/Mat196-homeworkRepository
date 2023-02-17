namespace BasicApp.Tests
{
    public class Tests
    {
        [Test]
        public void AddScoreSumScoreTest()
        {
            // arrange
            EmployeeInMemory emp = new EmployeeInMemory();
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
            EmployeeInMemory emp = new EmployeeInMemory();

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
            EmployeeInMemory emp = new EmployeeInMemory();

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
            EmployeeInMemory emp = new EmployeeInMemory();

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
            EmployeeInMemory emp = new EmployeeInMemory();

            // act
            var stat = emp.GetStatistics();

            //assert
            Assert.AreEqual(stat.AverageScore, 0);
        }

        [Test]
        public void AverageScoreLetterTest()
        {
            // arrange
            EmployeeInMemory emp1 = new EmployeeInMemory();
            emp1.AddScore("A");
            emp1.AddScore("c");
            emp1.AddScore("a");
            emp1.AddScore("C");

            EmployeeInMemory emp2 = new EmployeeInMemory();
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