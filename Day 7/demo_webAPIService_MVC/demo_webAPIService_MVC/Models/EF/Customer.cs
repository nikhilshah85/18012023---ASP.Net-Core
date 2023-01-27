using System;
using System.Collections.Generic;

namespace demo_webAPIService_MVC.Models.EF;

public partial class Customer
{
    public int CId { get; set; }

    public string? CName { get; set; }

    public string? CCity { get; set; }

    public int? CWalletBalance { get; set; }

    public bool? CProfileIsActive { get; set; }
}
