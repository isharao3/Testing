
using Employees;

namespace Test_Employees
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Get_All_Employees()
        {
            //Act
            var actuals = Emp.Emp.GetAllEmployees();

            //Assert
            Assert.That(actuals, Is.All.TypeOf<Employee>());
            Assert.That(actuals, Has.Count.GreaterThan(0));
        }
        [TestCase("Sudhanva", "IT", "4000", true)]
        public void Test_Add_New_Employee(string name, string dept, string sal, bool expected)
        {
            var before_totalEmployees = Emp.Emp.GetAllEmployees().Count;
            var actuals = Emp.Emp.AddEmployee(name,dept,sal);
            var after_totalEmployees = Emp.Emp.GetAllEmployees().Count;

            //Assert
            Assert.That(actuals, Is.EqualTo(expected));
            Assert.That(after_totalEmployees, Is.EqualTo(before_totalEmployees + 1));


        }
        //[Test]
        //public void Get_All_SDE()
        //{
        //    var actuals = Emp.Emp.GetSDE();
        //    Assert.That(actuals, Is.All.TypeOf<Employee>());
        //}
    }
}