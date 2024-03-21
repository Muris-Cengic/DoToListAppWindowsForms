using System;
using System.Collections.Generic;

namespace DoToListAppWindowsForms.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public string Title { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public bool IsCompleted { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}
