namespace Services.Services;

public class PostServices
{
     private List<Post> Posts = new List<Post>();
    
    public List<Post> GetPost()
    {
        return Posts;
    }
    public void Update(Post Post,int id)
    {
        int cnt=0;
        foreach (var st in Posts)
        {
            cnt++;
           if(st.Id == id)
           {
            Posts.Remove(st);
            Posts.Insert(cnt, Post);            
           }
        }
    }
    public void GetPostById(Post st1, int id)
    {
       foreach (var st in Posts)
       {
        if(id==st1.Id)
        return;
       }
    }
   
    public void PostDelete(Post st1, int id)
    {
       foreach (var st in Posts)
       {
        if(id==st1.Id)
        Posts.Remove(st);
       }
    }

    public int PostCount(int cnt)
    {
       cnt = Posts.Count();
       return cnt;
    }
}
