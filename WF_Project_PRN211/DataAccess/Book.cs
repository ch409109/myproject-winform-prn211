using System;
using System.Collections.Generic;

namespace WF_Project_PRN211.DataAccess;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public int? AuthorId { get; set; }

    public int? CategoryId { get; set; }

    public int? PublicationYear { get; set; }

    public decimal? Price { get; set; }

    public virtual Author? Author { get; set; }

    public virtual Category? Category { get; set; }
}
