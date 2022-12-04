#pragma checksum "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\Pages\Conversoes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "745af2f7d179faae2ad1083f1938cbefaf436fa7"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Conversões</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"card-header text-center\">\r\n        Calculadora de Caminhada\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<div class=\"text-white bg-info text-center border rounded\">\r\n            Tempo de percurso\r\n        </div>\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "p-3");
            __builder.AddMarkupContent(11, "\r\n            Hora da Saída:");
            __builder.AddContent(12, 
#nullable restore
#line 15 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\Pages\Conversoes.razor"
                           horaSaida

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, " h <br>\r\n            Distância percorrida: ");
            __builder.AddContent(14, 
#nullable restore
#line 16 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\Pages\Conversoes.razor"
                                   distanciaKm

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, " km <br>\r\n            Tempo no percurso: ");
            __builder.AddContent(16, 
#nullable restore
#line 17 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\Pages\Conversoes.razor"
                                horaAndada

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, " h <br>\r\n            Hora da chegada: ");
            __builder.AddContent(18, 
#nullable restore
#line 18 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\Pages\Conversoes.razor"
                              horaChegada

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, " h <br> \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "text-center");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-outline-primary");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Rodrigo\Documents\GitHub\LivroCSharp\LivroCSharp\Pages\Conversoes.razor"
                                                              CalcularPercurso

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Calcular");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
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
