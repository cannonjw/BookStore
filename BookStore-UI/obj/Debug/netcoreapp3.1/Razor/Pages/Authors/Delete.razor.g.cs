#pragma checksum "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86026b140eedf83b7a901cff4399ce0ffe6aa823"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/delete/{Id}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Are you sure you want to delete this record?</h3>\n\n");
#nullable restore
#line 8 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
 if(Model == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div class=\"alert alert-dismissible alert-secondary\">\n        Loading...\n    </div>\n");
#nullable restore
#line 13 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
} else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
     if (IsFailed)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.AddMarkupContent(4, "<div class=\"alert alert-danger\">\n            <p>Something went wrong with your Delete</p>\n        </div>\n");
#nullable restore
#line 20 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-4");
            __builder.AddMarkupContent(8, "\n        ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-responsive");
            __builder.AddMarkupContent(11, "\n            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\n                ");
            __builder.AddMarkupContent(14, "<td>First Name</td>\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 26 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
                     Model.Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\n                ");
            __builder.AddMarkupContent(21, "<td>Last Name</td>\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 30 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
                     Model.Lastname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n            ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\n                ");
            __builder.AddMarkupContent(28, "<td>Biography</td>\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 34 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
                     Model.Bio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n        <br>\n");
#nullable restore
#line 38 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
         if (Model.Books == null || Model.Books.Count < 1)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "            ");
            __builder.AddMarkupContent(35, "<div class=\"alert alert-dismissible alert-secondary\">\n                No books for this author\n            </div>\n");
#nullable restore
#line 43 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
        } else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "card");
            __builder.AddAttribute(39, "style", "width: 18rem;");
            __builder.AddMarkupContent(40, "\n                ");
            __builder.AddMarkupContent(41, "<div class=\"card-header\">\n                    Authors Books\n                </div>\n                ");
            __builder.OpenElement(42, "ul");
            __builder.AddAttribute(43, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(44, "\n                    \n");
#nullable restore
#line 51 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
                     foreach(var book in Model.Books)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                        ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "list-group-tem");
            __builder.AddContent(48, 
#nullable restore
#line 53 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
                                                    book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(49, " - ");
            __builder.AddContent(50, 
#nullable restore
#line 53 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
                                                                  book.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n");
#nullable restore
#line 54 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n");
#nullable restore
#line 57 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n");
#nullable restore
#line 60 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"

}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
                  DeleteAuthor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "class", "btn btn-danger");
            __builder.AddMarkupContent(60, "\n    ");
            __builder.AddMarkupContent(61, "<span class=\"oi oi-delete\">\n        \n    </span>Delete Author");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n\n");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
                  BacktoList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "class", "btn btn-outline-secondary");
            __builder.AddMarkupContent(66, "\n    ");
            __builder.AddMarkupContent(67, "<span class=\"oi oi-media-skip-backward\">\n        \n    </span>Back to List");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Delete.razor"
       
    [Parameter]
    public string Id { get; set; }

    private Author Model;
    private bool IsFailed = false;

    protected override async Task OnInitializedAsync()
    {
        int id = int.Parse(this.Id);
        Model = await _authRep.Get(Endpoints.AuthorsEndpoint, id);
    }

    private async Task DeleteAuthor()
    {
        int id = int.Parse(this.Id);
        bool isSuccess = await _authRep.Delete(Endpoints.AuthorsEndpoint, id);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorRepository _authRep { get; set; }
    }
}
#pragma warning restore 1591