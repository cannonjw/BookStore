#pragma checksum "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a2516bc725138b09994b0fc982d1c6a4a8ad64b"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore_UI.Pages.Authors
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Authors</h3>\n\n");
#nullable restore
#line 8 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Index.razor"
 if(Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div class=\"alert alert-dismissible alert-secondary\">\n        Loading...\n    </div>\n");
#nullable restore
#line 13 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Index.razor"
} else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-responsive");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<thead>\n            <tr>\n                <th>First Name</th>\n                <th>Lasst Name</th>\n                <th>Actions</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\n");
#nullable restore
#line 24 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Index.razor"
             foreach(var author in Model)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 27 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Index.razor"
                         author.Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 28 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Index.razor"
                         author.Lastname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddMarkupContent(20, "\n                        ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "/authors/view/" + (
#nullable restore
#line 30 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Index.razor"
                                                author.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddMarkupContent(24, "\n                            <span class=\"oi oi-book\"></span>\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                        ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "/authors/edit/" + (
#nullable restore
#line 33 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Index.razor"
                                                author.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-warning");
            __builder.AddMarkupContent(29, "\n                            <span class=\"oi oi-pencil\"></span>\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                        ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", "/authors/delete/" + (
#nullable restore
#line 36 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Index.razor"
                                                  author.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "class", "btn btn-danger");
            __builder.AddMarkupContent(34, "\n                            <span class=\"oi oi-delete\"></span>\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n");
#nullable restore
#line 41 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n");
#nullable restore
#line 44 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Index.razor"
       
    private IList<Author> Model;
    protected async override Task OnInitializedAsync() 
    {
        Model = await _authRep.Get(Endpoints.AuthorsEndpoint);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorRepository _authRep { get; set; }
    }
}
#pragma warning restore 1591
