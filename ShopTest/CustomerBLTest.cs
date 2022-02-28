using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using ShopBL;
using ShopDL;
using ShopModel;
using Xunit;

namespace ShopTest
{
    public class CustomerBLTest
    {
        [Fact]
        public async Task ShouldGetAllCustomerAsync()
        {
            // Arrange
            int ID = 1;
            string custName = "John Doe";
            string custAddress = "421 Dough Street, Orlando, FL";
            string custEmail = "j.doe@outlook.com";
            string custPhone = "5012950099";

            Customer customer = new Customer()
            {
                customerID = ID,
                Name = custName,
                Address = custAddress,
                Email = custEmail,
                Phone = custPhone
            };

            List<Customer> expectedListOfCustomer = new List<Customer>();
            expectedListOfCustomer.Add(customer);

            //We are mocking one of the required dependencies of CustomerBL which is IRepository
            Mock<IRepository> mockRepo = new Mock<IRepository>();

            //If our IRepository.GetAllCustomer() is called, it will always return our expectedListOfCustomer
            //In this way, we guaranteed that our dependency will always work so if something goes wrong it is the business layer's fault
            mockRepo.Setup(repo => repo.GetAllCustomerAsync()).ReturnsAsync(expectedListOfCustomer);

            //We passed in the mock version of IRepository
            ICustomerBL customerBL = new CustomerBL(mockRepo.Object);
        
            // Act
            List<Customer> actualListOfCustomer = await customerBL.GetAllCustomerAsync();

        
            // Assert
             Assert.Same(expectedListOfCustomer, actualListOfCustomer);
             Assert.Equal(ID, actualListOfCustomer[0].customerID);
             Assert.Equal(custName, actualListOfCustomer[0].Name);
             Assert.Equal(custAddress, actualListOfCustomer[0].Address);
             Assert.Equal(custEmail, actualListOfCustomer[0].Email);
             Assert.Equal(custPhone, actualListOfCustomer[0].Phone);
        }


        [Fact]
        public void ShouldAddCustomer()
        {
            //Arrange
            Customer _customer = new Customer() 
            {
                Name = "Joey Wheeler",
                Address = "969 Shadow Realm Street, Brooklyn, Japan",
                Email = "joey.wheel@kaiba.com",
                Phone = "1111111111"
            };

            Mock<IRepository> mockRepo = new Mock<IRepository>();

            mockRepo.Setup(repo => repo.AddCustomer(_customer)).Returns(_customer);
            
            ICustomerBL customer = new CustomerBL(mockRepo.Object);

            //Act
            Customer actualCustomer = customer.AddCustomer(_customer);

            //Assert
            Assert.Same(_customer, actualCustomer);
            Assert.NotNull(actualCustomer);
        }

        [Fact]
        public void ShouldUpdateCustomer()
        {
            //Arrange
            Customer _customer = new Customer() 
            {
                Name = "Seto Kaiba",
                Address = "222 Kaiba Corp Boulevard, Brooklyn, Japan",
                Email = "blue.dragon3@kaiba.com",
                Phone = "2222222222"
            };

            Mock<IRepository> mockRepo = new Mock<IRepository>();

            mockRepo.Setup(repo => repo.UpdateCustomer(_customer)).Returns(_customer);

            ICustomerBL customer = new CustomerBL(mockRepo.Object);

            //Act
            Customer actualCustomer = customer.UpdateCustomer(_customer);

            //Assert
            Assert.Same(_customer, actualCustomer);
            Assert.NotNull(actualCustomer);
        }
    }
}