using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Helper
{
    public class SaveFile : ISaveFile
    {

        private readonly IWebHostEnvironment webHostEnvironment;

        public SaveFile(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task<string> SaveFileAsync( string folderName, IFormFile file)
        {
            string filePath;
            string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, $"Documents\\{folderName}");

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            var s = file.FileName.Split('.');

            string fileName = Guid.NewGuid().ToString("N") + "." + s[^1];

            filePath = Path.Combine(uploadsFolder, fileName);

            using (Stream fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            Console.WriteLine($"File Path: /Documents/{folderName}/{fileName}");

            return $"/Documents/{folderName}/{fileName}";
        }
    }
}
