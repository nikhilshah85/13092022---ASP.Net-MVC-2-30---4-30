namespace MVC_communication.Models
{
    public class ProductsModel
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public double pPrice { get; set; }

        public string pCategory { get; set; }
        public bool pIsInStock { get; set; }

        static List<ProductsModel> ProductList = new List<ProductsModel>()
        {
            new ProductsModel(){ pId=101,pName="MacBook Pro", pCategory="Laptop", pIsInStock=true, pPrice=179000},
            new ProductsModel(){ pId=102,pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductsModel(){ pId=103,pName="Coke", pCategory="Cold-Drink", pIsInStock=false, pPrice=80},
            new ProductsModel(){ pId=104,pName="Iphone", pCategory="Electronics", pIsInStock=true, pPrice=125000},
            new ProductsModel(){ pId=105,pName="Trailhawk", pCategory="SUV", pIsInStock=false, pPrice=3800000},
        };

        public List<ProductsModel> ShowProducts()
        {
            return ProductList;
        }

        public ProductsModel GetProductbyId(int id)
        {
            var p = ProductList.Find(p => p.pId == id);

            if (p != null)
            {
                return p;
            }
            throw new Exception("Product not found");
        }
    }
}





