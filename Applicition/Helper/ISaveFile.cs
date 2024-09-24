using Microsoft.AspNetCore.Http;

namespace Application.Helper
{
    public interface ISaveFile
    {
        Task<string> SaveFileAsync( string folderName, IFormFile file);
    }
}