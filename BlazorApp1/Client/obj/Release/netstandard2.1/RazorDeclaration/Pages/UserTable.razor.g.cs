#pragma checksum "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d36c6b81562a99ab7d06ba6150d297d2d793726"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Client.Pages
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
#line 1 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
using BlazorApp1.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class UserTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
       
    [Parameter]
    public salam user { get; set; }

    public BlazorApp1.Client.Shared.Modal Modal { get; set; }
    public BlazorApp1.Client.Shared.EditModal editModal { get; set; }

    [Parameter]
    public EventCallback<bool> Onconfirmation { get; set; }


    protected async void Test(bool checker)
    {
        if (checker == true)
        {
            await Http.PostAsJsonAsync("/api/User/delete", user);
        }
        await Onconfirmation.InvokeAsync(checker);
    }

    protected async void edittest(bool checker)
    {
        if (checker == true)
        {
            await Http.PutAsJsonAsync("/api/User/edit", user);
        }
        await Onconfirmation.InvokeAsync(checker);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
