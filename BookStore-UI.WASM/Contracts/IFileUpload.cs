using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorInputFile;
using BookStore_UI.WASM.Models;

namespace BookStore_UI.WASM.Contracts
{
    public interface IFileUpload
    {
        public Task UploadFile(IFileListEntry file, MemoryStream msFile, string picName);
        public void RemoveFile(string picName);

    }
}