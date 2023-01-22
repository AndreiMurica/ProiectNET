using Proiect.Models.Base;

namespace Proiect.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        //get
        Task<List<TEntity>> GetAllAsync();

        //create
        Task CreateAsync(TEntity entity);

        //update
        void Update(TEntity entity);

        //delete
        void Delete(TEntity entity);
        void DeleteAll();

        //find
        Task<TEntity> FindByIdAsync(object id);
        TEntity FindById(object id);

        //save
        Task<bool> SaveAsync();
        bool Save();
    }
}
