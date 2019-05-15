#pragma checksum "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53788b36ae5e129d36969d9d1ad0b7ce52ba59f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Find), @"mvc.1.0.view", @"/Views/Home/Find.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Find.cshtml", typeof(AspNetCore.Views_Home_Find))]
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
#line 1 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\_ViewImports.cshtml"
using Forum;

#line default
#line hidden
#line 2 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\_ViewImports.cshtml"
using Forum.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53788b36ae5e129d36969d9d1ad0b7ce52ba59f2", @"/Views/Home/Find.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac609fd15eba99a48942b04c8579a10a24406fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Find : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Forum.Models.FindVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Redireccionador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
  
    ViewData["Title"] = "Find";

#line default
#line hidden
            BeginContext(68, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(76, 2421, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92df4cb67dad44d2a8cb98e9f678ee80", async() => {
                BeginContext(125, 2365, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-12 col-md-10 col-lg-8"">
                <div class=""card card-sm"">
                    <div class=""card-body row no-gutters align-items-center"">
                        <div class=""col-auto"">
                            <i class=""fas fa-search h4 text-body""></i>
                        </div>
                        <div class=""col"">
                            <input class=""form-control form-control-lg form-control-borderless"" type=""search"" placeholder=""Search name"" name=""searchValue"">
                        </div>
                        <div class=""col-auto ml-3"">
                            <input class=""btn btn-lg btn-danger"" type=""submit"" value=""Search"" />
                        </div>
                    </div>
                </div>
            </div>
            <!--end of col-->
        </div>
        <div class=""row justify-content-center mt-3"">
            <div class=""ca");
                WriteLiteral(@"rd card-sm"">
                <div class=""card-body row no-gutters align-items-center"">
                    <div class=""form-check mx-5"">
                        <input class=""form-check-input"" type=""radio"" name=""radioValue"" id=""radioCharacter"" value=""character"" checked>
                        <label class=""form-check-label"" for=""radioCharacter"">Character</label>
                    </div>
                    <div class=""form-check mx-5"">
                        <input class=""form-check-input"" type=""radio"" name=""radioValue"" id=""radioComic"" value=""comic"">
                        <label class=""form-check-label"" for=""radioComic"">Comic</label>
                    </div>
                    <div class=""form-check mx-5"">
                        <input class=""form-check-input"" type=""radio"" name=""radioValue"" id=""radioCreator"" value=""creator"">
                        <label class=""form-check-label"" for=""radioCreator"">Creator</label>
                    </div>
                    <div class=""form-check mx");
                WriteLiteral(@"-5"">
                        <input class=""form-check-input"" type=""radio"" name=""radioValue"" id=""radioSeries"" value=""series"">
                        <label class=""form-check-label"" for=""radioSeries"">Series</label>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2497, 30, true);
            WriteLiteral("\r\n\r\n<br />\r\n<hr />\r\n<br />\r\n\r\n");
            EndContext();
#line 55 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
     if (Model.Characters.Count() <= 0)
    {

#line default
#line hidden
            BeginContext(2575, 458, true);
            WriteLiteral(@"        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-12 col-md-6""><h1>Character</h1></div>
                <div class=""col-sm-12 col-md-6""><h1>Comic</h1></div>
            </div>
            <hr />
            <div class=""row"">
                <div class=""col-sm-12 col-md-6""><h1>Creator</h1></div>
                <div class=""col-sm-12 col-md-6""><h1>Series</h1></div>
            </div>
        </div>
");
            EndContext();
#line 68 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(3057, 324, true);
            WriteLiteral(@"            <div class=""container"">
                <div class=""row"">
                    <div class=""col-sm-12 col-md-6"">
                        <h2>CHARACTERS</h2>
                    </div>
                    <div class=""col-sm-12 col-md-6"">
                        <h2>COMICS</h2>
                    </div>

");
            EndContext();
#line 80 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                     for (var i = 0; i < Model.Characters.Count(); i++)
                    {

                        var imageCharacter = Model.Characters.ElementAt(i).Thumbnail.Path + "/portrait_medium." + Model.Characters.ElementAt(i).Thumbnail.Extension;
                        var descriptionCharacter = Model.Characters.ElementAt(i).Description.Length > 100 ? Model.Characters.ElementAt(i).Description.Substring(0,100) : Model.Characters.ElementAt(i).Description;


#line default
#line hidden
            BeginContext(3860, 224, true);
            WriteLiteral("                        <div class=\"col-sm-12 col-md-6 my-2\">\r\n                            <div class=\"border rounded d-flex\">\r\n                                <div class=\"col-md-3\">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4084, "\"", 4105, 1);
#line 89 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
WriteAttributeValue("", 4090, imageCharacter, 4090, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4106, 184, true);
            WriteLiteral(" class=\"img-thumbnail\" alt=\"...\">\r\n                                </div>\r\n                                <div class=\"col-md-9 p-2\">\r\n                                    <h6 class=\"\">");
            EndContext();
            BeginContext(4291, 34, false);
#line 92 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                                            Write(Model.Characters.ElementAt(i).Name);

#line default
#line hidden
            EndContext();
            BeginContext(4325, 60, true);
            WriteLiteral("</h6>\r\n                                    <p class=\"small\">");
            EndContext();
            BeginContext(4386, 20, false);
#line 93 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                                                Write(descriptionCharacter);

#line default
#line hidden
            EndContext();
            BeginContext(4406, 85, true);
            WriteLiteral("</p>\r\n                                    <p class=\"small\"><small class=\"text-muted\">");
            EndContext();
            BeginContext(4492, 38, false);
#line 94 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                                                                          Write(Model.Characters.ElementAt(i).Modified);

#line default
#line hidden
            EndContext();
            BeginContext(4530, 122, true);
            WriteLiteral("</small></p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 98 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"

                        var imageComic = Model.Comics.ElementAt(i).Thumbnail.Path + "/portrait_medium." + Model.Comics.ElementAt(i).Thumbnail.Extension;
                        var descriptionComic = Model.Comics.ElementAt(i).Description.Length > 100 ? Model.Comics.ElementAt(i).Description.Substring(0,100) : Model.Comics.ElementAt(i).Description;


#line default
#line hidden
            BeginContext(5007, 224, true);
            WriteLiteral("                        <div class=\"col-sm-12 col-md-6 my-2\">\r\n                            <div class=\"border rounded d-flex\">\r\n                                <div class=\"col-md-3\">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5231, "\"", 5248, 1);
#line 105 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
WriteAttributeValue("", 5237, imageComic, 5237, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5249, 184, true);
            WriteLiteral(" class=\"img-thumbnail\" alt=\"...\">\r\n                                </div>\r\n                                <div class=\"col-md-9 p-2\">\r\n                                    <h6 class=\"\">");
            EndContext();
            BeginContext(5434, 31, false);
#line 108 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                                            Write(Model.Comics.ElementAt(i).Title);

#line default
#line hidden
            EndContext();
            BeginContext(5465, 60, true);
            WriteLiteral("</h6>\r\n                                    <p class=\"small\">");
            EndContext();
            BeginContext(5526, 16, false);
#line 109 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                                                Write(descriptionComic);

#line default
#line hidden
            EndContext();
            BeginContext(5542, 85, true);
            WriteLiteral("</p>\r\n                                    <p class=\"small\"><small class=\"text-muted\">");
            EndContext();
            BeginContext(5628, 34, false);
#line 110 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                                                                          Write(Model.Comics.ElementAt(i).Modified);

#line default
#line hidden
            EndContext();
            BeginContext(5662, 122, true);
            WriteLiteral("</small></p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 114 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                    }

#line default
#line hidden
            BeginContext(5807, 454, true);
            WriteLiteral(@"
                    <div class=""container"">
                        <br />
                        <hr />
                        <br />
                    <div class=""row"">
                        <div class=""col-sm-12 col-md-6"">
                            <h2>CREATORS</h2>
                        </div>
                        <div class=""col-sm-12 col-md-6"">
                            <h2>SERIES</h2>
                        </div>
");
            EndContext();
#line 127 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                         for (var i = 0; i < Model.Creators.Count(); i++)
                        {
                            var imageCreator = Model.Creators.ElementAt(i).Thumbnail.Path + "/portrait_medium." + Model.Creators.ElementAt(i).Thumbnail.Extension;

#line default
#line hidden
            BeginContext(6527, 240, true);
            WriteLiteral("                            <div class=\"col-sm-12 col-md-6 my-2\">\r\n                                <div class=\"border rounded d-flex\">\r\n                                    <div class=\"col-md-3\">\r\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6767, "\"", 6786, 1);
#line 133 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
WriteAttributeValue("", 6773, imageCreator, 6773, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6787, 196, true);
            WriteLiteral(" class=\"img-thumbnail\" alt=\"...\">\r\n                                    </div>\r\n                                    <div class=\"col-md-9 p-2\">\r\n                                        <h6 class=\"\">");
            EndContext();
            BeginContext(6984, 36, false);
#line 136 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                                                Write(Model.Creators.ElementAt(i).FullName);

#line default
#line hidden
            EndContext();
            BeginContext(7020, 90, true);
            WriteLiteral("</h6>\r\n                                        <p class=\"small\"><small class=\"text-muted\">");
            EndContext();
            BeginContext(7111, 36, false);
#line 137 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                                                                              Write(Model.Creators.ElementAt(i).Modified);

#line default
#line hidden
            EndContext();
            BeginContext(7147, 134, true);
            WriteLiteral("</small></p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 141 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"

                            var imageSerie = Model.Series.ElementAt(i).Thumbnail.Path + "/portrait_medium." + Model.Series.ElementAt(i).Thumbnail.Extension;
                            var descriptionSerie = Model.Series.ElementAt(i).Description.Length > 100 ? Model.Series.ElementAt(i).Description.Substring(0, 100) : Model.Series.ElementAt(i).Description;


#line default
#line hidden
            BeginContext(7645, 240, true);
            WriteLiteral("                            <div class=\"col-sm-12 col-md-6 my-2\">\r\n                                <div class=\"border rounded d-flex\">\r\n                                    <div class=\"col-md-3\">\r\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 7885, "\"", 7902, 1);
#line 148 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
WriteAttributeValue("", 7891, imageSerie, 7891, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7903, 196, true);
            WriteLiteral(" class=\"img-thumbnail\" alt=\"...\">\r\n                                    </div>\r\n                                    <div class=\"col-md-9 p-2\">\r\n                                        <h6 class=\"\">");
            EndContext();
            BeginContext(8100, 31, false);
#line 151 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                                                Write(Model.Series.ElementAt(i).Title);

#line default
#line hidden
            EndContext();
            BeginContext(8131, 64, true);
            WriteLiteral("</h6>\r\n                                        <p class=\"small\">");
            EndContext();
            BeginContext(8196, 16, false);
#line 152 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                                                    Write(descriptionSerie);

#line default
#line hidden
            EndContext();
            BeginContext(8212, 48, true);
            WriteLiteral("</p>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8260, "\"", 8315, 1);
#line 153 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
WriteAttributeValue("", 8267, Model.Series.ElementAt(i).Urls.ElementAt(0).url, 8267, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8316, 119, true);
            WriteLiteral(" target=\"_blank\">Get More Info</a>\r\n                                        <p class=\"small\"><small class=\"text-muted\">");
            EndContext();
            BeginContext(8436, 34, false);
#line 154 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                                                                              Write(Model.Series.ElementAt(i).Modified);

#line default
#line hidden
            EndContext();
            BeginContext(8470, 134, true);
            WriteLiteral("</small></p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 158 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
                        }

#line default
#line hidden
            BeginContext(8631, 104, true);
            WriteLiteral("                    </div>\r\n                        </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 163 "C:\Users\arman\OneDrive\Documentos\Escritorio\Eduardo Rodriguez\Forum\Forum\Views\Home\Find.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Forum.Models.FindVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
