using System.Collections.Generic;
using Moq;
using ShopBL;
using ShopDL;
using ShopModel;
using Xunit;



namespace ShopTest
{
    public class ManagerBLTest
    {
        [Fact]
        public void ShouldGetAllManager()
        {

            //Arrange
            int p_managerID = 0;
            string p_password = "Testpassword";
            Manager manager = new Manager()
            {
                managerID = p_managerID,
                password = p_password
            };

            List<Manager> expectedListOfManager = new List<Manager>();
            expectedListOfManager.Add(manager);

            Mock<IRepository> mockRepo = new Mock<IRepository>();


            mockRepo.Setup(repo => repo.GetManager(p_managerID, p_password)).Returns(expectedListOfManager);

            IStoreFrontBL _storeBL = new StoreFrontBL(mockRepo.Object);  

            //Act
            List<Manager> actualListOfManager = _storeBL.GetManager(p_managerID, p_password);

            //Assert
            Assert.Same(expectedListOfManager, actualListOfManager); 
            Assert.Equal(p_managerID, actualListOfManager[0].managerID); 
            Assert.Equal(p_password, actualListOfManager[0].password);
            
        }
    }
}

