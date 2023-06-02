using System;
using System.Collections.Generic;

namespace occupy.Models.Entities;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Password { get; set; }

    public DateTime? Date { get; set; }

    public string? Email { get; set; }
}
