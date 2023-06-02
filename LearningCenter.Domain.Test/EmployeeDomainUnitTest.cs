using Domain;
using LearningCenter.infraestructura;
using LearningCenter.infraestructura.Models;
using Moq;
using Xunit;

namespace LearningCenter.Domain.Test
{
    public class EmployeeDomainUnitTest
    {
        [Fact]
        public void save_ValidObject_ReturnTrue()
        {
            //Arrange
            Employee employee = new Employee()
            {
                Name = "employee"
            };

            //Mock
            var _employeeInfraestructure = new Mock<IEmployeeInfraestructure>();
            _employeeInfraestructure.Setup(t => t.save(employee)).Returns(true);
            EmployeeDomain employeeDomain = new EmployeeDomain(_employeeInfraestructure.Object);


            //Act
            var result = employeeDomain.save(employee);


            //Test
            Assert.True(result);

        }

        [Fact]
        public void save_InvalidObject_returnException()
        {
            Employee employee = new Employee()
            {
                Name = "An"
            };

            var _employeeInfraestructure = new Mock<IEmployeeInfraestructure>();
            _employeeInfraestructure.Setup(t => t.save(employee)).Returns(true);
            EmployeeDomain employeeDomain = new EmployeeDomain(_employeeInfraestructure.Object);

            var ex = Assert.Throws<Exception>(() => employeeDomain.save(employee));

            Assert.Equal("The length of your name is invalid(>3)", ex.Message);
        }

        [Fact]
        public void save_InvalidObject_ReturnExceptionMax()
        {
            //Arrange
            Employee employee = new Employee()
            {
                Name = "Employee is very very largest"
            };

            //Mock
            var tutotialInfraestructure = new Mock<IEmployeeInfraestructure>();
            tutotialInfraestructure.Setup(t => t.save(employee)).Returns(true);

            EmployeeDomain tutorialDomain = new EmployeeDomain(tutotialInfraestructure.Object);

            //Act
            var ex = Assert.Throws<Exception>(() => tutorialDomain.save(employee));

            //Assert
            Assert.Equal("the name is more than 20", ex.Message);
        }

    }
}
