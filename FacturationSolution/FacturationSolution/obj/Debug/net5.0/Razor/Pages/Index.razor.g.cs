#pragma checksum "C:\Users\mondo\RiderProjects\FacturationSolution\FacturationSolution\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71cd1037c8475b04194cd38fe6fa2b5d4631c167"
// <auto-generated/>
#pragma warning disable 1591
namespace FacturationSolution.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mondo\RiderProjects\FacturationSolution\FacturationSolution\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mondo\RiderProjects\FacturationSolution\FacturationSolution\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mondo\RiderProjects\FacturationSolution\FacturationSolution\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mondo\RiderProjects\FacturationSolution\FacturationSolution\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mondo\RiderProjects\FacturationSolution\FacturationSolution\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mondo\RiderProjects\FacturationSolution\FacturationSolution\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mondo\RiderProjects\FacturationSolution\FacturationSolution\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mondo\RiderProjects\FacturationSolution\FacturationSolution\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mondo\RiderProjects\FacturationSolution\FacturationSolution\_Imports.razor"
using FacturationSolution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mondo\RiderProjects\FacturationSolution\FacturationSolution\_Imports.razor"
using FacturationSolution.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<h1>Bienvenue dans votre espace!</h1>

Bienvenue sur votre espace de facturation, dans la catégorie Factures vous retrouverez les infos sur les dernières factures en fonctions des entreprises client!
Dans la catégorie CA vous retrouverez une estimation du chiffre d'affaire réelle et supposé !

");
            __builder.OpenComponent<FacturationSolution.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
