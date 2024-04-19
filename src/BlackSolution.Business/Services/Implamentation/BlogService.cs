using BlackSolution.Business.Services.Interface;
using BlackSolution.Core.Entities;
using BlackSolution.Data.Data;

namespace BlackSolution.Business.Services.Implamentation;

public class BlogService : IBlogService
{
    public BlogService(AppDbContext)
    {
        
    }
    public Task CreateAsync(Blog blog)
    {
        throw new NotImplementedException();
    }

    public void DeleteAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Blog>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Blog> GetAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Blog blog)
    {
        throw new NotImplementedException();
    }
}
