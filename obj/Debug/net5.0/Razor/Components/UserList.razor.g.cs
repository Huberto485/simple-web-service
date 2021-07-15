#pragma checksum "D:\Program Files\VS Community Workspace\WebAppService\Components\UserList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc1ea901da8abc67343a869a85b91bff5e5cc866"
// <auto-generated/>
#pragma warning disable 1591
namespace WebAppService.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Program Files\VS Community Workspace\WebAppService\Components\UserList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Program Files\VS Community Workspace\WebAppService\Components\UserList.razor"
using WebAppService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Program Files\VS Community Workspace\WebAppService\Components\UserList.razor"
using WebAppService.Services;

#line default
#line hidden
#nullable disable
    public partial class UserList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>User List</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "table");
            __builder.AddMarkupContent(3, "<tr><th>User ID</th>\r\n            <th>User Name</th>\r\n            <th>User Email</th>\r\n            <th>User Telephone</th></tr>");
#nullable restore
#line 17 "D:\Program Files\VS Community Workspace\WebAppService\Components\UserList.razor"
         foreach (var user in UserService.GetUsers())
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 20 "D:\Program Files\VS Community Workspace\WebAppService\Components\UserList.razor"
                     user.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 21 "D:\Program Files\VS Community Workspace\WebAppService\Components\UserList.razor"
                     user.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 22 "D:\Program Files\VS Community Workspace\WebAppService\Components\UserList.razor"
                     user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 23 "D:\Program Files\VS Community Workspace\WebAppService\Components\UserList.razor"
                     user.Telephone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "D:\Program Files\VS Community Workspace\WebAppService\Components\UserList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileUserService UserService { get; set; }
    }
}
#pragma warning restore 1591