using Business.Concrete;
using DataAccess.Conctere.EntityFramework;
using DataAccess.Conctere.InMemory;

//CategoryTest();

ProductTest();



static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}
static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    }
}

