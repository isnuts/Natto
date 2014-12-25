using Natto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natto.Repository
{
	public interface IDBFactory
	{
		NattoDBEntities GetCurrentDataContext();
	}
}
