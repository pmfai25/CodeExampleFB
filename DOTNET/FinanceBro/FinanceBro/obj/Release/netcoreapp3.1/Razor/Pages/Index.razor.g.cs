#pragma checksum "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba999f5d1747e73b87f6a8656e7984ce3aab3d2f"
// <auto-generated/>
#pragma warning disable 1591
namespace FinanceBro.Pages
{
    #line hidden
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
#line 19 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
using FinanceBro.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
using FinanceBro.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
using Syncfusion.Blazor.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
using Syncfusion.Blazor.Maps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
using Blazorise.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
using Blazorise.Snackbar;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Components.SelectList<SymbolFacts, string>>(0);
            __builder.AddAttribute(1, "Disabled", 
#nullable restore
#line 24 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                           IsDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SymbolFacts>>(
#nullable restore
#line 26 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                   SymbolFactsList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "TextField", new System.Func<SymbolFacts, System.String>(
#nullable restore
#line 27 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                         (item)=>item.CompanyName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ValueField", new System.Func<SymbolFacts, string>(
#nullable restore
#line 28 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                          (item)=>item.Symbol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "SelectedValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 29 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                            UserSelectedSymbol

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "SelectedValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, 
#nullable restore
#line 30 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                   MyListValueChangedHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenComponent<Blazorise.Button>(8);
            __builder.AddAttribute(9, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 32 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
               Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                        (() => PostToApi(PossibleApis[0]))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(12, "Get Market Data!");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\n");
            __builder.OpenComponent<Blazorise.Button>(14);
            __builder.AddAttribute(15, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 33 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
               Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                        (() => PostToApi(PossibleApis[1]))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(18, "Calculate Analytics!");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\n\n");
            __builder.OpenComponent<Blazorise.Snackbar.Snackbar>(20);
            __builder.AddAttribute(21, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Snackbar.SnackbarColor>(
#nullable restore
#line 35 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                        SnackbarColor.Info

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Location", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Snackbar.SnackbarLocation>(
#nullable restore
#line 35 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                                                     SnackbarLocation.Right

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "Interval", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 35 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                                                                                      5000

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Snackbar.SnackbarBody>(25);
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n        Api call initialized...\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n    ");
                __builder2.OpenComponent<Blazorise.Snackbar.SnackbarAction>(29);
                __builder2.AddAttribute(30, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 39 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                               ()=>snackbarStarted.Hide()

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(32, "Initialized");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(33, (__value) => {
#nullable restore
#line 35 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                snackbarStarted = (Blazorise.Snackbar.Snackbar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\n");
            __builder.OpenComponent<Blazorise.Snackbar.Snackbar>(35);
            __builder.AddAttribute(36, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Snackbar.SnackbarColor>(
#nullable restore
#line 41 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                        SnackbarColor.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "Location", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Snackbar.SnackbarLocation>(
#nullable restore
#line 41 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                                                        SnackbarLocation.Right

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "Interval", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 41 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                                                                                         5000

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Snackbar.SnackbarBody>(40);
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(42, "\n        The Api call finished successfully with feedback ");
                    __builder3.AddContent(43, 
#nullable restore
#line 43 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                                          ApiFeedback.Item2

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(44, ";\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\n    ");
                __builder2.OpenComponent<Blazorise.Snackbar.SnackbarAction>(46);
                __builder2.AddAttribute(47, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 45 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                               ()=>snackbarSuccess.Hide()

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(49, "Success");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(50, (__value) => {
#nullable restore
#line 41 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                snackbarSuccess = (Blazorise.Snackbar.Snackbar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\n");
            __builder.OpenComponent<Blazorise.Snackbar.Snackbar>(52);
            __builder.AddAttribute(53, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Snackbar.SnackbarColor>(
#nullable restore
#line 47 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                      SnackbarColor.Warning

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "Location", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Snackbar.SnackbarLocation>(
#nullable restore
#line 47 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                                                      SnackbarLocation.Right

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "Interval", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 47 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                                                                                       5000

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Snackbar.SnackbarBody>(57);
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(59, "\n        The Api call failed with feedback ");
                    __builder3.AddContent(60, 
#nullable restore
#line 49 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                           ApiFeedback.Item2

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(61, ";\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\n    ");
                __builder2.OpenComponent<Blazorise.Snackbar.SnackbarAction>(63);
                __builder2.AddAttribute(64, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 51 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                               ()=>snackbarError.Hide()

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(66, "Error");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(67, (__value) => {
#nullable restore
#line 47 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                snackbarError = (Blazorise.Snackbar.Snackbar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\n");
            __builder.OpenComponent<Blazorise.Snackbar.Snackbar>(69);
            __builder.AddAttribute(70, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Snackbar.SnackbarColor>(
#nullable restore
#line 53 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                        SnackbarColor.Dark

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "Location", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Snackbar.SnackbarLocation>(
#nullable restore
#line 53 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                                                     SnackbarLocation.Right

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "Interval", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 53 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                                                                                      5000

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Snackbar.SnackbarBody>(74);
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(76, "\n        The Api call failed with unhandled reason ");
                    __builder3.AddContent(77, 
#nullable restore
#line 55 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                                                   ApiFeedback.Item2

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(78, ";\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\n    ");
                __builder2.OpenComponent<Blazorise.Snackbar.SnackbarAction>(80);
                __builder2.AddAttribute(81, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 57 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                               ()=>snackbarUnknown.Hide()

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(83, "Error");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(84, (__value) => {
#nullable restore
#line 53 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
                snackbarUnknown = (Blazorise.Snackbar.Snackbar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "/Users/julianfrech/Documents/CentralFinanceManagerV1/DOTNET/FinanceBro/FinanceBro/Pages/Index.razor"
       


    Snackbar snackbarStarted;
    Snackbar snackbarSuccess;
    Snackbar snackbarError;
    Snackbar snackbarUnknown;
    /// <summary>
    /// Variables used for disabeling functionality based on the User.
    /// </summary>
    private bool IsDisabled { get; set; } = true;
    private string User { get; set; } = null;


    private List<SymbolFacts> SymbolFactsList { get; set; }
    private string UserSelectedSymbol { get; set; }
    private Tuple<int, string> ApiFeedback { get; set; } = new Tuple<int, string>(0,"");


    /// <summary>
    /// Method called on page initialization
    /// </summary>
    protected override async Task OnInitializedAsync()
    {
        var authState = await authenticationService.GetAuthenticationStateAsync();
        var _user = authState.User;

        User = _user.Identity.Name;

        if (!(User is null))
        {
            IsDisabled = false;

            SymbolFactsList = await symbolservice.Get();

            UserSelectedSymbol = SymbolFactsList.Select(x => x.Symbol).FirstOrDefault();

            StateHasChanged();
        }
        else
        {
            IsDisabled = true;

        }
    }



    private async void MyListValueChangedHandler(string newValue)
    {
        UserSelectedSymbol = newValue;
        StateHasChanged();
    }

    private List<string> PossibleApis { get => ApiService.AvailableApiStrategies(); }


    private async Task PostToApi(string _ApiStrategy)
    {
        Dictionary<string, string> ApiDictionary = new Dictionary<string, string>
                { { "symbol","" } };


        snackbarStarted.Show();
        ApiDictionary["symbol"] = UserSelectedSymbol.ToString();
        ApiFeedback = await ApiService.GetApiValues(_ApiStrategy, ApiDictionary);
        try
        {
            switch (ApiFeedback.Item1)
            {
                case 0:
                    snackbarSuccess.Show();
                    break;
                case 1:
                    snackbarError.Show();
                    break;
                default:
                    snackbarUnknown.Show();
                    break;
            }

        }
        catch (Exception exc)
        {
            Console.WriteLine("Error in api call: " + exc.Message);
            snackbarUnknown.Show();
        }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISymbolFactsDataListService symbolservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMarketDataListService MarketDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApiServiceController ApiService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
