using Networklabb2;

public class TeacherCollection
{
    List<Teacher> teachers = new() {
        new() {Name = "Micke", Hitpoints =100 },
        new() {Name = "Martin", Hitpoints =3 },
        new() {Name = "Lena", Hitpoints =9000 },
    };
    public IResult GetTeacher(int number)
    {
        if (number < 0 || number >= teachers.Count)
        {
            return Results.NotFound();
        }
        return Results.Ok(teachers[number]);
    }

}

