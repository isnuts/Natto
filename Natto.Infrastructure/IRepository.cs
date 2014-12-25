using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natto.Infrastructure
{
	public interface IRepository<TEntity, TId>
	{
		void Create(TEntity entity);
		void Modify(TEntity entity);
		void Delete(TEntity entity);
		void DeleteAttach(TEntity entity);
		TEntity FindById(TId id);
		IEnumerable<TEntity> FindAll();
	}
}
