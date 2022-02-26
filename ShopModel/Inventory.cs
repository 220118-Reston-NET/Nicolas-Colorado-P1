namespace ShopModel
{
    public class Inventory
    {
        public int storeID  { get; set; }

        public int productID { get; set; }

        public int Quantity { get; set; }

        public Inventory()
        {
            storeID = 0; 
            productID = 0;
            Quantity = 0;
        }

        public override string ToString()
        {
            return $"StoreID: {storeID}\nProductID: {productID}\nQTY: {Quantity}";
        }
    }
}