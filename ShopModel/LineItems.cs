namespace ShopModel
{
    public class LineItem
    {
        public Guid orderID { get; set; }

        public int productID { get; set; }
        
        public string ProductName { get; set; }

        public double ProductPrice { get; set; }

        public int Quantity { get; set; }

        public LineItem()
        {
            orderID = Guid.NewGuid();
            productID = 0;
            ProductName = "";
            ProductPrice = 0.00;
            Quantity = 0;
        }


        public override string ToString()
        {
            return $"Product Name: {ProductName}\nProduct Price: {ProductPrice}\nQTY: {Quantity}";
        }
    }
}