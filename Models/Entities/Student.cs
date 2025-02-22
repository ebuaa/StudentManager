﻿using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;
using StudentManager.Models.Entities;


namespace StudentManager.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool? Subscribed { get; set; }

    }
}
