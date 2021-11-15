namespace Sld123.Entities
{
    class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;

        }

        public double SubTotal()
        {
            return Product.Price * Quantity;
        }

    }
}
