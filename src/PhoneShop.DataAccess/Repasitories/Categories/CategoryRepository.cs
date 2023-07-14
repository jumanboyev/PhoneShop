
using Dapper;
using PhoneShop.DataAccess.Interfaces;
using PhoneShop.DataAccess.Interfaces.Categories;
using PhoneShop.DataAccess.Utils;
using PhoneShop.Domain.Entities.Category;
using System.Data.Common;
using static Dapper.SqlMapper;

namespace PhoneShop.DataAccess.Repasitories.Categories;

public class CategoryRepository : BaseRepository, ICategoryRepository
{
    public Task<long> CountAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<int> CreateAsync(Category entity)
    {
        try
        {
            await _connection.OpenAsync();
            string query = "INSERT INTO public.category(name, image_path, description, create_at, update_at)" +
                "VALUES (@Name, @Imagepath, @Description, @CreateAt, @UpdateAt);";
            var result=await _connection.ExecuteAsync(query,entity); 
            return result;
        }
        catch 
        {
            return 0;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"Delete from category id=@Id";
            var result = await _connection.ExecuteAsync(query,new {Id=id });
            return result;
        }
        catch
        {
            return 0;
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<IList<Category>> GetAllAsync(PaginationParams @params)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"Select * from category order by id desc offset {@params.SkipCount} limit {@params.Pagesize}";
            var result = (await _connection.QueryAsync<Category>(query)).ToList();
            return result;
        }
        catch
        {
            return new List<Category>(); 
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async Task<Category> GetByIdAsync(int id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"SELECT * FROM category where id={id}";
            var result = await _connection.QuerySingleAsync<Category>(query);
            return result;
        }
        catch
        {
            return new Category();
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public Task<int> UpdateAsync(int id, Category entity)
    {
        throw new NotImplementedException();
    }

    /*Task IRepository<Category, Category>.DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }*/
}
