using System;
using System.Collections.Generic;

namespace occupy.Models.Entities;

public partial class Signin
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? UsernamePlaceholder { get; set; }

    public string? PasswordPlaceholder { get; set; }

    public string? BtnSubmit { get; set; }

    public string? BtnClose { get; set; }
}
