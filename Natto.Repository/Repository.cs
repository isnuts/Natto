using Natto.Infrastructure;
using Natto.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natto.Repository
{
	
	public abstract class Repository<TEntity, TId> : IRepository<TEntity, TId>
	   where TEntity : class
	{
		public Repository(IDBFactory dbFactory)
		{
			_dbFactory = dbFactory;
		}

		private readonly IDBFactory _dbFactory;

		protected NattoDBEntities DataContext
		{
			get { return _dbFactory.GetCurrentDataContext(); }
		}

		protected IQueryable<TEntity> Query
		{
			get { return ; }
		}

		public void Create(TEntity entity)
		{
			DataContext.GetTable<TEntity>().InsertOnSubmit(entity);
		}

		public void Modify(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(TEntity entity)
		{
			DataContext.GetTable<TEntity>().DeleteOnSubmit(entity);
		}

		public void DeleteAttach(TEntity entity)
		{
			DataContext.GetTable<TEntity>().Attach(entity);
			DataContext.GetTable<TEntity>().DeleteOnSubmit(entity);
		}

		public abstract TEntity FindById(TId id);

		public IEnumerable<TEntity> FindAll()
		{

			return Query.ToList();
		}
	}
}
