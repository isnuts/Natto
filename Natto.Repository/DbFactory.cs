using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natto.Repository
{
	public class DbFactory : Disposable, IDBFactory
	{
		public LtsDbFactory()
		{
			_storage = DataContextStorageFactory.GetDataContextStorage();
		}

		private BombayDataContext _dataContext;
		private readonly IDataContextStorage _storage;

		public BombayDataContext GetCurrentDataContext()
		{
			_dataContext = _storage.Retrieve();
			if (_dataContext == null)
			{
				_dataContext = new BombayDataContext();

#if DEBUG
				_dataContext.Log = new OutputWriter();
#endif

				_storage.Store(_dataContext);
			}

			return _dataContext;
		}

		protected override void DisposeCore()
		{
			if (_dataContext != null)
			{
				_dataContext.Dispose();
				_dataContext = null;
			}
			_storage.Store(_dataContext);
		}
	}
}
