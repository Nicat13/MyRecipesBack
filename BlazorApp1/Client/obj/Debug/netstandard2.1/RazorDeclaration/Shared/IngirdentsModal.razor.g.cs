#pragma checksum "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Shared\IngirdentsModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b322a19c64da4a5eceb93888e2602f231edbf909"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Shared\IngirdentsModal.razor"
using BlazorApp1.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class IngirdentsModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Shared\IngirdentsModal.razor"
       
    public List<salam> users { get; set; } = new List<salam>();
    protected override async Task OnInitializedAsync()
    {
        users = await Http.GetFromJsonAsync<List<salam>>("api/User/users");
    }
    [Parameter]
    public ElementReference clickedelement { get; set; }
    protected bool ModalDisplay { get; set; }
    public salam user { get; set; } = new salam();
    public string id { get; set; }
    [Parameter]
    public EventCallback<string> ids { get; set; }
    public void Open()
    {
        id = (user.IconName);
        ModalDisplay = true;
        StateHasChanged();
    }


    protected void onconfirmationchanged(bool value)
    {
        if (value)
        {
            ids.InvokeAsync(id);
            jsRuntime.InvokeAsync<object>("ShowAlert", clickedelement,id);
        }
        ModalDisplay = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
