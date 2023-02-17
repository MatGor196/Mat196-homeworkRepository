namespace BasicApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void RefferenceTestForInt()
        {
            // arrange
            int number1 = 3; int number2 = 3;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void RefferenceTestForFloat()
        {
            // arrange
            float number1 = 3; float number2 = 3;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void RefferenceTestForString()
        {
            // arrange
            string str1 = "abc"; string str2 = "abc";

            // act

            // assert
            Assert.AreEqual(str1, str2);
        }

        [Test]
        public void RefferenceTestForEmployee()
        {
            // arrange
            EmployeeInMemory emp1 = new Employee("Jan", "Kowalski", 35);
            EmployeeInMemory emp2 = new Employee("Jan", "Kowalski", 35);

            // act

            // assert
            Assert.AreNotEqual(emp1, emp2);
        }
    }
}
