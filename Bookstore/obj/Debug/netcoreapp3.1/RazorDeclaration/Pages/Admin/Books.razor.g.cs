// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
