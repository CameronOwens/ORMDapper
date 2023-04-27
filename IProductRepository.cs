using System;


namespace ORM_Dapper1
{
	public interface IProductRepository
	{
        IEnumerable<Product> GetAllProducts();

        void CreateProduct(string name, double price, int categoryID);

    }
}

