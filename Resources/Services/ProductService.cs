using Resources.Models;

namespace Resources.Services;

public class ProductService
{
    private List<Products> productList = new List<Products>();

    public void AddProduct(Products product)
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

    public List<Products> GetAllProducts()
    {
        return productList;
    }
}
