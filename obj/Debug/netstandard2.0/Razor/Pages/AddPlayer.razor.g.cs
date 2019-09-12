#pragma checksum "D:\corePractise\Blazor.CRUD.Sample\Pages\AddPlayer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af28b339a692db3591a8b4c2793863f4bb25b8d8"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h4>Create Player</h4>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddAttribute(2, "class", "justify-content-center");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<label for=\"txtFirstName\" class=\"col-sm-2 col-form-label\">FirstName</label>\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-sm-8");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "id", "txtFirstName");
            __builder.AddAttribute(15, "placeholder", "First Name");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 10 "D:\corePractise\Blazor.CRUD.Sample\Pages\AddPlayer.razor"
                                                                              player.FirstName

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => player.FirstName = __value, player.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group row");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<label for=\"txtLastName\" class=\"col-sm-2 col-form-label\">LastName</label>\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-sm-8");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "text");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "id", "txtLastName");
            __builder.AddAttribute(32, "placeholder", "Last Name");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 16 "D:\corePractise\Blazor.CRUD.Sample\Pages\AddPlayer.razor"
                                                                                                     player.LastName

#line default
#line hidden
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => player.LastName = __value, player.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group row");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.AddMarkupContent(41, "<label for=\"txtCurrentAge\" class=\"col-sm-2 col-form-label\">Current Age</label>\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-sm-8");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "id", "txtCurrentAge");
            __builder.AddAttribute(49, "placeholder", "Current age");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 22 "D:\corePractise\Blazor.CRUD.Sample\Pages\AddPlayer.razor"
                                                                                                         player.CurrentAge

#line default
#line hidden
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => player.CurrentAge = __value, player.CurrentAge));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group row");
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.AddMarkupContent(58, "<label for=\"txtTeams\" class=\"col-sm-2 col-form-lable\">Major Teams</label>\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-sm-8");
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "type", "text");
            __builder.AddAttribute(64, "class", "form-control");
            __builder.AddAttribute(65, "id", "txtTeams");
            __builder.AddAttribute(66, "placeholder", "Major Teams");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 28 "D:\corePractise\Blazor.CRUD.Sample\Pages\AddPlayer.razor"
                                                                                                    player.Teams

#line default
#line hidden
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => player.Teams = __value, player.Teams));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "form-group row");
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.AddMarkupContent(75, "<label for=\"txtPlayingRole\" class=\"col-sm-2 col-form-label\">Playing Role</label>\r\n        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col-sm-8");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "type", "text");
            __builder.AddAttribute(81, "class", "form-control");
            __builder.AddAttribute(82, "id", "txtPlayingRole");
            __builder.AddAttribute(83, "placeholder", "Playing Role");
            __builder.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 34 "D:\corePractise\Blazor.CRUD.Sample\Pages\AddPlayer.razor"
                                                                                                           player.PlayingRole

#line default
#line hidden
            ));
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => player.PlayingRole = __value, player.PlayingRole));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "form-group row");
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.AddMarkupContent(92, "<label for=\"txtBattingStyle\" class=\"col-sm-2 col-form-label\">Batting Style</label>\r\n        ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "col-sm-8");
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.OpenElement(96, "input");
            __builder.AddAttribute(97, "type", "text");
            __builder.AddAttribute(98, "class", "form-control");
            __builder.AddAttribute(99, "id", "txtBattingStyle");
            __builder.AddAttribute(100, "placeholder", "Batting Style");
            __builder.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 40 "D:\corePractise\Blazor.CRUD.Sample\Pages\AddPlayer.razor"
                                                                                                             player.BattingStyle

#line default
#line hidden
            ));
            __builder.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => player.BattingStyle = __value, player.BattingStyle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n    ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "form-group row");
            __builder.AddMarkupContent(108, "\r\n        ");
            __builder.AddMarkupContent(109, "<label for=\"txtBowlingStyle\" class=\"col-sm-2 col-form-label\">Bowling Style</label>\r\n        ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "col-sm-8");
            __builder.AddMarkupContent(112, "\r\n            ");
            __builder.OpenElement(113, "input");
            __builder.AddAttribute(114, "type", "text");
            __builder.AddAttribute(115, "class", "form-control");
            __builder.AddAttribute(116, "id", "txtBowlingStyle");
            __builder.AddAttribute(117, "placeholder", "Bowling Style");
            __builder.AddAttribute(118, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 46 "D:\corePractise\Blazor.CRUD.Sample\Pages\AddPlayer.razor"
                                                                                                             player.BowlingStyle

#line default
#line hidden
            ));
            __builder.AddAttribute(119, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => player.BowlingStyle = __value, player.BowlingStyle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n    ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "form-group row");
            __builder.AddMarkupContent(125, "\r\n        ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "col-sm-8");
            __builder.AddMarkupContent(128, "\r\n            ");
            __builder.OpenElement(129, "button");
            __builder.AddAttribute(130, "type", "button");
            __builder.AddAttribute(131, "class", "btn btn-primary");
            __builder.AddAttribute(132, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 51 "D:\corePractise\Blazor.CRUD.Sample\Pages\AddPlayer.razor"
                                                                    Add

#line default
#line hidden
            ));
            __builder.AddContent(133, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n");
            __builder.CloseElement();
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
