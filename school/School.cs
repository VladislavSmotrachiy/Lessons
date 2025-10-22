using System.Dynamic;

public class School
{
    public string SchoolName;
    

    public List<ListOfStudents> Studens;


    public School(string schoolName)
    {
        SchoolName = schoolName;
        Studens = new List<ListOfStudents>();
    }
    public string GetNameSchool()
    {
        return ($"{SchoolName}  ");
    }

    public void AddStudent(ListOfStudents student)
    {
        

        
    }
 
}