using AutoMapper;
using Data.Context;
using Data.Context.Models;
using Data.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Data.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly IMapper Mapper;
		private readonly AppIdentityDbContext Context;
		public CategoryService(AppIdentityDbContext context, IMapper mapper)
		{
			Context = context;
			Mapper = mapper;
		}
		public async Task<bool> AddCategory(CategoryViewModel category)
		{
			try
			{
				var categorydb = Mapper.Map<CategoryViewModel, Category>(category);
				Context.Add(categorydb);
				await Context.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<bool> EditCategory(CategoryViewModel category)
		{
			try
			{
				var categorydb = Mapper.Map<Category>(category);
				Context.Update(categorydb);
				await Context.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<List<CategoryViewModel>> GetCategories()
		{
			var categories = Mapper.Map<List<CategoryViewModel>>(await Context.Categories.ToListAsync());
			return categories;
		}

		public async Task<CategoryViewModel> GetCategoryById(int id)
		{
			try
			{
				var categoryDb = await Context.Categories.Where(w => w.Id == id).FirstOrDefaultAsync();
				var category = Mapper.Map<CategoryViewModel>(categoryDb);
				return category;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public Task<List<CategoryViewModel>> GetPaginatedCategory(int page, int quantity)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> RemoveCategory(int id)
		{
			try
			{
				var category = Context.Categories.FirstOrDefault(w => w.Id == id);
				Context.Remove(category);
				await Context.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
