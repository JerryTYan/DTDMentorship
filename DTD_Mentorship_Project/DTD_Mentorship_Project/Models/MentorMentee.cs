﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DTD_Mentorship_Project.Models;

public partial class MentorMentee
{
    public int MentorMenteeId { get; set; }

    public int MentorId { get; set; }

    public int MenteeId { get; set; }

    public virtual User Mentee { get; set; }

    public virtual User Mentor { get; set; }
}