// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LivroCSharp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\_Imports.razor"
using LivroCSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\_Imports.razor"
using LivroCSharp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/conversoes")]
    public partial class Conversoes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\Pages\Conversoes.razor"
       
    int horaSaida = 10;
    int horaChegada;
    int horaAndada;
    double distanciaKm = 9;
    double kmPorHora = 4.5;

    void CalcularPercurso() 
    {
        horaAndada = (int)(distanciaKm / kmPorHora);
        horaChegada = horaSaida + horaAndada;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
