#pragma checksum "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "399fa31f29dc99691c4d3f4bdb7f1fc8c4ac2f3f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookStore_UI.Pages.Books
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using BookStore_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using BookStore_UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using BookStore_UI.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using BookStore_UI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using BookStore_UI.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using BookStore_UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/home/cannonjw/Projects/BookStore/BookStore-UI/_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Delete.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Delete.razor"
           [Authorize(Roles="Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books/delete/{Id}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Delete.razor"
       
    [Parameter]
    public string Id { get; set; }
    private bool isSuccess = true;
    private Book Model;

    protected async override Task OnInitializedAsync()
    {
        int id = int.Parse(Id);
        Model = await _bookRepo.Get(Endpoints.BooksEndpoint, id);
    }

    private async Task DeleteBook()
    {
        _fileUpload.RemoveFile(Model.Image);
        int id = int.Parse(Id);
        isSuccess = await _bookRepo.Delete(Endpoints.BooksEndpoint, id);
        BackToList();
    }

    private void BackToList()
    {
        _navMan.NavigateTo("/books/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload _fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookRepository _bookRepo { get; set; }
    }
}
#pragma warning restore 1591