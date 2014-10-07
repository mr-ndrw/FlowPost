using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using en.AndrewTorski.FlowPost.Persistance.Data;
using en.AndrewTorski.FlowPost.Persistance.Interfaces;

namespace en.AndrewTorski.FlowPost.Persistance.Core.Abstract
{
	/// <summary>
	///		Base for concrete adapter classes.
	/// </summary>
	/// <remarks>
	///		Reduces the amount of code needed in inherting, concrete classes.
	/// </remarks>
	/// <typeparam name="T">
	///		Business entitiy.
	/// </typeparam>
	public abstract class RepositoryBase<T> : IRepository<T> where T : class
	{

		#region Properties

		public static DbContext DataContext
		{
			get { return new FlowPostDataContext(); }
		}

		#endregion


		#region AbstractMethods

		/// <summary>
		///		
		/// </summary>
		/// <param name="entity">Entity to be found.</param>
		/// <returns>Found entity.</returns>
		protected abstract T GetSingle(T entity); 
		#endregion

		#region AbstractProperties

		/// <summary>
		///		Set containing Entities typed with current repository.
		/// </summary>
		protected abstract IQueryable<T> EntitySet { get; } 

		#endregion


		#region ImplementedMethodsIRepository

		/// <summary>
		///		Add an entity to the repository.
		/// </summary>
		/// <param name="entity">
		///		Entity to add.
		/// </param>
		/// <param name="commit">
		///		Should this insert be committed.
		/// </param>
		public void Insert(T entity, bool commit)
		{
			DataContext.Entry(entity).State = EntityState.Added;

			if(commit)
				Commit();
		}

		/// <summary>
		///		Deletes selected entity from the repository.
		/// </summary>
		/// <param name="entity">
		///		Entity to be deleted.
		/// </param>
		/// <param name="commit">
		///		Should this insert be committed.
		/// </param>
		public void Delete(T entity, bool commit)
		{
			T entityToDelete = GetSingle(entity);
			DataContext.Entry(entityToDelete).State = EntityState.Deleted;

			if(commit)
				Commit();
		}

		/// <summary>
		///		Updates selected entity in the repository.
		/// </summary>
		/// <param name="entity">
		///		Entity to be updated.
		/// </param>
		/// <param name="commit">
		///		Should this insert be committed.
		/// </param>
		public void Update(T entity, bool commit)
		{
			try
			{
				DbEntityEntry entry = DataContext.Entry(entity);
				DataContext.Entry(entity).State = EntityState.Modified;
			}
			catch (InvalidOperationException e)
			{
				T entityToUpdate = GetSingle(entity);
				if(entityToUpdate == null)
					throw new ApplicationException("Entity does not exist in the repository.");
				try
				{
					DataContext.Entry(entityToUpdate).State = EntityState.Detached;
					(EntitySet as DbSet<T>).Attach(entity);
					DataContext.Entry(entity).State = EntityState.Modified;
					if(commit)
						Commit();
				}
				catch (Exception exx)
				{
					//roll back
					DataContext.Entry(entity).State = EntityState.Detached;
					(EntitySet as DbSet<T>).Attach(entityToUpdate);
					throw;
				}
			}
		}

		/// <summary>
		///		Returns First or Default entity matching the expression.
		/// </summary>
		/// <remarks>
		///		IMPORTANT:
		///		After calling the method, check whether the returned entity is not null, as the method returns FirstOrDefault!
		/// </remarks>
		/// <param name="predicate">
		///		Criteria for searching.
		/// </param>
		/// <returns>
		///		First or Default matching Entity.
		/// </returns>
		public T GetSingle(Expression<Func<T, bool>> predicate)
		{
			return EntitySet.Where(predicate).FirstOrDefault();
		}

		/// <summary>
		///		Returns all existing entities in the respository.
		/// </summary>
		/// <returns>
		///		All existing entities.
		/// </returns>
		public IQueryable<T> GetAll()
		{
			return EntitySet;
		}

		/// <summary>
		///		Returns all entities which match the given expression/
		/// </summary>
		/// <param name="predicate">
		///		Criteria for searching/
		/// </param>
		/// <returns>
		///		All matching entities.
		/// </returns>
		public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
		{
			return EntitySet.Where(predicate);
		}

		/// <summary>
		///		Returns the total number of entities existing in the repository.
		/// </summary>
		/// <returns>
		///		Total number of entities.
		/// </returns>
		public long Count()
		{
			return EntitySet.LongCount();
		}

		/// <summary>
		///		Returns the total number of entities which match the given expression in the repository.
		/// </summary>
		/// <param name="predicate">
		///		Criteria for search.
		/// </param>
		/// <returns>
		///		Total number of entities which match the given criteria.
		/// </returns>
		public long Count(Expression<Func<T, bool>> predicate)
		{
			return EntitySet.LongCount(predicate);
		}

		/// <summary>
		///		Queries the repository for the entities which match the predicate.
		/// </summary>
		/// <param name="predicate">
		///		Criteria for search.
		/// </param>
		/// <returns>
		///		Found entities Queryable.
		/// </returns>
		public IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate)
		{
			return EntitySet;
		}

		/// <summary>
		///		Saves any changes made to the repository.
		/// </summary>
		public void Commit()
		{
			try
			{
				DataContext.SaveChanges();
			}
			catch (DbUpdateConcurrencyException ex)
			{
				var entry = ex.Entries.Single();
				entry.OriginalValues.SetValues(entry.GetDatabaseValues());
				DataContext.SaveChanges();
			}
		} 

		#endregion

	}
}