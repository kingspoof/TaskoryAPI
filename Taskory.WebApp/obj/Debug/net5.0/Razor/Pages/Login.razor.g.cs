#pragma checksum "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7259f5196ca5fe10de435cb5ae35fd9b2dece90b"
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
#line 4 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Pages/Login.razor"
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
            __builder.AddMarkupContent(0, "<div style=\"height:200px;\"></div>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "width:100%; text-align:center;");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "style", "width:100%; text-align:center;");
            __builder.AddMarkupContent(5, "<tr><td><h1>login</h1></td></tr>\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddAttribute(7, "hidden", 
#nullable restore
#line 16 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Pages/Login.razor"
                     String.IsNullOrEmpty(notes)

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(8, "td");
            __builder.OpenElement(9, "label");
            __builder.AddContent(10, 
#nullable restore
#line 18 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Pages/Login.razor"
                        notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "<br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Pages/Login.razor"
                                          username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "<br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n        ");
            __builder.OpenElement(21, "tr");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "password");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Pages/Login.razor"
                                              password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "<br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n        ");
            __builder.OpenElement(29, "tr");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Pages/Login.razor"
                                                          login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "test");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "<br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Pages/Login.razor"
       
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
            notes = $"Invalid username or password {count++}";
        else
        {
            loginstate.Username = username;
            loginstate.IsLoggedIn = true;
            loginstate.OrganisationID = Convert.ToInt32(transmitioncode.Split("-")[2]);
            loginstate.IsAdmin = Convert.ToInt32(transmitioncode.Split("-")[0]) % 79 == 0;
            if (loginstate.IsAdmin)
                loginstate.UserID = Convert.ToInt32(transmitioncode.Split("-")[0]) / 79;
            else
                loginstate.UserID = Convert.ToInt32(transmitioncode.Split("-")[0]);
            loginstate.SA = Convert.ToInt32(transmitioncode.Split("-")[0]) == 9973;
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
