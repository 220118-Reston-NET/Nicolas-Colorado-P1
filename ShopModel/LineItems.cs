namespace ShopModel
{
    public class LineItem
    {
        public int orderID { get; set; }

        public int productID { get; set; }
        
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public LineItem()
        {
            orderID = 0;
            productID = 0;
            ProductName = "";
            Quantity = 0;
        }


        public override string ToString()
        {
            return $"Product Name: {ProductName}\nQTY: {Quantity}";
        }
    }
}