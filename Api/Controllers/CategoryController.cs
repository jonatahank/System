using Data.Services;
using Data.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService CategoryService;
		public CategoryController(ICategoryService categoryService)
		{
			CategoryService = categoryService;
		}

		[HttpGet]
		public async Task<ActionResult<CategoryViewModel>> GetCategoryById(int id)
		{
			return Ok(await CategoryService.GetCategoryById(id));
		}

		[HttpGet]
		public async Task<ActionResult<List<CategoryViewModel>>> GetCategories()
		{
			return Ok(await CategoryService.GetCategories());
		}

		[HttpPost]
		public async Task<ActionResult<CategoryViewModel>> AddCategory([FromBody] CategoryViewModel category)
		{
			return Ok(await CategoryService.AddCategory(category));
		}

		[HttpPost]
		public async Task<ActionResult<bool>> RemoveCategory([FromBody] int id)
		{
			return Ok(await CategoryService.RemoveCategory(id));
		}

		[HttpPost]
		public async Task<ActionResult<bool>> UpdateCategory([FromBody] CategoryViewModel category)
		{
			return Ok(await CategoryService.EditCategory(category));
		}
	}
}