using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWCF.DAL
{
	class HelperContext<TEntity> : TestWCFContext
	{
		public virtual DbSet<TEntity> Entities { get; set; }


	}
}
