using ShopModel;
using Xunit;

namespace ShopTest
{
    public class OrdersModelTest
    {
        /// <summary>
        /// Checks the validation for a order's total price.
        /// Below is a unit test
        /// </summary>
        [Fact]
        public void TotalPriceShouldSetValidData()
        {
            //Arrange
            Orders order = new Orders();
            double validTotalPrice = 321.09;

            //Act
            order.TotalPrice = validTotalPrice;

            //Assert
            Assert.NotNull(order.TotalPrice);
            Assert.Equal(validTotalPrice, order.TotalPrice);
        }
    }
}