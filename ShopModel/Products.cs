namespace ShopModel
{
    public class Product
    {
        public int productID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }

        public int Quantity { get; set; }


        // public Product()
        // {
        //     productID = 0;
        //     Name = "";
        //     Price = 0;
        //     Category = "";
        //     Quantity = 0;
        // }

        public override string ToString()
        {
            return $"ID: {productID}\nName: {Name}\nPrice: ${Price}\nCategory: {Category}\nQuantity: {Quantity}";
        }
    }  
}