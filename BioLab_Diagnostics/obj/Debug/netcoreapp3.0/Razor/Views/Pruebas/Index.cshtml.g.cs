#pragma checksum "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e0b2460cd66f551db6b828bbc0e2052cf055756df05a5d517e6352b6123ea90d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pruebas_Index), @"mvc.1.0.view", @"/Views/Pruebas/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\_ViewImports.cshtml"
using BioLab_Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\_ViewImports.cshtml"
using BioLab_Diagnostics.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e0b2460cd66f551db6b828bbc0e2052cf055756df05a5d517e6352b6123ea90d", @"/Views/Pruebas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cb393e5efb3d1fb165c8b6e9411c6c608773264057cf8e7c7862d1a519770895", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pruebas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BioLab_Diagnostics.Models.Pruebas>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pruebas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
  
	ViewData["Title"] = "Pruebas";
	Layout = "~/Views/Shared/_LayoutDataTable.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-hover\" style=\"text-align: center;\" id=\"table_id_pruebas\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 12 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\tDepartamento\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 18 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 21 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\tValor de referencia\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 27 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Unidades));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th class=\"col-4\" style=\"width:5%;\">Opciones</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 33 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
         foreach (var item in Model)
		{
			if (item.EsActivo == true)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 39 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 42 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdDepartamentoNavigation.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 45 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 48 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n");
#nullable restore
#line 51 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                          
							var valoresReferencia = item.ValoresReferencia;
							if (valoresReferencia != null && valoresReferencia.Count > 0)
							{
								foreach (var v in valoresReferencia)
								{
									if (v.Sexo == null)
									{
										

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                                         Write(v.ValorReferencia);

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                                                                       
									}
									else
									{
										

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                                         Write(v.Sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 63 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                                                  Write(v.ValorReferencia);

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                                                                                
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<br />\r\n");
#nullable restore
#line 66 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
								}
							}
							else
							{
								

#line default
#line hidden
#nullable disable
            WriteLiteral("No hay valores de referencia");
#nullable restore
#line 70 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                                                                         
							}
						

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n");
#nullable restore
#line 75 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                         if(item.Unidades != null)
						{
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Unidades));

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                                                                        
						} else
						{
							

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 80 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                                          
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\r\n\t\t\t\t\t<td class=\"col-4\" style=\"width:5%;\">\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0b2460cd66f551db6b828bbc0e2052cf055756df05a5d517e6352b6123ea90d12724", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                                               WriteLiteral(item.IdPrueba);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t<a href=\"#\" class=\"pe-auto\" data-bs-toggle=\"modal\" data-bs-target=\"#exampleModal_");
#nullable restore
#line 87 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                                                                                                    Write(item.IdPrueba);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\t\t\t\t\t\t\t<i class=\"bi bi-x-square\"></i>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t<!-- Modal -->\r\n\t\t\t\t\t\t<div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2176, "\"", 2208, 2);
            WriteAttributeValue("", 2181, "exampleModal_", 2181, 13, true);
#nullable restore
#line 91 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
WriteAttributeValue("", 2194, item.IdPrueba, 2194, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2223, "\"", 2273, 2);
            WriteAttributeValue("", 2241, "exampleModalLabel_", 2241, 18, true);
#nullable restore
#line 91 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
WriteAttributeValue("", 2259, item.IdPrueba, 2259, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""true"">
							<div class=""modal-dialog"">
								<div class=""modal-content"">
									<div class=""modal-header "">
										<i class=""bi bi-exclamation-triangle"" style=""color:red; font-size:xxx-large; margin:0 auto;""></i>
										<button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close"" style=""margin-left:0; margin-bottom: 8%;""></button>
									</div>
									<div class=""modal-body"" style=""text-align: center; font-size:large;"">
										<span class=""fw-bold"">¿Está seguro de que desea eliminar la prueba <span style=""color:red;"">""");
#nullable restore
#line 99 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                                                                                                                                Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""</span>?</span><br>
										<span class=""fw-light"" style=""font-size:small;"">La prueba y sus datos asociados serán eliminados permanentemente</span><br>
									</div>
									<div class=""modal-footer"">
										<button type=""button"" class=""btn btn-light"" data-bs-dismiss=""modal"">Cancelar</button>
										");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0b2460cd66f551db6b828bbc0e2052cf055756df05a5d517e6352b6123ea90d17932", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-danger\">Eliminar</button>\r\n\t\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
                                                                                             WriteLiteral(item.IdPrueba);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 113 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\Pruebas\Index.cshtml"
			}
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
	<script type=""text/javascript"">
		$(document).ready(function () {
			$(""#table_id_pruebas"").DataTable({
				""language"": {
					""lengthMenu"": ""Mostrar _MENU_ registros"",
					""zeroRecords"": ""No se encontraron resultados"",
					""info"": ""Mostrando del _START_ al _END_ de un total de _TOTAL_ registros"",
					""infoEmpty"": ""Mostrando del 0 al 0 de un total de 0 registros"",
					""infoFiltered"": ""(filtrando de un total de _MAX_ registros)"",
					""sSearch"": ""Buscar:"",
					""oPaginate"": {
						""sFirst"": ""Primero"",
						""sLast"": ""Último"",
						""sNext"": ""Siguiente"",
						""sPrevious"": ""Anterior""
					},
					""sProcessing"": ""Procesando..."",
				}
			});
		});
	</script>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
	<style>
		#table_id_pruebas thead th {
			background-color: #e2e2e2;
			text-align: center;
		}
		.content-container.flex-column.flex-grow-1.p-3.rounded-bottom {
			overflow: hidden !important;
		}
		.row.dt-row {
			overflow-y: auto !important;
			scrollbar-width: thin;
			height: 60vh;
			max-height: 200vh;
			min-height: 50vh;
			margin-bottom: 1%;
		}
		#table_id_pruebas_info {
			width: max-content;
		}
	</style>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BioLab_Diagnostics.Models.Pruebas>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
