#pragma checksum "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "744b07b9bcd87582255dad0c7167dabdcc3a748c"
// <auto-generated/>
#pragma warning disable 1591
namespace Bookstore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/_Imports.razor"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/create")]
    public partial class Edit_Create_Book : OwningComponentBase<IBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    div.validation-message {\n        color: rgb(220,53,69);\n        font-weight: 500\n    }\n</style>\n\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "bg-" + (
#nullable restore
#line 12 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
               ThemeColor

#line default
#line hidden
#nullable disable
            ) + " text-white" + " text-center" + " p-1");
            __builder.AddContent(3, 
#nullable restore
#line 12 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                                       TitleName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                 b

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                   ConfirmBook

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\n\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "\n            ");
                __builder2.AddMarkupContent(15, "<label>Book Id:</label>\n            ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "disabled", true);
                __builder2.AddAttribute(19, "value", 
#nullable restore
#line 20 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                                         b.BookId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "\n            ");
                __builder2.AddMarkupContent(25, "<label>Name:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Edit_Create_Book.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 25 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                      () => b.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                                         b.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Title = __value, b.Title))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "\n            ");
                __builder2.AddMarkupContent(39, "<label>Author:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Edit_Create_Book.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 31 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                      () => b.Author

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(42, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                                          b.Author

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Author = __value, b.Author))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Author));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\n\n        ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "\n            ");
                __builder2.AddMarkupContent(53, "<label>Publisher:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Edit_Create_Book.TypeInference.CreateValidationMessage_2(__builder2, 54, 55, 
#nullable restore
#line 37 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                      () => b.Publisher

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(56, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(57);
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                                         b.Publisher

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Publisher = __value, b.Publisher))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Publisher));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\n\n        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "\n            ");
                __builder2.AddMarkupContent(67, "<label>ISBN:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Edit_Create_Book.TypeInference.CreateValidationMessage_3(__builder2, 68, 69, 
#nullable restore
#line 43 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                      () => b.Isbn

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(70, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(71);
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                                         b.Isbn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Isbn = __value, b.Isbn))));
                __builder2.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Isbn));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\n\n        ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group");
                __builder2.AddMarkupContent(80, "\n            ");
                __builder2.AddMarkupContent(81, "<label>Classification:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Edit_Create_Book.TypeInference.CreateValidationMessage_4(__builder2, 82, 83, 
#nullable restore
#line 49 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                      () => b.Classification

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(84, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(85);
                __builder2.AddAttribute(86, "class", "form-control");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                                         b.Classification

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Classification = __value, b.Classification))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Classification));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\n\n        ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-group");
                __builder2.AddMarkupContent(94, "\n            ");
                __builder2.AddMarkupContent(95, "<label>Category:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Edit_Create_Book.TypeInference.CreateValidationMessage_5(__builder2, 96, 97, 
#nullable restore
#line 55 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                      () => b.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(98, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(99);
                __builder2.AddAttribute(100, "class", "form-control");
                __builder2.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                                         b.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Category = __value, b.Category))));
                __builder2.AddAttribute(103, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => b.Category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\n\n        ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "form-group");
                __builder2.AddMarkupContent(108, "\n            ");
                __builder2.AddMarkupContent(109, "<label>Page Count:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Edit_Create_Book.TypeInference.CreateValidationMessage_6(__builder2, 110, 111, 
#nullable restore
#line 61 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                    (() => b.PageCount)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(112, "\n            ");
                __Blazor.Bookstore.Pages.Admin.Edit_Create_Book.TypeInference.CreateInputNumber_7(__builder2, 113, 114, "form-control", 115, 
#nullable restore
#line 62 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                                           b.PageCount

#line default
#line hidden
#nullable disable
                , 116, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.PageCount = __value, b.PageCount)), 117, () => b.PageCount);
                __builder2.AddMarkupContent(118, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\n\n        ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "form-group");
                __builder2.AddMarkupContent(122, "\n            ");
                __builder2.AddMarkupContent(123, "<label>Price:</label>\n            ");
                __Blazor.Bookstore.Pages.Admin.Edit_Create_Book.TypeInference.CreateValidationMessage_8(__builder2, 124, 125, 
#nullable restore
#line 67 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                    (() => b.Price)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(126, "\n            ");
                __Blazor.Bookstore.Pages.Admin.Edit_Create_Book.TypeInference.CreateInputNumber_9(__builder2, 127, 128, "form-control", 129, 
#nullable restore
#line 68 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                                           b.Price

#line default
#line hidden
#nullable disable
                , 130, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => b.Price = __value, b.Price)), 131, () => b.Price);
                __builder2.AddMarkupContent(132, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\n\n        ");
                __builder2.OpenElement(134, "button");
                __builder2.AddAttribute(135, "type", "submit");
                __builder2.AddAttribute(136, "class", "btn" + " btn-" + (
#nullable restore
#line 71 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
                                              ThemeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(137, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(139);
                __builder2.AddAttribute(140, "class", "btn btn-secondary");
                __builder2.AddAttribute(141, "href", "/admin/books");
                __builder2.AddAttribute(142, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(143, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(144, "\n\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Edit_Create_Book.razor"
       
    [Parameter]
    public long Id { get; set; } = 0;   // if we don't get one, default is 0

    public string ThemeColor => Id == 0 ? "primary" : "warning";

    public string TitleName => Id == 0 ? "Create Book" : "Edit Book";

    //need to get the data!
    public Book b { get; set; } = new Book(); //this is the default if one is not found

    public IBookstoreRepository repo => Service;

    //method
    protected override void OnParametersSet()
    {
        if (Id != 0) //existing book
        {
            b = repo.Books.FirstOrDefault(x => x.BookId == Id);
        }
    }

    public void ConfirmBook()
    {
        if (Id == 0) // if this is a NEW book
        {
            repo.CreateBook(b); //passing in the b we are building over to our repo!!
        }
        else
        {
            repo.SaveBook(b);
        }

        navManager.NavigateTo("/admin/books");
    }

    [Inject]
    public NavigationManager navManager { get; set; } //

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Bookstore.Pages.Admin.Edit_Create_Book
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
