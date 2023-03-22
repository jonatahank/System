using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
	public interface ICategoryService
	{
		Task<CategoryViewModel> GetCategoryById(int id);
		Task<List<CategoryViewModel>> GetCategories();
		Task<List<CategoryViewModel>> GetPaginatedCategory(int page,int quantity);
		Task<bool> AddCategory(CategoryViewModel category);
		Task<bool> EditCategory(CategoryViewModel category);
		Task<bool> RemoveCategory(int id);
	}
}
