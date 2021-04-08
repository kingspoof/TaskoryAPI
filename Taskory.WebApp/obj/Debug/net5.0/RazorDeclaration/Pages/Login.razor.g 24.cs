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
#line 4 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/Login.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/Users/lucienkaser/Documents/Development/Taskory.git/Taskory.WebApp/Pages/Login.razor"
       
    private string notes;
    private string username;
    private string password;
    private int count;

    private async System.Threading.Tasks.Task login()
    {
        //Console.WriteLine("API -> " + configuration["API"]);
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(configuration["API"]);

        var response = await client.GetAsync($"api/User?username={username}&password={password}");
        Console.Write(response.Content.Headers);
        var transmitioncode = await response.Content.ReadAsStringAsync();
        Console.WriteLine();

        if (String.IsNullOrEmpty(transmitioncode) || transmitioncode.ToLower().Equals("false"))
            notes = $"login failed try again {count++}";
        else
        {
            loginstate.Username = username;
            loginstate.IsLoggedIn = true;
            loginstate.IsAdmin = Convert.ToInt32(transmitioncode.Split("-")[0]) % 79 == 0;
            loginstate.UserID = Convert.ToInt32(transmitioncode.Split("-")[0]) / 79;
            loginstate.Transmitioncode = transmitioncode;
            notes = "login completed";

            Navigation.NavigateTo("/Index");
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginState loginstate { get; set; }
    }
}
#pragma warning restore 1591
