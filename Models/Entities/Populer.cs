using System;
using System.Collections.Generic;

namespace occupy.Models.Entities;

public partial class Populer
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public sbyte? UrlId { get; set; }

    public string? UrlText { get; set; }

    public string? UrlTarget { get; set; }

    public bool? Isview { get; set; }

    public int? Order { get; set; }
}
