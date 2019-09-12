#pragma checksum "D:\corePractise\Blazor.CRUD.Sample\Pages\AddPlayer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af28b339a692db3591a8b4c2793863f4bb25b8d8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.CRUD.Sample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\corePractise\Blazor.CRUD.Sample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\corePractise\Blazor.CRUD.Sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\corePractise\Blazor.CRUD.Sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\corePractise\Blazor.CRUD.Sample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\corePractise\Blazor.CRUD.Sample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\corePractise\Blazor.CRUD.Sample\_Imports.razor"
using Blazor.CRUD.Sample;

#line default
#line hidden
#line 7 "D:\corePractise\Blazor.CRUD.Sample\_Imports.razor"
using Blazor.CRUD.Sample.Shared;

#line default
#line hidden
#line 8 "D:\corePractise\Blazor.CRUD.Sample\_Imports.razor"
using Blazor.CRUD.Sample.Models;

#line default
#line hidden
#line 9 "D:\corePractise\Blazor.CRUD.Sample\_Imports.razor"
using Blazor.CRUD.Sample.Logics;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/player/add")]
    public class AddPlayer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 57 "D:\corePractise\Blazor.CRUD.Sample\Pages\AddPlayer.razor"
 
    private Player player = new Player();

    public async Task  Add()
    {
        await _playerLogic.CreatePlayer(player);
        _navigationManager.NavigateTo("players");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPlayersLogic _playerLogic { get; set; }
    }
}
#pragma warning restore 1591