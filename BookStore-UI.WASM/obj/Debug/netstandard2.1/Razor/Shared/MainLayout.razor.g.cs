#pragma checksum "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5034314411fdee63138d45f2b495572ca2e380a2"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore_UI.WASM.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "sidebar");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<BookStore_UI.WASM.Shared.NavMenu>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\">\r\n        <a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4 mt-6");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-body");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.AddContent(21, 
#nullable restore
#line 17 "/home/cannonjw/Projects/BookStore/BookStore-UI.WASM/Shared/MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
