using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWCF.DAL
{
	
	public abstract class AbstratManager<TEntity> where TEntity:class
	{
		private DbSet<TEntity> EntityClass;
		private DbContext db;

		public AbstratManager(DbSet<TEntity> EntityClass)
		{
			this.EntityClass = EntityClass;
			db = new TestWCFContext();
		}
		public TEntity Add(TEntity entity)
		{
			EntityClass.Add(entity);
			db.SaveChanges();
			return entity;
		}
	}
}
