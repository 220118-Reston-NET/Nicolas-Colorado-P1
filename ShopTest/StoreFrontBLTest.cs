using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using ShopBL;
using ShopDL;
using ShopModel;
using Xunit;

namespace ShopTest
{
    public class StoreFrontBLTest
    {
        [Fact]
        public async Task ShouldGetAllStoreAsync()
        {
            // Arrange
            int ID = 1;
            string sfName = "Colorado's Market";
            string sfAddress = "415 Las Vegas Boulevard, Las Vegas, NV";
            string sfPhone = "7298303837";

            StoreFront store = new StoreFront()
            {
                storeID = ID,
                Name = sfName,
                Address = sfAddress,
                Phone = sfPhone
            };

            List<StoreFront> expectedListOfStoreFront = new List<StoreFront>();
            expectedListOfStoreFront.Add(store);

            Mock<IRepository> mockRepo = new Mock<IRepository>();

            mockRepo.Setup(repo => repo.GetAllStoreFrontAsync()).ReturnsAsync(expectedListOfStoreFront);

            IStoreFrontBL storeBL = new StoreFrontBL(mockRepo.Object);

            //Act
            List<StoreFront> actualListOfStoreFront = await storeBL.GetAllStoreFrontAsync();

            // Assert
             Assert.Same(expectedListOfStoreFront, actualListOfStoreFront);
             Assert.Equal(ID, actualListOfStoreFront[0].storeID);
             Assert.Equal(sfName, actualListOfStoreFront[0].Name);
             Assert.Equal(sfAddress, actualListOfStoreFront[0].Address);
             Assert.Equal(sfPhone, actualListOfStoreFront[0].Phone);
        }

        [Fact]
        public void ShouldGetOrderbyStoreID()
        {
            //Arrange
            int p_storeID = 4;
            Orders order = new Orders()
            {
              storeID = p_storeID
            };

            List<Orders> expectedListOfOrders = new List<Orders>();
            expectedListOfOrders.Add(order);

            
            Mock<IRepository> mockRepo = new Mock<IRepository>();

            mockRepo.Setup(repo => repo.GetOrderbyStoreID(p_storeID)).Returns(expectedListOfOrders);
        
            IStoreFrontBL _storeBL = new StoreFrontBL(mockRepo.Object); 
            
            //Act
            List<Orders> actualListOfOrders = _storeBL.GetOrderbyStoreID(p_storeID);
            
            //Assert
            Assert.Same(expectedListOfOrders, actualListOfOrders); 
            Assert.Equal(p_storeID, actualListOfOrders[0].storeID);
        }
    }
}