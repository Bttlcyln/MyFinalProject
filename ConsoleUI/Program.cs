using Business.Concrete;
using DataAccess.Conctere.EntityFramework;
using DataAccess.Conctere.InMemory;

//CategoryTest();

ProductTest();



static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}
static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

    var result = productManager.GetProductDetails();

    if (result.Success== true)
    {
        foreach (var product in productManager.GetProductDetails().Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
    else 
    {
        Console.WriteLine(result.Message);
    }
    
}

