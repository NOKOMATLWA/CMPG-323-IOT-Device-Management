using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace DeviceManagement_WebApp.Repository
{ 
    public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository

    {
        public CategoriesRepository(ConnectedOfficeContext context) :base (context)
        {
        }

        public Service GetMostRecentCategory()
        {
            return _context.Category.OrderByDescending(Category => Category.CreatedDate).FirstOrDefault();
        }
}   }

    

