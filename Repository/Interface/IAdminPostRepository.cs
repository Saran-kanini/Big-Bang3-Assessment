using System.Collections.Generic;
using System.Threading.Tasks;
using Big_Bang3_Assessment.Model;

namespace Big_Bang3_Assessment.Repositories
{
    public interface IAdminPostRepository
    {
        Task<IEnumerable<AdminPost>> GetAllAdminPosts();
        Task<AdminPost> GetAdminPostById(int id);
        Task<AdminPost> AddAdminPost(AdminPost adminPost, IFormFile imageFile);
        Task UpdateAdminPost(int id, AdminPost adminPost);
        Task DeleteAdminPost(int id);
    }
}
