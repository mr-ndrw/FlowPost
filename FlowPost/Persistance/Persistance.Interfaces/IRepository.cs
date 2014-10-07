using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace en.AndrewTorski.FlowPost.Persistance.Interfaces
{
	/// <summary>
	///		Generic interface which defines the standard behaviours for all Repositories.
	/// </summary>
	/// <typeparam name="T">
	///		Business entity.
	/// </typeparam>
	public interface IRepository<T>
	{
		/// <summary>
		///		Add an entity to the repository.
		/// </summary>
		/// <param name="entity">
		///		Entity to add.
		/// </param>
		/// <param name="commit">
		///		
		/// </param>
		void Insert(T entity, bool commit);
		
		/// <summary>
		///		Deletes selected entity from the repository.
		/// </summary>
		/// <param name="entity">
		///		Entity to be deleted.
		/// </param>
		void Delete(T entity, bool commit);
		
		/// <summary>
		///		Updates selected entity in the repository.
		/// </summary>
		/// <param name="entity">
		///		Entity to be updated.
		/// </param>
		void Update(T entity, bool commit);

		/// <summary>
		///		Returns First or Default entity matching the expression.
		/// </summary>
		/// <param name="predicate">
		///		Criteria for searching.
		/// </param>
		/// <returns>
		///		First or Default matching Entity.
		/// </returns>
		T GetSingle(Expression<Func<T, bool>> predicate);

		/// <summary>
		///		Returns all existing entities in the respository.
		/// </summary>
		/// <returns>
		///		All existing entities.
		/// </returns>
		IQueryable<T> GetAll();

		/// <summary>
		///		Returns all entities which match the given expression/
		/// </summary>
		/// <param name="predicate">
		///		Criteria for searching/
		/// </param>
		/// <returns>
		///		All matching entities.
		/// </returns>
		IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);

		/// <summary>
		///		Returns the total number of entities existing in the repository.
		/// </summary>
		/// <returns>
		///		Total number of entities.
		/// </returns>
		long Count();

		/// <summary>
		///		Returns the total number of entities which match the given expression in the repository.
		/// </summary>
		/// <param name="predicate">
		///		Criteria for search.
		/// </param>
		/// <returns>
		///		Total number of entities which match the given criteria.
		/// </returns>
		long Count(Expression<Func<T, bool>> predicate);

		/// <summary>
		///		Queries the repository for the entities which match the predicate.
		/// </summary>
		/// <param name="predicate">
		///		Criteria for search.
		/// </param>
		/// <returns>
		///		Found entities Queryable.
		/// </returns>
		IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate);

		/// <summary>
		///		Saves any changes made to the repository.
		/// </summary>
		void Commit();
	}
}
