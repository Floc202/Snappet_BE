﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Snappet_Be.Models;

public partial class Post
{
    public int PostId { get; set; }

    public int UserId { get; set; }

    public string Content { get; set; }

    public int? PhotoId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Photo Photo { get; set; }

    public virtual User User { get; set; }
}