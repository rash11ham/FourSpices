#pragma checksum "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c29a5d5d271efd7e56d8d49d2241f65168ab78d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Cart_Summary), @"mvc.1.0.view", @"/Areas/Customer/Views/Cart/Summary.cshtml")]
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
#line 1 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\_ViewImports.cshtml"
using FourSpices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\_ViewImports.cshtml"
using FourSpices.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29a5d5d271efd7e56d8d49d2241f65168ab78d3", @"/Areas/Customer/Views/Cart/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d18814bdfc5a356ef57a6627010e56fc7b3658fb", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Cart_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FourSpices.Models.ViewModels.OrderDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("userId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtPhone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("datepicker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("timepicker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c29a5d5d271efd7e56d8d49d2241f65168ab78d38554", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
     if (Model.ListCart.Count > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c29a5d5d271efd7e56d8d49d2241f65168ab78d39084", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 12 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ListCart[0].ApplicationUserId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <div class=""backgroundWhiteBorder"">
            <div class=""container"">
                <div class=""card"">
                    <div class=""card-header bg-dark text-light ml-0 row container"">
                        <div class=""col-6"">
                            <i class=""fa fa-shopping-basket""></i> &nbsp; Order Summary
                        </div>
                        <div class=""col-6 text-right"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c29a5d5d271efd7e56d8d49d2241f65168ab78d311471", async() => {
                    WriteLiteral("Back to Cart");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                    <div class=""card-body"">
                        <div class=""container rounded p-2"">
                            <div class=""row"">
                                <div class=""col-12 col-lg-6 pb-4"">
                                    <div class=""row"">
                                        <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                                            <span class=""text-info"">Pickup Details:</span>
                                        </h4>
                                    </div>
                                    <div class=""row my-1"">
                                        <div class=""col-3"">
                                            <label>Name</label>
                                        </div>
                                        <div class=""col-9"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c29a5d5d271efd7e56d8d49d2241f65168ab78d314192", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 38 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.OrderHeader.PickupName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
                                    <div class=""row my-1"">
                                        <div class=""col-3"">
                                            <label>Phone</label>
                                        </div>
                                        <div class=""col-9"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c29a5d5d271efd7e56d8d49d2241f65168ab78d316527", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 46 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.OrderHeader.PhoneNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
                                    <div class=""row my-1"">
                                        <div class=""col-3"">
                                            <label>Date</label>
                                        </div>
                                        <div class=""col-9"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c29a5d5d271efd7e56d8d49d2241f65168ab78d318862", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 54 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.OrderHeader.PickUpDate);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
                                    <div class=""row my-1"">
                                        <div class=""col-3"">
                                            <label>Time</label>
                                        </div>
                                        <div class=""col-9"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c29a5d5d271efd7e56d8d49d2241f65168ab78d321406", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 62 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.OrderHeader.PickUpTime);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
                                    <div class=""row my-1"">
                                        <div class=""col-3"">
                                            <label>Comments</label>
                                        </div>
                                        <div class=""col-9"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c29a5d5d271efd7e56d8d49d2241f65168ab78d323955", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 70 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.OrderHeader.Comments);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
                                <div class=""col-12 col-lg-5 offset-lg-1"">
                                    <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                                        <span class=""text-info"">Order Summary:</span>
                                    </h4>
                                    <ul class=""list-group mb-3"">
");
#nullable restore
#line 79 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                           var total = 0.0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                         foreach (var details in Model.ListCart)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <li class=\"list-group-item d-flex justify-content-between\">\r\n                                                <div>\r\n                                                    <h6 class=\"my-0\">");
#nullable restore
#line 84 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                Write(details.MenuItem.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                                    <small class=\"text-muted\">Quantity: ");
#nullable restore
#line 85 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                                   Write(details.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                                </div>\r\n                                                <span class=\"text-muted\">$");
#nullable restore
#line 87 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                      Write(details.MenuItem.Price * details.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 88 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                                   total += (details.MenuItem.Price * details.Count); 

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </li>\r\n");
#nullable restore
#line 90 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                         if (Model.OrderHeader.CouponCode != null)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <li class=""list-group-item d-flex justify-content-between"">
                                                <div class=""text-success"">
                                                    <h6 class=""my-0"">Promo Code</h6>
                                                    <small class=""text-success"">");
#nullable restore
#line 96 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                           Write(Model.OrderHeader.CouponCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                                </div>\r\n                                                <span class=\"text-success\">-$");
#nullable restore
#line 98 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                         Write(total - Model.OrderHeader.OrderTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                            </li>\r\n");
#nullable restore
#line 100 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <li class=""list-group-item d-flex justify-content-between bg-light"">
                                            <small class=""text-info"">Total (AUD)</small>
                                            <strong class=""text-info"">$");
#nullable restore
#line 103 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                                                   Write(Model.OrderHeader.OrderTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""card-footer"">
                        <div class=""row"">
                            <div class=""col-12 col-md-4 offset-md-8"">

");
#nullable restore
#line 115 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                  
                                    //any amount in stripe is in cents should multiplied to 100 to make dollar
                                    var OrderTotalForStripes = Model.OrderHeader.OrderTotal * 100;
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <script src=\"https://checkout.stripe.com/checkout.js\" class=\"stripe-button\"\r\n                                        data-key=\"");
#nullable restore
#line 120 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                             Write(Stripe.Value.PublishableKey);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                                        data-amount=\"");
#nullable restore
#line 121 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
                                                Write(OrderTotalForStripes);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                                        data-name=""FourSpices Restaurant""
                                        data-label=""Place Order""
                                        data-description=""Good Food, Good Mood.""
                                        data-locale=""auto""
                                        data-allow-remember-me=""false""
                                        data-image=""https://stripe.com/img/documentation/checkout/marketplace.png"">
                                </script>
");
                WriteLiteral(@"                                <script>
                                    document.getElementsByClassName(""stripe-button-el"")[0].style.display = 'none';
                                </script>

                                <button type=""submit"" id=""btnPlaceHolder"" onclick=""return validateInput()"" value=""Place Order"" class=""btn btn-success form-control"">Place Order</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 141 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"backgroundWhiteBorder\"> No items added to the shopping cart...</div>\r\n");
#nullable restore
#line 146 "C:\Users\rashe\Documents\FourSpices\FourSpices\Areas\Customer\Views\Cart\Summary.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-timepicker/1.14.1/jquery.timepicker.js""></script>
    <script>
        $(function () {
            var minDt = 0;
            if (getTimeFromCurrentDate() >= ""20.00"") {
                minDt = 1;
            }


            $(""#datepicker"").datepicker({ minDate: minDt, maxDate: ""+1W"" });
            $(""#timepicker"").timepicker({ 'minTime': '11:00 AM', 'maxTime': '9:00 PM', step: '30' })



");
                WriteLiteral(@"        });

        function setPickUpTime() {
            var dateSelected = document.getElementById(""datepicker"").value;
            var dt = new Date(dateSelected);
            var today = new Date();

            dt.setHours(0, 0, 0, 0);
            if (dt > today) {
                selectedTime = '11:00am';
            }
            else {
                selectedTime = getTimeFromCurrentDate();
            }

            $('#timepicker').timepicker('option', 'minTime', selectedTime);

        }


        function getTimeFromCurrentDate() {
            var curDt = new Date();

            var minTime = """";
            if (curDt.getHours() < 11) {
                minTime = '12:00pm';
            }
            else {
                if (curDt.getMinutes() < 30) {
                    minTime = (curDt.getHours() + 1).toString() + ':30pm'
                }
                else {
                    minTime = (curDt.getHours() + 2).toString() + ':00pm'
                }
     ");
                WriteLiteral(@"       }
            return minTime;
        }

        $('#datepicker').change(function () {
            setPickUpTime();
        });


        function validateInput() {
            var time = document.getElementById(""timepicker"").value;
            var dt = document.getElementById(""datepicker"").value;
            var name = document.getElementById(""txtName"").value;
            var phone = document.getElementById(""txtPhone"").value;

            if (dt.toString().length == 0) {
                alert(""Please select pickup date"")
                return false;
            }
            else if (time.toString().length == 0) {
                alert(""Please select pickup time"")
                return false;
            }
            else if (name.toString().length == 0) {
                alert(""Please enter pickup name"")
                return false;
            }
            else if (phone.toString().length == 0) {
                alert(""Please enter a phone number"")
                r");
                WriteLiteral("eturn false;\r\n            }\r\n            else {\r\n                return true;\r\n            }\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<FourSpices.Utility.StripeSettings> Stripe { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FourSpices.Models.ViewModels.OrderDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
