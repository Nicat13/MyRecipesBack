#pragma checksum "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d36c6b81562a99ab7d06ba6150d297d2d793726"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "td");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
         user.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 8 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
         user.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 9 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
         user.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "td");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
                          () =>editModal.Open()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "style", "color:white;");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "class", "btn btn-warning");
            __builder.AddAttribute(18, "data-toggle", "modal");
            __builder.AddMarkupContent(19, "\r\n            Edit\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
                          () =>Modal.Open()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "btn btn-danger");
            __builder.AddAttribute(28, "data-toggle", "modal");
            __builder.AddAttribute(29, "data-target", "#exampleModal");
            __builder.AddMarkupContent(30, "\r\n            Delete\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n");
            __builder.OpenComponent<BlazorApp1.Client.Shared.Modal>(34);
            __builder.AddAttribute(35, "Onconfirmation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 22 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
                                    Test

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(36, "user", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp1.Shared.Models.salam>(
#nullable restore
#line 22 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
                                                user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(37, (__value) => {
#nullable restore
#line 22 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
             Modal = (BlazorApp1.Client.Shared.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.OpenComponent<BlazorApp1.Client.Shared.EditModal>(39);
            __builder.AddAttribute(40, "Onconfirmation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 23 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
                                            edittest

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(41, "users", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp1.Shared.Models.salam>(
#nullable restore
#line 23 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
                                                             user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(42, (__value) => {
#nullable restore
#line 23 "C:\Users\User\Desktop\Temporary_Files\BlazorApp1\BlazorApp1\Client\Pages\UserTable.razor"
                 editModal = (BlazorApp1.Client.Shared.EditModal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
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
