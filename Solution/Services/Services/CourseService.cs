namespace Services.Services;
using Domain.Models;

public class CourseService
{
     private List<Course> Courses = new List<Course>();
    
    public List<Course> GetCourse()
    {
        return Courses;
    }
    public void Update(Course Course,int id)
    {
        int cnt=0;
        foreach (var st in Courses)
        {
            cnt++;
           if(st.Id == id)
           {
            Courses.Remove(st);
            Courses.Insert(cnt, Course);            
           }
        }
    }
    public void GetCourseById(Course st1, int id)
    {
       foreach (var st in Courses)
       {
        if(id==st1.Id)
        return;
       }
    }
   
    public void CourseDelete(Course st1, int id)
    {
       foreach (var st in Courses)
       {
        if(id==st1.Id)
        Courses.Remove(st);
       }
    }

    public int GetVotesById(int cnt)
    {
       cnt = Courses.Count();
       return cnt;
    }
}
