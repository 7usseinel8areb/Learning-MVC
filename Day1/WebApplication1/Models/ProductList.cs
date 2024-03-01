namespace Day1.Models
{
    public class ProductList
    {
        public static List<Product> Products { get; set; }
        static ProductList()
        {
            Products = new List<Product>();
            Products.Add(new Product() { ID = 1 , Name = "Phone1" , Price = 30000 ,Image = "1.png"});
            Products.Add(new Product() { ID = 2 , Name = "Phone2" , Price = 27654 ,Image = "2.png"});
            Products.Add(new Product() { ID = 3 , Name = "Phone3" , Price = 22221 ,Image = "3.png"});
        }
    }
}
