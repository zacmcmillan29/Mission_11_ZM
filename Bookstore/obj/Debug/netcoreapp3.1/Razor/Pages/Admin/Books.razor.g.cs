#pragma checksum "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64b9e560dbe71461e1d1dc7abca01ee4dcdc4dff"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Books : OwningComponentBase<IBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddMarkupContent(1, "\n    ");
            __builder.AddMarkupContent(2, "<thead>\n        <tr>\n            <th>Book Id</th>\n            <th>Book Name</th>\n            <th></th>\n        </tr>\n    </thead>\n\n\n    ");
            __builder.OpenElement(3, "tbody");
            __builder.AddMarkupContent(4, "\n");
#nullable restore
#line 17 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor"
         if (BookData?.Count() > 0)
        {
            //list of books
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor"
             foreach (Book b in BookData)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "                ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\n                    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 23 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor"
                         b.BookId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 24 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor"
                         b.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 25 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor"
                         b.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddMarkupContent(18, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(21, "href", 
#nullable restore
#line 28 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor"
                                                                    GetDetailsUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(23, "Details");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddMarkupContent(27, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
            __builder.AddAttribute(29, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(30, "href", 
#nullable restore
#line 32 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor"
                                                                       GetEditUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(32, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddMarkupContent(36, "\n                        ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-dnager btn-sm");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor"
                                                                          x => RemoveBook(b)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
#nullable restore
#line 39 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "            ");
            __builder.AddMarkupContent(45, "<tr>\n                <td colspan=\"5\" class=\"text-center\">No Books</td>\n            </tr>\n");
#nullable restore
#line 46 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n<br>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "class", " btn btn-success");
            __builder.AddAttribute(51, "href", "/admin/books/create");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(53, "Create");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "/Users/zacmcmillan/Library/Mobile Documents/com~apple~CloudDocs/IS junior core/WINTER 2022/IS 413/Mission Assignments/Mission_11_/Mission_11_ZM/Bookstore/Pages/Admin/Books.razor"
       

    public IBookstoreRepository repo => Service;

    //need to load the data
    public IEnumerable<Book> BookData { get; set; }

    //load up
    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        //ProjectData = await repo.Projects.ToListAsync();
        BookData = await repo.Books.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/books/details/{id}";
    public string GetEditUrl(long id) => $"/admin/books/edit/{id}";

    public async Task RemoveBook(Book b)
    {
        repo.DeleteBook(b);
        await UpdateData();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
