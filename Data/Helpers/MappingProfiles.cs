using AutoMapper;
using Data.Context.Models;
using Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Helpers
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles() {
			CreateMap<Category, CategoryViewModel>();
			CreateMap<CategoryViewModel, Category>();
		}
	}
}
