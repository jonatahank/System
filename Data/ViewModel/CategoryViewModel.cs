using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ViewModel
{
	public class CategoryViewModel
	{
		public int Id { get; set; }
		[Required]
		[StringLength(50, MinimumLength = 3)]
		public string Name { get; set; }
		[StringLength(256)]
		public string Description { get; set; }
	}
}
