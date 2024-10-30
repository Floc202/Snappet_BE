﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SWD392.Snappet.Repository.BusinessModels;

public partial class Pet
{
    public int PetId { get; set; }

    public int UserId { get; set; }

    public int CategoryId { get; set; }

    public string ProfilePhotoUrl { get; set; }

    public DateTime CreatedAt { get; set; }

    public string PetName { get; set; }

    public string Description { get; set; }

    public virtual PetCategory Category { get; set; }

    public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>();

    public virtual User User { get; set; }
}