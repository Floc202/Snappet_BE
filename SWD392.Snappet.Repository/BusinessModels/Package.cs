﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SWD392.Snappet.Repository.BusinessModels;

public partial class Package
{
    public int PackageId { get; set; }

    public int UserId { get; set; }

    public string PackageName { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Price { get; set; }

    public string Status { get; set; }

    public virtual User User { get; set; }
}