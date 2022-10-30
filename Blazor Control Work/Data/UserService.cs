namespace Blazor_Control_Work.Data
{
    public class UserService
    {
        public User user { get; set; }
        public bool authorizationCheck { get; set; }
        public void SetUser(User user)
        {
            this.user = user;
        }
    }
}
