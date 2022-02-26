namespace ShopModel
{
    public class Orders
    {
        public int orderID { get; set; }

        public int customerID { get; set; }

        public int storeID { get; set; }

        public DateTime DateofOrder { get; set; }

        private List<LineItem> _lineItem;

        public List<LineItem> LineItem
        {
            get { return _lineItem; }
            set
            {
                _lineItem = value;
            }
        }

        public double TotalPrice { get; set; }

        public Orders()
        {
            orderID = 0;
            customerID = 0;
            storeID = 0;
            _lineItem = new List<LineItem>()
            {
                new LineItem()
            };
            TotalPrice = 0.00;
        }

        public override string ToString()
        {
            return $"OrderID: {orderID}\nCustomerID: {customerID}\nStoreID: {storeID}\nDate of Order: {DateofOrder}\nTotal Price: {TotalPrice}";
        }
    }
}