using Resources.Models;

namespace Resources.Services;

public class ProductService
{
    private List<Product> productList = new List<Product>();

    public void AddProduct(Product product)
    {
        productList.Add(product);
    }

    public void RemoveProduct(int productId)
    {
        var product = productList.Find(p => p.Id == productId);
        if (product != null)
        {
            productList.Remove(product);
        }
    }

    public List<Product> GetAllProducts()
    {
        return productList;
    }
}
