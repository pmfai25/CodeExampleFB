#pragma checksum "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5c6f6d1c86bae924946f4eb921eef1e191013b9"
// <auto-generated/>
#pragma warning disable 1591
namespace FinanceBro.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using FinanceBro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Blazorise.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Blazorise.Icons.FontAwesome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using FinanceBro.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using BlazorTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Syncfusion.Blazor.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Syncfusion.Blazor.Maps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
using FinanceBro.Data;

#line default
#line hidden
#nullable disable
    public partial class SymbolNewsModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "id", "taskModal");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.AddAttribute(7, "role", "document");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.AddMarkupContent(10, "<div class=\"modal-header\"><h5 class=\"modal-title\">News Article</h5>\n                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">×</span></button></div>\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                  SymbolNews

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                              HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "<label for=\"headline\">Symbol</label>\n                        ");
                __Blazor.FinanceBro.Pages.SymbolNewsModal.TypeInference.CreateInputSelect_0(__builder2, 20, 21, "Summary", 22, "form-control", 23, 
#nullable restore
#line 20 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                   SymbolNews.symbol

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SymbolNews.symbol = __value, SymbolNews.symbol)), 25, () => SymbolNews.symbol, 26, (__builder3) => {
                    __builder3.AddMarkupContent(27, "<option value>Select</option>");
#nullable restore
#line 22 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                             if (symbolFactsDataList == null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                 foreach (var sym in InitialisingList)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(28, "option");
                    __builder3.AddAttribute(29, "value", 
#nullable restore
#line 26 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                    sym

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(30, 
#nullable restore
#line 27 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                         sym

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 29 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                 
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                 foreach (var sym in symbolFactsDataList)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(31, "option");
                    __builder3.AddAttribute(32, "value", 
#nullable restore
#line 35 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                    sym.Symbol

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(33, 
#nullable restore
#line 36 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                         sym.CompanyName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 38 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n                    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "<label for=\"articledatetime\">Publication Date</label>\n                        ");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "date");
                __builder2.AddAttribute(40, "id", "addition");
                __builder2.AddAttribute(41, "name", "math");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                                                   SymbolNews.articledatetime

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SymbolNews.articledatetime = __value, SymbolNews.articledatetime, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n                    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "<label for=\"symbol\">Headline</label>\n                        ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "hidden");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                           SymbolNews.headline

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SymbolNews.headline = __value, SymbolNews.headline));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "id", "name");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                                                SymbolNews.headline

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SymbolNews.headline = __value, SymbolNews.headline))));
                __builder2.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SymbolNews.headline));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\n                    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group");
                __builder2.AddMarkupContent(62, "<label for=\"symbol\">Summary</label>\n                        ");
                __builder2.OpenElement(63, "input");
                __builder2.AddAttribute(64, "type", "hidden");
                __builder2.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                           SymbolNews.summary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SymbolNews.summary = __value, SymbolNews.summary));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(68);
                __builder2.AddAttribute(69, "id", "name");
                __builder2.AddAttribute(70, "class", "form-control");
                __builder2.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                                                SymbolNews.summary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SymbolNews.summary = __value, SymbolNews.summary))));
                __builder2.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SymbolNews.summary));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\n                    ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group");
                __builder2.AddMarkupContent(77, "<label for=\"symbol\">Source</label>\n                        ");
                __builder2.OpenElement(78, "input");
                __builder2.AddAttribute(79, "type", "hidden");
                __builder2.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                           SymbolNews.url

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SymbolNews.url = __value, SymbolNews.url));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(83);
                __builder2.AddAttribute(84, "id", "name");
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                                                SymbolNews.url

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SymbolNews.url = __value, SymbolNews.url))));
                __builder2.AddAttribute(88, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SymbolNews.url));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\n                    ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "form-group");
                __builder2.AddMarkupContent(92, "<label for=\"headline\">Rating</label>\n                        ");
                __Blazor.FinanceBro.Pages.SymbolNewsModal.TypeInference.CreateInputSelect_1(__builder2, 93, 94, "Summary", 95, "form-control", 96, 
#nullable restore
#line 64 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                  SymbolNews.comment

#line default
#line hidden
#nullable disable
                , 97, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SymbolNews.comment = __value, SymbolNews.comment)), 98, () => SymbolNews.comment, 99, (__builder3) => {
                    __builder3.AddMarkupContent(100, "<option value>Select</option>");
#nullable restore
#line 66 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                             foreach (var rating in SymbolComment)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(101, "option");
                    __builder3.AddAttribute(102, "value", 
#nullable restore
#line 68 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                                rating

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(103, 
#nullable restore
#line 69 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                                     rating

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 71 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
                            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\n                    ");
                __builder2.AddMarkupContent(105, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\n                    ");
                __builder2.AddMarkupContent(106, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancel</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/SymbolNewsModal.razor"
       

    [Parameter]
    public SymbolNews SymbolNews { get; set; }

    [Parameter]
    public Action DataChanged { get; set; }

    private async Task CloseTaskModal()
    {
        await jsRuntime.InvokeAsync<object>("CloseModal", "taskModal");
    }

    private async void HandleValidSubmit()
    {
        await service.Add(SymbolNews);
        await CloseTaskModal();
        DataChanged?.Invoke();
    }










    public SymbolFacts symbolObj;

    public List<SymbolFacts> symbolFactsDataList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        symbolFactsDataList = await symbolservice.Get();
    }

    List<string> SymbolComment = new List<string>() { "Positive", "Negative", "Neutral" };

    List<string> InitialisingList = new List<string>() { "Initialising" };




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISymbolFactsDataListService symbolservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISymbolNewsListService service { get; set; }
    }
}
namespace __Blazor.FinanceBro.Pages.SymbolNewsModal
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
