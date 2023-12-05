﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DTD_Mentorship_Project.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public bool? Mentorship { get; set; }

    public bool? Intern { get; set; }

    public bool? Mentor { get; set; }


    public virtual ICollection<MentorMentee> MentorMenteeMentee { get; set; } = new List<MentorMentee>();

    public virtual ICollection<MentorMentee> MentorMenteeMentor { get; set; } = new List<MentorMentee>();

    public virtual ICollection<UserArea> UserArea { get; set; } = new List<UserArea>();
}