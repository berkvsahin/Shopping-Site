#pragma checksum "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c6a1cba4ebbd585f2dc5f144a0bdc0c0c89341d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\_ViewImports.cshtml"
using SiparisSepetim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\_ViewImports.cshtml"
using SiparisSepetim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c6a1cba4ebbd585f2dc5f144a0bdc0c0c89341d", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ce7a9d0649c61e25de67c3d642cf6a12c3ff6b6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiparisSepetim.Models.ModelViewProducts>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("addcart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
#nullable disable
            WriteLiteral("  <div class=\"container-fluid\">\r\n            <div class=\"page-header\">\r\n              <div class=\"row\">\r\n                <div class=\"col-sm-6\">\r\n                  <h3>Product</h3>\r\n\r\n                </div>\r\n");
#nullable restore
#line 14 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                     foreach (var item in Model.Categories)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <ul>\n                              <li><a class=\"nav-link menu-title link-nav\"> <span>");
#nullable restore
#line 17 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                                                                            Write(item.categoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\t\r\n                         </ul>\n");
#nullable restore
#line 19 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                   }           

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              </div>
            </div>
          </div>
          <!-- Container-fluid starts-->
          <div class=""container-fluid product-wrapper"">
            <div class=""product-grid"">
              <div class=""feature-products"">
                <div class=""row m-b-10"">
                  <div class=""col-md-3 col-sm-2 products-total"">
                    <div class=""square-product-setting d-inline-block""><a class=""icon-grid grid-layout-view"" href=""javascript:void(0)"" data-original-title=""""");
            BeginWriteAttribute("title", " title=\"", 1108, "\"", 1116, 0);
            EndWriteAttribute();
            WriteLiteral("><i data-feather=\"grid\"></i></a></div>\r\n                    <div class=\"square-product-setting d-inline-block\"><a class=\"icon-grid m-0 list-layout-view\" href=\"javascript:void(0)\" data-original-title=\"\"");
            BeginWriteAttribute("title", " title=\"", 1318, "\"", 1326, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i data-feather=""list""></i></a></div>
                    <div class=""d-none-productlist filter-toggle"">
                      <h6 class=""mb-0"">Filters<span class=""ms-2""><i class=""toggle-data"" data-feather=""chevron-down""></i></span></h6>
                    </div>
                    <div class=""grid-options d-inline-block"">
                      <ul>
                        <li><a class=""product-2-layout-view"" href=""javascript:void(0)"" data-original-title=""""");
            BeginWriteAttribute("title", " title=\"", 1797, "\"", 1805, 0);
            EndWriteAttribute();
            WriteLiteral("><span class=\"line-grid line-grid-1 bg-primary\"></span><span class=\"line-grid line-grid-2 bg-primary\"></span></a></li>\r\n                        <li><a class=\"product-3-layout-view\" href=\"javascript:void(0)\" data-original-title=\"\"");
            BeginWriteAttribute("title", " title=\"", 2035, "\"", 2043, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span class=""line-grid line-grid-3 bg-primary""></span><span class=""line-grid line-grid-4 bg-primary""></span><span class=""line-grid line-grid-5 bg-primary""></span></a></li>
                        <li><a class=""product-4-layout-view"" href=""javascript:void(0)"" data-original-title=""""");
            BeginWriteAttribute("title", " title=\"", 2327, "\"", 2335, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span class=""line-grid line-grid-6 bg-primary""></span><span class=""line-grid line-grid-7 bg-primary""></span><span class=""line-grid line-grid-8 bg-primary""></span><span class=""line-grid line-grid-9 bg-primary""></span></a></li>
                        <li><a class=""product-6-layout-view"" href=""javascript:void(0)"" data-original-title=""""");
            BeginWriteAttribute("title", " title=\"", 2673, "\"", 2681, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span class=""line-grid line-grid-10 bg-primary""></span><span class=""line-grid line-grid-11 bg-primary""></span><span class=""line-grid line-grid-12 bg-primary""></span><span class=""line-grid line-grid-13 bg-primary""></span><span class=""line-grid line-grid-14 bg-primary""></span><span class=""line-grid line-grid-15 bg-primary""></span></a></li>
                      </ul>
                    </div>
                  </div>
                  <div class=""col-md-9 col-sm-10 text-end""><span class=""f-w-600 m-r-5""></span>
                    <div class=""select2-drpdwn-product select-options d-inline-block"">
                      <select class=""form-control btn-square"" name=""select"">
                      </select>
                    </div>
                  </div>
                </div>
                <div class=""row"">                            
                  
                  </div>
                </div>
              </div>
              </div>
              <div class=""product-wrapper-grid"">");
            WriteLiteral("\n                <div class=\"row\">\r\n");
#nullable restore
#line 58 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                     
                       foreach (var product in Model.Product)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                           <div class=""col-xl-3 col-sm-6 xl-4"">
                            <div class=""card"">
                              <div class=""product-box"">
                                <div class=""product-img""><img class=""img-fluid"" src=""/assets/images/ecommerce/01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4139, "\"", 4145, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                  <div class=\"product-hover\">\r\n                                    <ul>\r\n                                      <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6a1cba4ebbd585f2dc5f144a0bdc0c0c89341d11262", async() => {
                WriteLiteral("<i class=\"icon-shopping-cart\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                                      <li><a data-bs-toggle=""modal"" data-bs-target=""#exampleModalCenter16""><i class=""icon-eye""></i></a></li>
                                    </ul>
                                  </div>
                                </div>
                                <div class=""modal fade"" id=""exampleModalCenter16"">
                                  <div class=""modal-dialog modal-lg modal-dialog-centered"">
                                    <div class=""modal-content"">
                                      <div class=""modal-header"">
                                        <div class=""product-box row"">
                                          <div class=""product-img col-lg-6""><img class=""img-fluid"" src=""/assets/images/ecommerce/01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5167, "\"", 5173, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                          <div class=\"product-details col-lg-6 text-start\"><a>\r\n                                              <h4>");
#nullable restore
#line 79 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                                             Write(product.productName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 79 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                                                                    Write(product.category.categoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\r\n                                            <div class=\"product-price\">$");
#nullable restore
#line 80 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                                                                   Write(product.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                              <del>$");
#nullable restore
#line 81 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                                                Write(product.price * 3/10);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</del>
                                            </div>
                                            <div class=""product-view"">
                                              <h6 class=""f-w-600"">Product Details</h6>
                                              <p class=""mb-0"">Sed ut perspiciatis, unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam eaque ipsa, quae ab illo.</p>
                                            </div>
                 
                                            </div>
                                            <div class=""product-qnty"">
                                              <h6 class=""f-w-600"">Quantity</h6>
                                              <fieldset>
                                                <div class=""input-group"">
                                                  <input class=""touchspin text-center"" type=""text"" value=""5"">
                                                </div>
                  ");
            WriteLiteral("                            </fieldset>\r\n                                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c6a1cba4ebbd585f2dc5f144a0bdc0c0c89341d16265", async() => {
                WriteLiteral("\r\n                                              <div ><a class=\"btn btn-primary me-3\" >Add to Cart name=\"");
#nullable restore
#line 97 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                                                                                                  Write(product.productName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"</a><a class=\"btn btn-primary\">View Details</a></div>\r\n                                              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                              </div>
                                          </div>
                                        </div>
                                        <button class=""btn-close"" type=""button"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                                      </div>
                                    </div>
                                  </div>
                                </div>
                                <div class=""product-details""><a href=""product-page.html"">
                                    <h4>");
#nullable restore
#line 108 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                                   Write(product.productName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\r\n                                  <div class=\"product-price\">$");
#nullable restore
#line 109 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                                                         Write(product.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <del>$");
#nullable restore
#line 110 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                                      Write(product.price * 3/2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                                  </div>\r\n                                </div>\r\n                              </div>\r\n                            </div>                        \n");
#nullable restore
#line 115 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Product\Index.cshtml"
                       }  
                  

#line default
#line hidden
#nullable disable
            WriteLiteral("                  \r\n                </div>\r\n              </div>\r\n            \r\n          \r\n          <!-- Container-fluid Ends-->\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiparisSepetim.Models.ModelViewProducts> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
