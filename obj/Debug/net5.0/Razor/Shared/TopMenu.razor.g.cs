#pragma checksum "D:\Repositorios\CNV2\Shared\TopMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0647f4f842d651bf69819ec40b31990b552ea3db"
// <auto-generated/>
#pragma warning disable 1591
namespace CNV2.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Repositorios\CNV2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repositorios\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repositorios\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repositorios\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repositorios\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repositorios\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repositorios\CNV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repositorios\CNV2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repositorios\CNV2\_Imports.razor"
using CNV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Repositorios\CNV2\_Imports.razor"
using CNV2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Repositorios\CNV2\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class TopMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudAppBar>(0);
            __builder.AddAttribute(1, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 1 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                      1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Style", "");
            __builder.AddAttribute(3, "Fixed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudIconButton>(5);
                __builder2.AddAttribute(6, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                          Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 2 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                                                             Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 2 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                                                                                  Edge.Start

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                   (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(11);
                __builder2.AddAttribute(12, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                         6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                                4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "align-start", true);
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudAutocomplete<string>>(17);
                    __builder3.AddAttribute(18, "SearchFunc", new System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>>>(
#nullable restore
#line 7 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                                                                      MainSearch

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ResetValueOnEmptyText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                                    resetValueOnEmptyText

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "CoerceText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                                                                        coerceText

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "CoerceValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                                                                                                  coerceValue

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "FullWidth", true);
                    __builder3.AddAttribute(23, "Placeholder", "Pesquisar clientes/projetos");
                    __builder3.AddAttribute(24, "style", "margin-bottom: 15px;");
                    __builder3.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 7 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                                                 value1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => value1 = __value, value1))));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudAppBarSpacer>(28);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenComponent<CNV2.Shared.LoginDisplay>(30);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.AddMarkupContent(32, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudDrawer>(34);
            __builder.AddAttribute(35, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                                               2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                       _drawerOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudDrawerHeader>(39);
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(41);
                    __builder3.AddAttribute(42, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 20 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
                       Typo.h5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "Class", "mt-1");
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(45, "ADN | Projetos");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n    ");
                __builder2.OpenComponent<CNV2.Shared.NavMenu>(47);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "D:\Repositorios\CNV2\Shared\TopMenu.razor"
       
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }
    private bool resetValueOnEmptyText = false;
    private bool coerceText = false;
    private bool coerceValue = false;
    private string value1;
    private string[] states =
    {
"Mil Possibilidades | SI Inovação | 22769",
"Luís Leal & Filhos | SI Inovação | 22759"
};


    private async Task<IEnumerable<string>> MainSearch(string value)
    {
        // In real life use an asynchronous function for fetching data from an api.
        await Task.Delay(5);

        // if text is null or empty, don't return values (drop-down will not open)
        if (string.IsNullOrEmpty(value))
            return new string[0];
        return states.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591