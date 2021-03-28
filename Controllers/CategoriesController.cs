using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Supermarket.API.Domain.Services;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Controllers
{

    [Route("/api/[Controller]")]
    public class CategoriesController : Controller 
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IEnumerable<Category>> GetAllAsync(){
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}