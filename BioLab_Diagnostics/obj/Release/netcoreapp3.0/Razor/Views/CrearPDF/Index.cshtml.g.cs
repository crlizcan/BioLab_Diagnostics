#pragma checksum "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43f2dd7a14f0ec004ebfbcb377943bbe10486f0215725507d52a00f1a00de31a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrearPDF_Index), @"mvc.1.0.view", @"/Views/CrearPDF/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"43f2dd7a14f0ec004ebfbcb377943bbe10486f0215725507d52a00f1a00de31a", @"/Views/CrearPDF/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cb393e5efb3d1fb165c8b6e9411c6c608773264057cf8e7c7862d1a519770895", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CrearPDF_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BioLab_Diagnostics.Models.PeticionesPruebas>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Logo-favicon-c.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Laboratorio Clinico BioLab Diagnostics"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
  
	Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"es\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43f2dd7a14f0ec004ebfbcb377943bbe10486f0215725507d52a00f1a00de31a5363", async() => {
                WriteLiteral(@"
	<meta charset=""UTF-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
	<title>Informe de Resultados - Laboratorio Clínico</title>
	<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.5.0/dist/css/bootstrap.min.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43f2dd7a14f0ec004ebfbcb377943bbe10486f0215725507d52a00f1a00de31a6626", async() => {
                WriteLiteral("\r\n\t<div class=\"container mt-5\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-md-12 text-center mw-100\">\r\n\t\t\t\t<div style=\"display: inline-block;\">\r\n\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "43f2dd7a14f0ec004ebfbcb377943bbe10486f0215725507d52a00f1a00de31a7085", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
				</div>
				<div style=""display: inline-block; vertical-align: top; margin-left: 20px;"">
					<p>
						<h1>Laboratorio Clínico BioLab Diagnostics</h1>
					</p>
					Dirección: Av. del Botánico 85, Madrid<br />
					Teléfono: (+34) 683-786-962<br />
				</div>
			</div>
		</div>
		<div class=""row mt-4"">
			<div class=""col-md-12"">
				<h2>Informe de Resultados</h2>
				<table class=""table-light"">
					<thead>
						<tr class=""text-decoration-underline mw-100"">
							<th>Prueba</th>
							<th>Resultado</th>
							<th>Valor de Referencia</th>
							<th>Unidades</th>
						</tr>
					</thead>
					<tbody class=""mw-100"">
");
#nullable restore
#line 44 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                         foreach (var item in Model)
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 48 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.IdPruebaNavigation.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t<td>\r\n");
#nullable restore
#line 51 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                      
										var valorReferencia = "";
										foreach (var i in item.IdPruebaNavigation.ValoresReferencia)
										{
											//Si no depende del sexo, guardo el valor de referencia para mostrarlo
											if (i.Sexo == null)
											{
												valorReferencia = i.ValorReferencia;
											}
											else
											{
												//Si depende del sexo, guardo el valor de referencia correspondiente al sexo del paciente
												if (i.Sexo.Equals(item.IdPeticionNavigation.DniClienteNavigation.Sexo))
												{
													valorReferencia = i.ValorReferencia;
												}
											}
										}
										if (valorReferencia.Contains("-"))
										{
											var intervalo = valorReferencia.Split("-");
											//Valor fuera del intervalo de referencia
											if (Convert.ToDouble(item.Resultado) < Convert.ToDouble(intervalo[0]) || Convert.ToDouble(item.Resultado) > Convert.ToDouble(intervalo[1]))
											{
												

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:red;\">");
#nullable restore
#line 75 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                          Write(item.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 75 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                            
											}
											else
											{
												

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:forestgreen;\">");
#nullable restore
#line 79 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                  Write(item.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 79 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                                    
											}
										}
										else if (valorReferencia.Contains("<") && !valorReferencia.Contains("="))
										{
											valorReferencia = valorReferencia.Replace("<", "");
											if (Convert.ToDouble(item.Resultado) >= Convert.ToDouble(valorReferencia))
											{
												

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:red;\">");
#nullable restore
#line 87 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                          Write(item.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 87 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                            
											}
											else
											{
												

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:forestgreen;\">");
#nullable restore
#line 91 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                  Write(item.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 91 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                                    
											}
										}
										else if (valorReferencia.Contains("<="))
										{
											valorReferencia = valorReferencia.Replace("<=", "");
											if (Convert.ToDouble(item.Resultado) > Convert.ToDouble(valorReferencia))
											{
												

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:red;\">");
#nullable restore
#line 99 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                          Write(item.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 99 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                            
											}
											else
											{
												

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:forestgreen;\">");
#nullable restore
#line 103 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                  Write(item.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 103 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                                    
											}
										}
										else if (valorReferencia.Contains(">") && !valorReferencia.Contains("="))
										{
											valorReferencia = valorReferencia.Replace(">", "");
											if (Convert.ToDouble(item.Resultado) <= Convert.ToDouble(valorReferencia))
											{
												

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:red;\">");
#nullable restore
#line 111 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                          Write(item.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 111 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                            
											}
											else
											{
												

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:forestgreen;\">");
#nullable restore
#line 115 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                  Write(item.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 115 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                                    
											}
										}
										else if (valorReferencia.Contains(">="))
										{
											valorReferencia = valorReferencia.Replace(">=", "");
											if (Convert.ToDouble(item.Resultado) < Convert.ToDouble(valorReferencia))
											{
												

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:red;\">");
#nullable restore
#line 123 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                          Write(item.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 123 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                            
											}
											else
											{
												

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:forestgreen;\">");
#nullable restore
#line 127 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                  Write(item.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 127 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                                    
											}
										}
										else
										{
											//Compruebo si el valor de referencia es un string o un valor numérico
											if (Regex.IsMatch(valorReferencia, @"\w*") == true)
											{
												if (!item.Resultado.ToUpper().Equals(valorReferencia.ToUpper()))
												{
													

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:red;\">");
#nullable restore
#line 137 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                              Write(item.Resultado.ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 137 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                                          
												}
												else
												{
													

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:forestgreen;\">");
#nullable restore
#line 141 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                      Write(item.Resultado.ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 141 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                                                  
												}
											}
											else
											{
												if (Convert.ToDouble(item.Resultado) != Convert.ToDouble(valorReferencia))
												{
													

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:red;\">");
#nullable restore
#line 148 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                              Write(item.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 148 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                                
												}
												else
												{
													

#line default
#line hidden
#nullable disable
                WriteLiteral("<span style=\"color:forestgreen;\">");
#nullable restore
#line 152 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                      Write(item.Resultado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
#nullable restore
#line 152 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                                                        
												}
											}
										}
									

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t<td>\r\n");
#nullable restore
#line 159 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                      
										foreach (var i in item.IdPruebaNavigation.ValoresReferencia)
										{
											if (i.Sexo == null)
											{
												

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                 Write(i.ValorReferencia);

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                               
											}
											else
											{
												if (i.Sexo.Equals(item.IdPeticionNavigation.DniClienteNavigation.Sexo))
												{
													

#line default
#line hidden
#nullable disable
#nullable restore
#line 170 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                     Write(i.ValorReferencia);

#line default
#line hidden
#nullable disable
#nullable restore
#line 170 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                                                                                   
												}
											}
										}
									

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 177 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.IdPruebaNavigation.Unidades));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 180 "C:\Users\crist\OneDrive\Escritorio\Proyectos ASP.NET Core\BioLab_Diagnostics\BioLab_Diagnostics\Views\CrearPDF\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t</tbody>\r\n\t\t\t\t</table>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.5.0/dist/js/bootstrap.bundle.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BioLab_Diagnostics.Models.PeticionesPruebas>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
