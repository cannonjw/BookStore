#pragma checksum "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddea192803dac6d8e329a3173c7499b4006f82c8"
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
#nullable restore
#line 2 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Create.razor"
           [Authorize(Roles="Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Create New Author</h3>\n<br>\n<hr>\n<br>\n");
#nullable restore
#line 10 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Create.razor"
 if (!isSuccess)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BookStore_UI.Shared.ErrorMessage>(2);
            __builder.AddAttribute(3, "Message", "Something went wrong when trying to create a new author.");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
#nullable restore
#line 13 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Create.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Create.razor"
                 Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Create.razor"
                                       CreateAuthor

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "\n        ");
                __builder2.AddMarkupContent(18, "<label for=\"firstname\">First Name</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "class", "form-conrol");
                __builder2.AddAttribute(21, "id", "firstname");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Create.razor"
                                Model.Firstname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Firstname = __value, Model.Firstname))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Firstname));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "\n        ");
                __builder2.AddMarkupContent(30, "<label for=\"lastnamename\">Last Name</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "class", "form-conrol");
                __builder2.AddAttribute(33, "id", "lastname");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Create.razor"
                                Model.Lastname

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Lastname = __value, Model.Lastname))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Lastname));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "\n        ");
                __builder2.AddMarkupContent(42, "<label for=\"bio\">Bio</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(43);
                __builder2.AddAttribute(44, "class", "form-conrol");
                __builder2.AddAttribute(45, "id", "bio");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Create.razor"
                                    Model.Bio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Bio = __value, Model.Bio))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Bio));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n    ");
                __builder2.AddMarkupContent(51, "<button class=\"btn btn-primary\">Create Author</button>\n    ");
                __builder2.OpenElement(52, "button");
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Create.razor"
                      BackToList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "class", "btn btn-outline-secondary");
                __builder2.AddMarkupContent(55, "\n        <span class=\"oi oi-media-skip-backward\"></span>\n        Back To List\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "/home/cannonjw/Projects/BookStore/BookStore-UI/Pages/Authors/Create.razor"
       
    private Author Model = new Author();
    private bool isSuccess = true;

    private async Task CreateAuthor()
    {
        isSuccess = await _authRep.Create(Endpoints.AuthorsEndpoint, Model);
        if (isSuccess)
        {
            BackToList();
        }
    }

    private void BackToList()
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
