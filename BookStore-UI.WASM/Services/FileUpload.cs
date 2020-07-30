using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using BlazorInputFile;
using BookStore_UI.WASM.Contracts;
using BookStore_UI.WASM.Models;
// using Microsoft.AspNetCore.Hosting;

namespace BookStore_UI.WASM.Services
{
    // public class FileUpload : IFileUpload
    // {
    //     private readonly IHttpClientFactory _client;
    //     private readonly ILocalStorageService _localStorage;
    //     private readonly IWebHostEnvironment _env;
    //     public FileUpload(IHttpClientFactory client, ILocalStorageService localStorage, IWebHostEnvironment env)
    //     {
    //         _env = env;
    //         _localStorage = localStorage;
    //         _client = client;
    //     }

    //     public void RemoveFile(string picName)
    //     {
    //         var path = $"{_env.WebRootPath}/Uploads/{picName}";
    //         if (File.Exists(path))
    //         {
    //             File.Delete(path);
    //         }
    //     }
    //     public async Task UploadFile(IFileListEntry file, MemoryStream msFile, string picName)
    //     {
    //         try
    //         {
    //             await file.Data.CopyToAsync(msFile);
    //             var path = $"{_env.WebRootPath}/Uploads/{picName}";
    //             using(FileStream fs = new FileStream(path, FileMode.Create))
    //             {
    //                 msFile.WriteTo(fs);
    //             }
    //         } catch (Exception _ex)
    //         {
    //             throw new Exception(_ex.Message);
    //         }
    //     }
    // }
}