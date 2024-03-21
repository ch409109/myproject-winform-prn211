using System;
using System.Collections.Generic;

namespace WF_Project_PRN211.DataAccess;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
