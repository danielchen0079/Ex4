using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Department{
    [Key]
    public int DepartmentId {get;set;}
    public string? Name {get;set;}
    public int? UniversityId {get;set;}
    [ForeignKey("UniversityId")]
    public University? University {get;set;}
    public List<Course>? Courses {get;set;}
}