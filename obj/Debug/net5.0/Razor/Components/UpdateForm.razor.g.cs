#pragma checksum "D:\Program Files\VS Community Workspace\WebAppService\Components\UpdateForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68967e9575113fd5fff5d760d70da40050dcb034"
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
#line 1 "D:\Program Files\VS Community Workspace\WebAppService\Components\UpdateForm.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Program Files\VS Community Workspace\WebAppService\Components\UpdateForm.razor"
using WebAppService.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Program Files\VS Community Workspace\WebAppService\Components\UpdateForm.razor"
using WebAppService.Services;

#line default
#line hidden
#nullable disable
    public partial class UpdateForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Update User Details</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div><form action=""/users/update""><label>User ID:</label>
        <input type=""text"" id=""userId"" name=""userId"" required>

        <label>Name:</label>
        <input type=""text"" id=""userName"" name=""userName"">

        <label>Email:</label>
        <input type=""text"" id=""userEmail"" name=""userEmail"">

        <label>Telephone:</label>
        <input type=""text"" id=""userTelephone"" name=""userTelephone"">

        <input type=""submit"" value=""Update User""></form></div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileUserService UserService { get; set; }
    }
}
#pragma warning restore 1591
