#pragma checksum "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1217f8d0c3e0760635d3143e0d338173d104a02"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore_UI.WASM.Pages_copy.Authors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using BookStore_UI.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using BookStore_UI.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using BookStore_UI.WASM.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using BookStore_UI.WASM.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using BookStore_UI.WASM.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
           [Authorize(Roles="Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/delete/{Id}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Are you sure you want to delete this record?</h3>\n<br>\n<hr>\n<br>\n");
#nullable restore
#line 10 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
 if(Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BookStore_UI.WASM.Shared.LoadingMessage>(2);
            __builder.AddAttribute(3, "Message", "Loading author details...");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
#nullable restore
#line 13 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
} else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
     if (IsFailed)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenComponent<BookStore_UI.WASM.Shared.ErrorMessage>(6);
            __builder.AddAttribute(7, "Message", "Something went wrong with the delete.");
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\n");
#nullable restore
#line 18 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-4");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table table-responsive");
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\n                ");
            __builder.AddMarkupContent(18, "<td>First Name</td>\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 24 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
                     Model.Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n            ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\n                ");
            __builder.AddMarkupContent(25, "<td>Last Name</td>\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 28 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
                     Model.Lastname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n            ");
            __builder.OpenElement(30, "tr");
            __builder.AddMarkupContent(31, "\n                ");
            __builder.AddMarkupContent(32, "<td>Biography</td>\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 32 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
                     Model.Bio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n        <br>\n");
#nullable restore
#line 36 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
         if (Model.Books == null || Model.Books.Count < 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "            ");
            __builder.AddMarkupContent(39, "<div class=\"alert alert-dismissible alert-secondary\">\n                No books for this author\n            </div>\n");
#nullable restore
#line 41 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
        } else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "card");
            __builder.AddAttribute(43, "style", "width: 18rem;");
            __builder.AddMarkupContent(44, "\n                ");
            __builder.AddMarkupContent(45, "<div class=\"card-header\">\n                    Authors Books\n                </div>\n                ");
            __builder.OpenElement(46, "ul");
            __builder.AddAttribute(47, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(48, "\n                    \n");
#nullable restore
#line 49 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
                     foreach(var book in Model.Books)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                        ");
            __builder.OpenElement(50, "li");
            __builder.AddAttribute(51, "class", "list-group-tem");
            __builder.AddContent(52, 
#nullable restore
#line 51 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
                                                    book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, " - ");
            __builder.AddContent(54, 
#nullable restore
#line 51 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
                                                                  book.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n");
#nullable restore
#line 52 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n");
#nullable restore
#line 55 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n");
#nullable restore
#line 58 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"

}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
                  DeleteAuthor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "class", "btn btn-danger");
            __builder.AddMarkupContent(64, "\n    ");
            __builder.AddMarkupContent(65, "<span class=\"oi oi-delete\">\n        \n    </span>Delete Author");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n\n");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
                  BacktoList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "class", "btn btn-outline-secondary");
            __builder.AddMarkupContent(70, "\n    ");
            __builder.AddMarkupContent(71, "<span class=\"oi oi-media-skip-backward\">\n        \n    </span>Back to List");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/Delete.razor"
       
    [Parameter]
    public string Id { get; set; }

    private Author Model;
    private bool IsFailed = false;

    protected override async Task OnInitializedAsync()
    {
        int id = int.Parse(this.Id);
        Model = await _authRepo.Get(Endpoints.AuthorsEndpoint, id);
    }

    private async Task DeleteAuthor()
    {
        int id = int.Parse(this.Id);
        bool isSuccess = await _authRepo.Delete(Endpoints.AuthorsEndpoint, id);
        if (isSuccess)
        {
            BacktoList();
        } else
        {
            IsFailed = true;
        }

    }
    private void BacktoList()
    {
        _navManager.NavigateTo("/authors/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorRepository _authRepo { get; set; }
    }
}
#pragma warning restore 1591
