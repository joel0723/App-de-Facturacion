#pragma checksum "C:\Users\lenovo x1 carbon\Videos\proyecto\Views\Localizar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "710d2035c1b871cab643395865bb0eaef1a53d30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Localizar_Index), @"mvc.1.0.view", @"/Views/Localizar/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\lenovo x1 carbon\Videos\proyecto\Views\_ViewImports.cshtml"
using proyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo x1 carbon\Videos\proyecto\Views\_ViewImports.cshtml"
using proyecto.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo x1 carbon\Videos\proyecto\Views\Localizar\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"710d2035c1b871cab643395865bb0eaef1a53d30", @"/Views/Localizar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c408a981cda364cb3b7366a3e1aa09923cb88b9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Localizar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<proyecto.Models.Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\lenovo x1 carbon\Videos\proyecto\Views\Localizar\Index.cshtml"
   ViewData["Title"] = "Index";
                Layout = "~/Views/Shared/_Layout.cshtml";


                var db = new ClienteContext();
                var json = JsonConvert.SerializeObject(db.Clientes.ToList());
                var jsoni = JsonConvert.SerializeObject(db.Clientes.ToList(), Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            ); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.7.1/dist/leaflet.css"" />
<script src=""https://unpkg.com/leaflet@1.7.1/dist/leaflet.js""></script>
<style type=""text/css"">
    #map {
        height: 80vh;
        width: 180vh;
    }
</style>

<div id=""map"">


</div>
<script>


    const para = {

        center: [18.66, -69.80],
        zoom: 10


    }


    let map = L.map('map', para)
    let tileLayer = L.tileLayer('http://a.tile.openstreetmap.fr/hot/{z}/{x}/{y}.png')
    map.addLayer(tileLayer)

    map.addLayer(tileLayer)
        var data= ");
#nullable restore
#line 46 "C:\Users\lenovo x1 carbon\Videos\proyecto\Views\Localizar\Index.cshtml"
             Write(Html.Raw(json));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n        var datai= ");
#nullable restore
#line 47 "C:\Users\lenovo x1 carbon\Videos\proyecto\Views\Localizar\Index.cshtml"
              Write(Html.Raw(jsoni));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        for(let i of data){



            L.marker([i.Lat, i.Long]).addTo(map)
                .bindPopup('<strong>Nombre: </strong>' + i.Nombre + '<br><strong>Rnc: </strong>' + i.Rnc + '<br><strong>Latitud:</strong> ' + i.Lat + '<br><strong>Longitud:</strong> '
                + i.Long + '<br><strong>Telefono: </strong>' + i.Telefono)
                         .openPopup();


        }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<proyecto.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591