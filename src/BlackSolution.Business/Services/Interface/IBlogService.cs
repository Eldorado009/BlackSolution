using BlackSolution.Core.Entities;

namespace BlackSolution.Business.Services.Interface;

public interface IBlogService
{
    Task<Blog> GetAsync(int Id);
    Task<List<Blog>> GetAllAsync(Blog blog);
    Task Create();
    Task Update();
    void Delete();
}
