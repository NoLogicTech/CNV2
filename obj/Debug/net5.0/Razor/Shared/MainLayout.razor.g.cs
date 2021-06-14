#pragma checksum "D:\Repositorios\CNV2\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3029668f5a368ede01406f88d64ca5393da701f4"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 3 "D:\Repositorios\CNV2\Shared\MainLayout.razor"
                         DarkMode

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(7);
            __builder.AddAttribute(8, "mud-theme-primary", true);
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<CNV2.Shared.TopMenu>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "content px-4");
                    __builder3.AddAttribute(16, "style", "padding-top: 4px;");
                    __builder3.AddAttribute(17, "b-dxol7w59hk");
                    __builder3.AddContent(18, 
#nullable restore
#line 13 "D:\Repositorios\CNV2\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\Repositorios\CNV2\Shared\MainLayout.razor"
       
    MudTheme ADN = new MudTheme()
    {
        Palette = new Palette()
        {
            Primary = "#2878f7",
            AppbarBackground = "#FFFFFF",
        },

        Typography = new Typography()
        {
            Default = new Default()
            {
                FontFamily = new[] { "Montserrat", "Roboto", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 400,
                LineHeight = 1.43,
                LetterSpacing = ".01071em"
            }
        }

    };

    MudTheme DarkMode = new MudTheme()
    {
        Palette = new Palette()
        {
            Black = "#27272f",
            Background = "#32333d",
            BackgroundGrey = "#27272f",
            Surface = "#373740",
            DrawerBackground = "#27272f",
            DrawerText = "rgba(255,255,255, 0.50)",
            DrawerIcon = "rgba(255,255,255, 0.50)",
            AppbarBackground = "#27272f",
            AppbarText = "rgba(255,255,255, 0.10)",
            TextPrimary = "#FFFFFF",
            TextSecondary = "rgba(255,255,255, 0.50)",
            ActionDefault = "#adadb1",
            ActionDisabled = "rgba(255,255,255, 0.26)",
            ActionDisabledBackground = "rgba(255,255,255, 0.12)",
            Divider = "rgba(255,255,255, 0.12)",
            DividerLight = "rgba(255,255,255, 0.06)",
            TableLines = "rgba(255,255,255, 0.12)",
            LinesDefault = "rgba(255,255,255, 0.12)",
            LinesInputs = "rgba(255,255,255, 0.3)",
            TextDisabled = "rgba(255,255,255, 0.2)",
            Primary = "#2878f7"
        },

        Typography = new Typography()
        {
            Default = new Default()
            {
                FontFamily = new[] { "Montserrat", "Roboto", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 400,
                LineHeight = 1.43,
                LetterSpacing = ".01071em"
            }
        }



    };



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
