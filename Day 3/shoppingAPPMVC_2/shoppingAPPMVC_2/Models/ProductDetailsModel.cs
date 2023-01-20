namespace shoppingAPPMVC_2.Models
{
    public class ProductDetailsModel
    {
        #region Properties
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }
        #endregion


        static List<ProductDetailsModel> pList = new List<ProductDetailsModel>()
        {
            new ProductDetailsModel(){ pId=101, pName="Iphone", pCategory="Electronics", pPrice=140000, pIsInStock=true },
            new ProductDetailsModel(){ pId=102, pName="Dell lattitude", pCategory="Electronics", pPrice=140000, pIsInStock=true },
            new ProductDetailsModel(){ pId=103, pName="Pepsi", pCategory="Cold-Drink", pPrice=140000, pIsInStock=false },
            new ProductDetailsModel(){ pId=104, pName="Nike", pCategory="Shoes", pPrice=140000, pIsInStock=true },
            new ProductDetailsModel(){ pId=105, pName="Puma", pCategory="Shoes", pPrice=140000, pIsInStock=true },
            new ProductDetailsModel(){ pId=106, pName="Air pods", pCategory="Electronics", pPrice=140000, pIsInStock=true },
            new ProductDetailsModel(){ pId=107, pName="Fossil Q", pCategory="Electronics", pPrice=140000, pIsInStock=false },
            new ProductDetailsModel(){ pId=108, pName="Appy Fizz", pCategory="Cold-Drink", pPrice=140000, pIsInStock=true },
            new ProductDetailsModel(){ pId=109, pName="Maggie", pCategory="Junk-Food", pPrice=140000, pIsInStock=false },
        };

        public List<ProductDetailsModel> GetAllProducts()
        { 
            return pList;
        }


    }
}
