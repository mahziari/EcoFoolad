// using System;
// using System.ComponentModel.DataAnnotations;
// using System.IO;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.AspNetCore.Http;
//
// namespace ParsaPoolad.Common.Services
// {
//     public class UploadDeleteFiles
//     {
//         private static IHostingEnvironment _environment;
//
//         public UploadDeleteFiles(IHostingEnvironment environment)
//         {
//             _environment = environment;
//         }
//         
//         
//         public static UploadDto UploadFile(IFormFile file)
//         {
//             if (file == null || file.Length <= 0)
//                 return new UploadDto()
//                 {
//                     Status = false,
//                     FileNameAddress = "",
//                 };
//             
//             // var finalRootPath = rootPath.Replace("/", @"\");
//             string folder =$@"Images\Blogs\";
//             var uploadsRootFolder = Path.Combine(_environment.WebRootPath, folder);
//             if (!Directory.Exists(uploadsRootFolder))
//             {
//                 Directory.CreateDirectory(uploadsRootFolder);
//             }
//
//             string fileName = DateTime.Now.Ticks + file.FileName;
//             var filePath = Path.Combine(uploadsRootFolder, fileName);
//             using var fileStream = new FileStream(filePath, FileMode.Create);
//             file.CopyTo(fileStream);
//
//             return new UploadDto()
//             {
//                 Status = true,
//                 FileNameAddress = folder + fileName,
//             };
//
//         }
//
//     }
//
//
//     public class UploadFile
//     {
//         public bool Status { get; set; }
//         public string FileNameAddress { get; set; }
//     }
//     
//     public class UploadDto
//     {
//         public bool Status { get; set; }
//         public string FileNameAddress { get; set; }
//     }
// }