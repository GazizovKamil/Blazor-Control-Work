using EditorUnit;

namespace Blazor_Control_Work.Data
{
    public class SingletonService
    {
        public User? user { get; set; }
        public Project project;

        public void SetUser(string name)
        {
            user = Mongo.Find(name);
        }

        public void SetUser(User user)
        {
            this.user = user;
        }

        public User GetUser()
        {
            return user;
        }
    }
}
