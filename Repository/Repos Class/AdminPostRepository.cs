using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Big_Bang3_Assessment.Data;
using Big_Bang3_Assessment.Model;
using System.Numerics;

namespace Big_Bang3_Assessment.Repositories
{
    public class AdminPostRepository : IAdminPostRepository
    {
        private readonly TourismDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public AdminPostRepository(TourismDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<IEnumerable<AdminPost>> GetAllAdminPosts()
        {
            return await _context.AdminPost.ToListAsync();
        }

        public async Task<AdminPost> GetAdminPostById(int id)
        {
            return await _context.AdminPost.FindAsync(id);
        }

        public async Task<AdminPost> AddAdminPost(AdminPost adminPost, IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                var uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "uploads/images");
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

                adminPost.PlaceImagePath = fileName;
            }


            var r = _context.adminRegisters.Find(adminPost.adminRegister.Admin_Id);
            adminPost.adminRegister = r;

            _context.AdminPost.Add(adminPost);
            await _context.SaveChangesAsync();

            return adminPost;
        }

        public async Task UpdateAdminPost(int id, AdminPost adminPost)
        {
            if (id != adminPost.id)
            {
                throw new ArgumentException("ID mismatch");
            }

            _context.Entry(adminPost).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAdminPost(int id)
        {
            var adminPost = await _context.AdminPost.FindAsync(id);
            if (adminPost != null)
            {
                _context.AdminPost.Remove(adminPost);
                await _context.SaveChangesAsync();
            }
        }
    }
}
