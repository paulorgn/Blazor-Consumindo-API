#pragma checksum "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\Pages\GridComDadosVindosDeAPI.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc00be03adb4bd7f15ba0b9aeb4d3ff74d93b697"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\Pages\GridComDadosVindosDeAPI.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/paulo")]
    public partial class GridComDadosVindosDeAPI : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Dados da tabela vieram de API REST</h1>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\Pages\GridComDadosVindosDeAPI.razor"
 if (dtoObjeto == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 10 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\Pages\GridComDadosVindosDeAPI.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Título</th>\r\n                <th>Descrição</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 22 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\Pages\GridComDadosVindosDeAPI.razor"
             foreach (var livro in dtoObjeto)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 25 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\Pages\GridComDadosVindosDeAPI.razor"
                         livro.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 26 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\Pages\GridComDadosVindosDeAPI.razor"
                         livro.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 27 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\Pages\GridComDadosVindosDeAPI.razor"
                         livro.body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 29 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\Pages\GridComDadosVindosDeAPI.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.AddMarkupContent(26, "    <br>\r\n");
            __builder.AddContent(27, "    ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\Pages\GridComDadosVindosDeAPI.razor"
                                              AcaoDoBotaoEmCSharp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "Voltar para o início");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.AddMarkupContent(33, "    <br>\r\n    <br>\r\n");
#nullable restore
#line 39 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\Pages\GridComDadosVindosDeAPI.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\PRGN-Pro\Documents\GitHub\Blazor\Blazor\Blazor\Pages\GridComDadosVindosDeAPI.razor"
       

    Livros livros = new Livros();
    public List<DtoObjetoExemplo> dtoObjeto = new List<DtoObjetoExemplo>();

    public void ConsultarLivros()
    {
        dtoObjeto = livros.PegarRetornoDaAPI();
    }

    protected override async Task OnInitializedAsync()
    {
        ConsultarLivros();
    }

    public void AcaoDoBotaoEmCSharp()
    {
        NavigationManager.NavigateTo("inicio");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
