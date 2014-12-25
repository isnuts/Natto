using Natto.Infrastructure;
using Natto.Models;
using Natto.Models.RepositoriesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natto.Repository.Repositories
{
	public class ProductRepository : BaseRepository<Product>, IProductRepository
	{
		public ProductRepository(IDBFactory)
			: base(unit)
		{ 
		}
	}
}
