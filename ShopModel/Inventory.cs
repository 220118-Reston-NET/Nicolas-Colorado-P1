namespace ShopModel
{
    public class Inventory
    {
        public int storeID  { get; set; }

        public int productID { get; set; }

        private int _quantity; 
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                //Cannot have quantity of products in inventory drop below zero (0).
                if (value >= 0)
                {
                    _quantity = value;
                }
                else
                {
                    throw new Exception("Your item quantity cannot be less than zero! Please purchase less of the product.");
                }
            }
        }

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