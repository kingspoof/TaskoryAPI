#pragma checksum "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d1cce642c205cc36e620a8d8835931d41442688"
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
#line 10 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/_Imports.razor"
using Taskory.WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
using Taskory.WebApp;

#line default
#line hidden
#nullable disable
    public partial class TaskManagement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-body");
            __builder.AddMarkupContent(4, "<i @bind=\"CreateMessasge\"></i>\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-sm-7");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-hover table-borderless");
            __builder.AddMarkupContent(13, @"<thead><tr><th>Name</th>
                                <th>Description</th>
                                <th>Repeat after n days</th>
                                <th>Next</th>
                                <th>User</th></tr></thead>
                        ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 25 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                             foreach (var t in o.Tasks.Where(n => !n.Deleted))
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                              () => TaskClicked(t.ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 28 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                         t.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 29 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                         t.Descriprion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 30 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                         t.RepeatAfterXDays

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 31 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                         t.StartDate.ToString("dd.MM.yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 33 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                         o.Users.Where(n => n.ID == t.UserID).FirstOrDefault().Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-sm-5");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "card");
            __builder.AddAttribute(36, "hidden", 
#nullable restore
#line 40 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                               HideCreate

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "card-body");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "card-body");
            __builder.OpenElement(41, "p");
            __builder.AddAttribute(42, "class", "fw-light");
            __builder.AddContent(43, 
#nullable restore
#line 43 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                      create? "Create" : "Edit" 

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(44, " Task");
            __builder.CloseElement();
#nullable restore
#line 44 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                 if (create)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<i @bind=\"CreateMessage\"></i>");
#nullable restore
#line 47 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "input-group input-group-sm mb-3");
            __builder.AddMarkupContent(48, "<div class=\"input-group-prepend\"><span class=\"input-group-text\" id=\"inputGroup-sizing-sm\">*Name</span></div>\n                                    ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "text");
            __builder.AddAttribute(51, "class", "form-control");
            __builder.AddAttribute(52, "aria-label", "Name");
            __builder.AddAttribute(53, "aria-describedby", "inputGroup-sizing-sm");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                                                                                                             TaskToCreate.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TaskToCreate.Name = __value, TaskToCreate.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n                                ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "input-group input-group-sm mb-3");
            __builder.AddMarkupContent(59, "<div class=\"input-group-prepend\"><span class=\"input-group-text\" id=\"inputGroup-sizing-sm\">Description</span></div>\n                                    ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "text");
            __builder.AddAttribute(62, "class", "form-control");
            __builder.AddAttribute(63, "aria-label", "Name");
            __builder.AddAttribute(64, "aria-describedby", "inputGroup-sizing-sm");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                                                                                                             TaskToCreate.Descriprion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TaskToCreate.Descriprion = __value, TaskToCreate.Descriprion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n                                ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "input-group input-group-sm mb-3");
            __builder.AddMarkupContent(70, "<div class=\"input-group-prepend\"><span class=\"input-group-text\" id=\"inputGroup-sizing-sm\">*Repeat after n days</span></div>\n                                    ");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "type", "number");
            __builder.AddAttribute(73, "class", "form-control");
            __builder.AddAttribute(74, "aria-label", "Name");
            __builder.AddAttribute(75, "aria-describedby", "inputGroup-sizing-sm");
            __builder.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                                                                                                               TaskToCreate.RepeatAfterXDays

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TaskToCreate.RepeatAfterXDays = __value, TaskToCreate.RepeatAfterXDays, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\n                                ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "input-group input-group-sm mb-3");
            __builder.AddMarkupContent(81, "<div class=\"input-group-prepend\"><span class=\"input-group-text\" id=\"inputGroup-sizing-sm\">*Next</span></div>\n                                    ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                  TaskToCreate.StartDate

#line default
#line hidden
#nullable disable
            , format: "dd.MM.yyyy"));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TaskToCreate.StartDate = __value, TaskToCreate.StartDate, format: "dd.MM.yyyy"));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n                                ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "input-group input-group-sm mb-3");
            __builder.AddMarkupContent(88, "<div class=\"input-group-prepend\"><span class=\"input-group-text\" id=\"inputGroup-sizing-sm\">*User</span></div>\n                                    ");
            __builder.OpenElement(89, "select");
            __builder.AddAttribute(90, "class", "form-control selectpicker");
            __builder.AddAttribute(91, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                                                     TaskToCreate.UserID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TaskToCreate.UserID = __value, TaskToCreate.UserID));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 83 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                         foreach (var user in o.Users.Where(n => !n.Deleted))
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", 
#nullable restore
#line 85 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                            user.ID

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, 
#nullable restore
#line 85 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                                      user.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 86 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                            // Blazor needs to know what values it binds to!
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n                                ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "hidden", 
#nullable restore
#line 90 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                              HideCreateButtons

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(99, "button");
            __builder.AddAttribute(100, "class", "btn btn-primary");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                                              SaveTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(102, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n                                    ");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "class", "btn btn-secondary");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                                                DiscardTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(107, "Discard");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\n            ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "row");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col-sm-12");
#nullable restore
#line 101 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                     if (changes)
                    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(113, "button");
            __builder.AddAttribute(114, "class", "btn btn-danger");
            __builder.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                                 SaveChanges

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(116, "Save");
            __builder.CloseElement();
#nullable restore
#line 105 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(117, "button");
            __builder.AddAttribute(118, "class", "btn btn-info");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                               SaveChanges

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(120, "Save");
            __builder.CloseElement();
#nullable restore
#line 109 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(121, "button");
            __builder.AddAttribute(122, "class", "btn btn-secondary");
            __builder.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                                StartTaskCreation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(124, "Create");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\n                    ");
            __builder.OpenElement(126, "button");
            __builder.AddAttribute(127, "class", "btn btn-dark");
            __builder.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 111 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
                                                           DeleteSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(129, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "/Users/lucienkaser/Development/Taskory/Taskory.WebApp/Shared/TaskManagement.razor"
       
    [Parameter]
    public Organisation o { get; set; }
    public bool changes = false;


    protected override async System.Threading.Tasks.Task OnInitializedAsync()
    {
        if (o.Tasks == null)
            o.Tasks = new List<Taskory.WebApp.Task>();
        TaskToCreate = new WebApp.Task();
        TaskToCreate.StartDate = new DateTime();
        TaskToCreate.EndDate = new DateTime();
    }


    #region CreateTask
    private Taskory.WebApp.Task TaskToCreate { get; set; } = new WebApp.Task();
    private string CreateMessage = "";
    private bool HideCreate = true;
    private bool HideCreateButtons = false;
    private bool create = false;
    private bool edit = false;


    private void StartTaskCreation()
    {
        changes = true;
        TaskToCreate = new WebApp.Task();
        HideCreate = false;
        create = true;
        edit = false;
        HideCreateButtons = false;
    }

    private void SaveTask()
    {


        bool stringValid = !String.IsNullOrEmpty(TaskToCreate.Name);
        bool RAXDValid = TaskToCreate.RepeatAfterXDays > 0;
        bool StartValid = TaskToCreate.StartDate > DateTime.Now.AddMonths(-5);
        bool userValid = (o.Users.Any(u => u.ID == TaskToCreate.UserID));


        if (stringValid && RAXDValid && StartValid && userValid)
        {
            if (create)
            {
                o.Tasks.Add(TaskToCreate);
                Console.WriteLine("Adding task");
                HideCreate = true;
                SaveChanges();
            }
        }
        else
        {
            Console.WriteLine("Wrong");
            CreateMessage = "Fill required field!";
        }
        changes = true;
    }


    private void DiscardTask()
    {
        HideCreate = true;
        edit = true;
        create = false;
        TaskToCreate = new WebApp.Task();
    }
    #endregion

    #region EditTask
    private WebApp.Task selectedTask { get; set; } = new WebApp.Task();

    public void TaskClicked(int id)
    {
        changes = true;
        if (id == 0)
        {
            CreateMessage = "Save before editing newly created task";
        }
        else
        {
            this.TaskToCreate = o.Tasks.FirstOrDefault(t => t.ID == id);
            HideCreate = false;
            HideCreateButtons = true;
            edit = true;
        }
    }
    public void DeleteSelected()
    {
        changes = true;
        if (TaskToCreate.ID > 0)
        {
            TaskToCreate.Deleted = true;
            HideCreate = true;
            edit = false;
        }
    }
    #endregion

    #region SaveChanges()
    private async System.Threading.Tasks.Task SaveChanges()
    {
        //send changes to the api with the organisation as json
        HttpClient client = new HttpClient();

        HideCreate = true;

        //save changes foreach user
        var json = new StringContent(System.Text.Json.JsonSerializer.Serialize(o));
        Console.WriteLine(json);
        var result = await client.PutAsJsonAsync($"{configuration["API"]}api/Organisations/{o.ID}?transpondercode={loginstate.UserID}", o);
        Console.WriteLine(result);

        await Reload();
        changes = false;
    }
    #endregion

    private async System.Threading.Tasks.Task Reload()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(configuration["API"]);
        var response = await client.GetAsync($"api/Organisations/{loginstate.UserID}");
        Organisation temp = await response.Content.ReadFromJsonAsync<Organisation>();
        o = temp;
        changes = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginState loginstate { get; set; }
    }
}
#pragma warning restore 1591
