using Natto.Infrastructure;
using Natto.Models.RepositoriesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natto.Services.Implementations
{
	public interface IProductService
	{
		void GetProductAll();
	}
	public class ProductService : IProductService
	{
		private readonly IProductRepository _productRepository;
		private readonly IUnitOfWork _uow;

		public ProductService(IProductRepository productRepository, IUnitOfWork uow)
		{
			_productRepository = productRepository;
			_uow = uow;
		}

		public void GetProductAll()
		{
			var products = _productRepository.GetAll();
		}

	}
}
