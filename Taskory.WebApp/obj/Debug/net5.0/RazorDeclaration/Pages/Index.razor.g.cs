// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Taskory.WebApp.Pages
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
#nullable restore
#line 3 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Pages/Index.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Pages/Index.razor"
     
    private Organisation o { get; set; } = new Organisation();

    protected override async System.Threading.Tasks.Task OnInitializedAsync()
    {
        if (!loginstate.SA)
        {
            //api for organisation
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(configuration["API"]);

            var response = await client.GetAsync($"api/Organisations/{loginstate.UserID}");
            o = await response.Content.ReadFromJsonAsync<Organisation>();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginState loginstate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration configuration { get; set; }
    }
}
#pragma warning restore 1591
