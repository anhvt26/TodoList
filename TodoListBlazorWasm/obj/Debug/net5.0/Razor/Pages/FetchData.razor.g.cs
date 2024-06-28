#pragma checksum "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "65928d3b6aa0584c786711adf3645aa96e47d3f4d5189e2397c3725f1df56ff5"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoListBlazorWasm.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line 3 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 4 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 5 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 6 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 7 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http

#nullable disable
    ;
#nullable restore
#line 8 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using TodoListBlazorWasm

#nullable disable
    ;
#nullable restore
#line 10 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using TodoListBlazorWasm.Shared

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
      "/fetchdata"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>");
#nullable restore
#line 8 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable

            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable

            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 24 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 27 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 28 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 29 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 2 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
        HttpClient

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "C:\TEDU\Blazor\TodoListBlazorWasm\TodoListBlazorWasm\Pages\FetchData.razor"
                   Http

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
