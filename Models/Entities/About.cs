using System;
using System.Collections.Generic;

namespace occupy.Models.Entities;

public partial class About
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? Detail { get; set; }

    public bool? Isview { get; set; }

    public int? Order { get; set; }

    public string? Image { get; set; }
}
