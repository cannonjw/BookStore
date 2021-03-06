#pragma checksum "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d6ed451aa8df86a2088f3c8435017a36a7ebeda"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/view/{Id}")]
    public partial class View : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<BookStore_UI.WASM.Shared.LoadingMessage>(1);
            __builder.AddAttribute(2, "Message", "Loading...");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
#nullable restore
#line 9 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
} else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-4");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table table-responsive");
            __builder.AddMarkupContent(10, "\n            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\n                ");
            __builder.AddMarkupContent(13, "<td>First Name</td>\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 15 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
                     Model.Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n            ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\n                ");
            __builder.AddMarkupContent(20, "<td>Last Name</td>\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 19 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
                     Model.Lastname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n            ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\n                ");
            __builder.AddMarkupContent(27, "<td>Biography</td>\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 23 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
                     Model.Bio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n        <br>\n");
#nullable restore
#line 27 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
         if (Model.Books == null || Model.Books.Count < 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "            ");
            __builder.AddMarkupContent(34, "<div class=\"alert alert-dismissible alert-secondary\">\n                No books for this author\n            </div>\n");
#nullable restore
#line 32 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
        } else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "card");
            __builder.AddAttribute(38, "style", "width: 18rem;");
            __builder.AddMarkupContent(39, "\n                ");
            __builder.AddMarkupContent(40, "<div class=\"card-header\">\n                    Authors Books\n                </div>\n                ");
            __builder.OpenElement(41, "ul");
            __builder.AddAttribute(42, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(43, "\n                    \n");
#nullable restore
#line 40 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
                     foreach(var book in Model.Books)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                        ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "list-group-tem");
            __builder.AddContent(47, 
#nullable restore
#line 42 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
                                                    book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(48, " - ");
            __builder.AddContent(49, 
#nullable restore
#line 42 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
                                                                  book.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n");
#nullable restore
#line 43 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n");
#nullable restore
#line 46 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n");
#nullable restore
#line 49 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "\n");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
                  BacktoList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "class", "btn btn-outline-secondary");
            __builder.AddMarkupContent(60, "\n    ");
            __builder.AddMarkupContent(61, "<span class=\"oi oi-media-skip-backward\">\n        \n    </span>Back to List");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Pages copy/Authors/View.razor"
       
    [Parameter]
    public string Id { get; set; }
    private Author Model;

    protected override async Task OnInitializedAsync()
    {
        int id = int.Parse(Id);
        Model = await _authRepo.Get(Endpoints.AuthorsEndpoint, id);
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
