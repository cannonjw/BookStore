#pragma checksum "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b426f8fae598038ed1e7bfdad82566d7d0725535"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Books</h3>\n\n");
#nullable restore
#line 9 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
 if(Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BookStore_UI.Shared.LoadingMessage>(2);
            __builder.AddAttribute(3, "Message", "Loading Books...");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
#nullable restore
#line 12 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
} else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Roles", "Administrator");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\n            ");
                __builder2.AddMarkupContent(10, "<a href=\"/books/create\" class=\"btn btn-primary\"><span class=\"oi oi-plus\"></span>Create New Book</a>\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\n");
#nullable restore
#line 18 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
     if (Model.Count < 1)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "        ");
            __builder.OpenComponent<BookStore_UI.Shared.ErrorMessage>(13);
            __builder.AddAttribute(14, "Message", "There are no books in the database.  Please add new books.");
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 21 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
    } else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.OpenElement(17, "table");
            __builder.AddAttribute(18, "class", "table table-responsive");
            __builder.AddMarkupContent(19, "\n            ");
            __builder.AddMarkupContent(20, @"<thead>
                <tr>
                    <th></th>
                    <th>Title</th>
                    <th>Price</th>
                    <th>Author</th>
                    <th>Actions</th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(21, "tbody");
            __builder.AddMarkupContent(22, "\n");
#nullable restore
#line 34 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                 foreach(var book in Model)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                    ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\n                        ");
            __builder.OpenElement(26, "td");
            __builder.AddMarkupContent(27, "\n");
#nullable restore
#line 38 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                             if(book.Image.Contains("http"))
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                                ");
            __builder.OpenElement(29, "img");
            __builder.AddAttribute(30, "src", 
#nullable restore
#line 40 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                                           book.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "style", "height:50px; width:50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
#nullable restore
#line 41 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                            } else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "                                ");
            __builder.OpenElement(34, "img");
            __builder.AddAttribute(35, "src", "Uploads/" + (
#nullable restore
#line 43 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                                                   book.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "style", "height:50px; width:50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n");
#nullable restore
#line 44 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n                        ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 46 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                             book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                        ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 47 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                             book.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n");
#nullable restore
#line 48 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                         if (book.author == null)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "                            ");
            __builder.AddMarkupContent(47, "<td>No Author</td>\n");
#nullable restore
#line 51 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                        } else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "                            ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 53 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                                 book.author.Lastname

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(51, ", ");
            __builder.AddContent(52, 
#nullable restore
#line 53 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                                                        book.author.Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n");
#nullable restore
#line 54 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "                        ");
            __builder.OpenElement(55, "td");
            __builder.AddMarkupContent(56, "\n                            ");
            __builder.OpenElement(57, "a");
            __builder.AddAttribute(58, "href", "/books/view/" + (
#nullable restore
#line 56 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                                                  book.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "class", "btn btn-primary");
            __builder.AddMarkupContent(60, "\n                                <span class=\"oi oi-book\"></span>\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(62);
            __builder.AddAttribute(63, "Roles", "Administrator");
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(65, "\n                                ");
                __builder2.OpenElement(66, "a");
                __builder2.AddAttribute(67, "href", "/books/edit/" + (
#nullable restore
#line 60 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                                                      book.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "class", "btn btn-warning");
                __builder2.AddMarkupContent(69, "\n                                    <span class=\"oi oi-pencil\"></span>\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n                                ");
                __builder2.OpenElement(71, "a");
                __builder2.AddAttribute(72, "href", "/books/delete/" + (
#nullable restore
#line 63 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                                                        book.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "class", "btn btn-danger");
                __builder2.AddMarkupContent(74, "\n                                    <span class=\"oi oi-delete\"></span>\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n                                \n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\n                            \n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\n");
#nullable restore
#line 71 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n");
#nullable restore
#line 74 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Books/Index.razor"
       
    IList<Book> Model;

    protected async override Task OnInitializedAsync()
    {
        Model = await _bookRepo.Get(Endpoints.BooksEndpoint);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookRepository _bookRepo { get; set; }
    }
}
#pragma warning restore 1591
