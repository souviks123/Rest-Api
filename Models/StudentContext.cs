using Microsoft.EntityFrameworkCore;
namespace StudentApi.Models;
public class StudentContext:DbContext{
    public StudentContext(DbContextOptions<StudentContext> options):base(options){

    }
    public DbSet<Student> Students{get;set;}
    public List<Student> getStudents()=>Students.ToList();
}