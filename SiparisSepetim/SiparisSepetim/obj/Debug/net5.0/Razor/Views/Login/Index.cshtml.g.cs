#pragma checksum "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ae93496d58097927dae9a4281365cddfde3c079"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ae93496d58097927dae9a4281365cddfde3c079", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ce7a9d0649c61e25de67c3d642cf6a12c3ff6b6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiparisSepetim.Models.ModelViewUsers>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sign", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Login\Index.cshtml"
  
	//Layout = "~/Views/Shared/_Layout.cshtml";
	Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ae93496d58097927dae9a4281365cddfde3c0794404", async() => {
                WriteLiteral(@"
	<meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
	<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
	<meta name=""description"" content=""viho admin is super flexible, powerful, clean &amp; modern responsive bootstrap 4 admin template with unlimited possibilities."">
	<meta name=""keywords"" content=""admin template, viho admin template, dashboard template, flat admin template, responsive admin template, web app"">
	<meta name=""author"" content=""pixelstrap"">
	<link rel=""icon"" href=""../assets/images/favicon.png"" type=""image/x-icon"">
	<link rel=""shortcut icon"" href=""../assets/images/favicon.png"" type=""image/x-icon"">
	<title>viho - Premium Admin Template</title>
	<!-- Google font-->
	<link rel=""preconnect"" href=""https://fonts.gstatic.com"">
	<link href=""https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;");
                WriteLiteral(@"1,900&amp;display=swap"" rel=""stylesheet"">
	<link href=""https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&amp;display=swap"" rel=""stylesheet"">
	<link href=""https://fonts.googleapis.com/css2?family=Rubik:ital,wght@0,400;0,500;0,600;0,700;0,800;0,900;1,300;1,400;1,500;1,600;1,700;1,800;1,900&amp;display=swap"" rel=""stylesheet"">
	<!-- Font Awesome-->
	<link rel=""stylesheet"" type=""text/css"" href=""/assets/css/fontawesome.css"">
	<!-- ico-font-->
	<link rel=""stylesheet"" type=""text/css"" href=""/assets/css/icofont.css"">
	<!-- Themify icon-->
	<link rel=""stylesheet"" type=""text/css"" href=""/assets/css/themify.css"">
	<!-- Flag icon-->
	<link rel=""stylesheet"" type=""text/css"" href=""/assets/css/flag-icon.css"">
	<!-- Feather icon-->
	<link rel=""stylesheet"" type=""text/css"" href=""/assets/css/feather-icon.css"">
	<!-- Plugins css start-->
	<!-- Plugins css Ends-->
	<!-- Bootstrap css-->
	<link rel=""stylesheet"" type=""text/css"" href=""/assets");
                WriteLiteral(@"/css/bootstrap.css"">
	<!-- App css-->
	<link rel=""stylesheet"" type=""text/css"" href=""/assets/css/style.css"">
	<link id=""color"" rel=""stylesheet"" href=""/assets/css/color-1.css"" media=""screen"">
	<!-- Responsive css-->
	<link rel=""stylesheet"" type=""text/css"" href=""/assets/css/responsive.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ae93496d58097927dae9a4281365cddfde3c0797890", async() => {
                WriteLiteral(@"
	<!-- Loader starts-->
	<div class=""loader-wrapper"">
		<div class=""theme-loader"">
			<div class=""loader-p""></div>
		</div>
	</div>
	<!-- Loader ends-->
	<!-- page-wrapper Start-->
	<section>
		<div class=""container-fluid p-0"">
			<div class=""row"">
				<div class=""col-12"">
					<div class=""login-card"">


");
#nullable restore
#line 61 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Login\Index.cshtml"
                         using (Html.BeginForm("Submit", "Login", FormMethod.Post, new { @class = "theme-form login-form", id = "postFormSeo", enctype = "multipart/form-data" }))
						{

#line default
#line hidden
#nullable disable
                WriteLiteral(@"							<h4>Login</h4>
							<h6>Welcome back! Log in to your account.</h6>
							<div class=""form-group"">
								<label>Email Address</label>

								<div class=""input-group"">
									<span class=""input-group-text""><i class=""icon-email""></i></span>
									");
#nullable restore
#line 70 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Login\Index.cshtml"
                               Write(Html.TextBoxFor(m=>m.User.eMail,new {@class="form-control" ,@type="email",@required="",@placeholder="Test@gmail.com"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label>Password</label>\r\n\t\t\t\t\t\t\t\t<div class=\"input-group\">\r\n\t\t\t\t\t\t\t\t\t<span class=\"input-group-text\"><i class=\"icon-lock\"></i></span>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 78 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Login\Index.cshtml"
                               Write(Html.TextBoxFor(m=>m.User.pass,new {@class="form-control" ,@type="password",@required="",@placeholder="*********"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
									<div class=""show-hide""><span class=""show"">                         </span></div>
								</div>
							</div>
							<div class=""form-group"">
							</div>
							<div class=""form-group"">
								<button class=""btn btn-primary btn-block"" type=""submit"">Sign in</button>
							</div>
							<div class=""login-social-title"">
								<h5>Sign in with</h5>
							</div>
");
                WriteLiteral("\t\t\t\t\t\t\t<p>Don\'t have account?");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ae93496d58097927dae9a4281365cddfde3c07910678", async() => {
                    WriteLiteral("Create Account");
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
                WriteLiteral("</p>\r\n");
#nullable restore
#line 92 "D:\Projeler\SiparisSepetim\SiparisSepetim\SiparisSepetim\SiparisSepetim\Views\Login\Index.cshtml"


						}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

					</div>
				</div>
			</div>
		</div>
	</section>
	<!-- page-wrapper end-->
	<!-- latest jquery-->
	<script src=""/assets/js/jquery-3.5.1.min.js""></script>
	<!-- feather icon js-->
	<script src=""/assets/js/icons/feather-icon/feather.min.js""></script>
	<script src=""/assets/js/icons/feather-icon/feather-icon.js""></script>
	<!-- Sidebar jquery-->
	<script src=""/assets/js/sidebar-menu.js""></script>
	<script src=""/assets/js/config.js""></script>
	<!-- Bootstrap js-->
	<script src=""/assets/js/bootstrap/popper.min.js""></script>
	<script src=""/assets/js/bootstrap/bootstrap.min.js""></script>
	<!-- Plugins JS start-->
	<!-- Plugins JS Ends-->
	<!-- Theme js-->
	<script src=""/assets/js/script.js""></script>
	<!-- login js-->
	<!-- Plugin used-->
");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiparisSepetim.Models.ModelViewUsers> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591