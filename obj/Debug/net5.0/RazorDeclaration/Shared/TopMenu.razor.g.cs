// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
