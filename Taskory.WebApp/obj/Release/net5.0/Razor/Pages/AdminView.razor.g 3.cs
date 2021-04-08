#pragma checksum "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/AdminView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae99d7e451ccdbeb0e319eb354d3c0d8c35d79ec"
// <auto-generated/>
#pragma warning disable 1591
namespace Taskory.WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/_Imports.razor"
using Taskory.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/_Imports.razor"
using Taskory.WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/AdminView.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adminview")]
    public partial class AdminView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/AdminView.razor"
 if (loginstate.IsAdmin)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/AdminView.razor"
     if (org == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading ...</em></p>");
#nullable restore
#line 16 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/AdminView.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, 
#nullable restore
#line 19 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/AdminView.razor"
             org.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n        ");
            __builder.OpenComponent<Taskory.WebApp.Shared.TaskManagement>(4);
            __builder.AddAttribute(5, "o", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Taskory.WebApp.Organisation>(
#nullable restore
#line 20 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/AdminView.razor"
                          org

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenComponent<Taskory.WebApp.Shared.UserManagement>(7);
            __builder.AddAttribute(8, "o", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Taskory.WebApp.Organisation>(
#nullable restore
#line 21 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/AdminView.razor"
                          org

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 22 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/AdminView.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/AdminView.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/AdminView.razor"
       
    private Organisation org;


    protected override async System.Threading.Tasks.Task OnInitializedAsync()
    {
        Console.WriteLine("Doing something");

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(configuration["API"]);

        var response = await client.GetAsync($"api/Organisations/{loginstate.UserID}");
        org = await response.Content.ReadFromJsonAsync<Organisation>();
        Console.WriteLine(org);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginState loginstate { get; set; }
    }
}
#pragma warning restore 1591
