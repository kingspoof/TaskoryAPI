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
#line 3 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/CreateAdmin.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createadmin/{oid:int}")]
    public partial class CreateAdmin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/CreateAdmin.razor"
       
    [Parameter]
    public int oid { get; set; }

    private User targetuser { get; set; }
    private string createMessage = "";

    protected override async System.Threading.Tasks.Task OnInitializedAsync()
    {
        targetuser = new User();
    }

    private async System.Threading.Tasks.Task saveNewUser()
    {
        if(
            !String.IsNullOrEmpty(targetuser.Name) &&
            !String.IsNullOrEmpty(targetuser.FirstName) &&
            !String.IsNullOrEmpty(targetuser.Username) &&
            !String.IsNullOrEmpty(targetuser.Password)
            )
        {
            targetuser.AuthentificationTempelate = "79";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(configuration["API"]);
            var result = await client.PostAsJsonAsync($"api/User?organisationID={oid}", targetuser);
            if (result.StatusCode == (System.Net.HttpStatusCode)420)
            {
                createMessage = "username already taken";
            }
            else
            {
                nav.NavigateTo("/Index");
            }
        }
        else
        {
            createMessage = "fill all required fields";
        }
    }

    private void Discard()
    {
        nav.NavigateTo("/Index");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginState loginstate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
