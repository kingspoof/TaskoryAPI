#pragma checksum "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8391fb01d8ca67607ec36cff7143be3c58687c01"
// <auto-generated/>
#pragma warning disable 1591
namespace Taskory.WebApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/_Imports.razor"
using Taskory.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/_Imports.razor"
using Taskory.WebApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/MainLayout.razor"
 if (loginstate.IsLoggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-fw7s7d35ld");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-fw7s7d35ld");
            __builder.OpenComponent<Taskory.WebApp.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-fw7s7d35ld");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content px-4");
            __builder.AddAttribute(13, "b-fw7s7d35ld");
            __builder.AddContent(14, 
#nullable restore
#line 15 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/MainLayout.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, 
#nullable restore
#line 22 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 22 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/MainLayout.razor"
         
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/MainLayout.razor"
       

    protected override async System.Threading.Tasks.Task OnInitializedAsync()
    {
        if (!loginstate.IsLoggedIn)
        {
            Console.Write("Rederect to login");
            Navigation.NavigateTo("/");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginState loginstate { get; set; }
    }
}
#pragma warning restore 1591
