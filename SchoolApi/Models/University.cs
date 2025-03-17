using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class University{
    [Key]
    public int UniversityId {get;set;}
    public string? Name {get;set;}
    public string? Location {get;set;}
    public List<Department>? Departments {get;set;}
}