using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDBContext _dbContext;

        public ProductRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(Product obj)
        {
            //_dbContext.Products.Update(obj);

            //Manual
            var objFromDb = _dbContext.Products.FirstOrDefault(p => p.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.ISBN = objFromDb.ISBN;
                objFromDb.ListPrice = objFromDb.ListPrice;
                objFromDb.Price = objFromDb.Price;
                objFromDb.Price100 = objFromDb.Price100;
                objFromDb.Price50 = objFromDb.Price50;
                objFromDb.Author = objFromDb.Author;
                objFromDb.CategoryId = objFromDb.CategoryId;
                objFromDb.Description = objFromDb.Description;
                objFromDb.Title = objFromDb.Title;
                if(obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
