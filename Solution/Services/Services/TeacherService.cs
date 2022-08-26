namespace Services.Services;
using Domain.Models;

public class TeacherService
{
    private List<Teacher> Teachers = new List<Teacher>();
    
    public List<Teacher> GetTeacher()
    {
        return Teachers;
    }
    public void Update(Teacher Teacher,int id)
    {
        int cnt=0;
        foreach (var st in Teachers)
        {
            cnt++;
           if(st.Id == id)
           {
            Teachers.Remove(st);
            Teachers.Insert(cnt, Teacher);            
           }
        }
    }
    public void GetTeacherById(Teacher st1, int id)
    {
       foreach (var st in Teachers)
       {
        if(id==st1.Id)
        return;
       }
    }
   
    public void TeacherDelete(Teacher st1, int id)
    {
       foreach (var st in Teachers)
       {
        if(id==st1.Id)
        Teachers.Remove(st);
       }
    }

    public int TeacherCount(int cnt)
    {
       cnt = Teachers.Count();
       return cnt;
    }
    
}
