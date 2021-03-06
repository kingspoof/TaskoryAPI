// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/UserTasks.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    public partial class UserTasks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/UserTasks.razor"
       
    [Parameter]
    public Organisation o { get; set; }

    protected override async System.Threading.Tasks.Task OnInitializedAsync()
    {
        if (o.Tasks == null)
            o.Tasks = new List<WebApp.Task>();
    }
    private void MarkTaskAsCompleted(int id)
    {
        Console.WriteLine("Update ");
        var task = o.Tasks.FirstOrDefault(t => t.ID == id);
        task.StartDate = task.StartDate.AddDays(task.RepeatAfterXDays);
        Console.WriteLine(task.StartDate);
        SaveChanges();
    }
    private void SaveChanges()
    {
        HttpClient client = new HttpClient();
        var result = client.PutAsJsonAsync($"{configuration["API"]}api/Organisations/{o.ID}?transpondercode={loginstate.UserID}", o);
        Console.WriteLine(result);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginState loginstate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration configuration { get; set; }
    }
}
#pragma warning restore 1591
