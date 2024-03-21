using System;
using System.Collections.Generic;

namespace WF_Project_PRN211.DataAccess;

public partial class Author
{
    public int AuthorId { get; set; }

    public string AuthorName { get; set; } = null!;

    public string? Nationality { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
