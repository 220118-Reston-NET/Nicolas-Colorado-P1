using ShopModel;
using Xunit;

namespace ShopTest
{
    public class InventoryModelTest
    {
        /// <summary>
        /// Checks the validation for a product's quantity in inventory.
        /// Below is a unit test
        /// </summary>
        [Fact]
        public void InventoryQuantityShouldValidData()
        {
            //Arrange
            Inventory item = new Inventory();
            int validQuantity = 3;

            //Act
            item.Quantity = validQuantity;

            //Assert
            Assert.NotNull(item.Quantity);
            Assert.Equal(validQuantity, item.Quantity);
        }
    }
}