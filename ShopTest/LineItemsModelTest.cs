using ShopModel;
using Xunit;

namespace ShopTest
{
    public class LineItemsModelTest
    {
        /// <summary>
        /// Checks the validation for the price of a product in the line items.
        /// Below is a unit test
        /// </summary>
        [Fact]
        public void LineItemPriceShouldValidData()
        {
            //Arrange
            LineItem lineItem = new LineItem();
            double validProductPrice = 1.99;

            //Act
            lineItem.ProductPrice = validProductPrice;

            //Assert
            Assert.NotNull(lineItem.ProductPrice);
            Assert.Equal(validProductPrice, lineItem.ProductPrice);
        }

        /// <summary>
        /// Checks the validation for a line item's quantity.
        /// Below is a unit test
        /// </summary>
        [Fact]
        public void LineItemQTYShouldValidData()
        {
            //Arrange
            LineItem item = new LineItem();
            int validQTY = 3;

            //Act
            item.Quantity = validQTY;

            //Assert
            Assert.NotNull(item.Quantity);
            Assert.Equal(validQTY, item.Quantity);
        }
    }
}