
namespace Chat
{
    public class User
    {
       //static UserState _state = new UserState();
       // public static UserState State => _state;
       // private UserState() { }

        public string name { get; set; }
        public User CurrentUser { get; set; }
        public User UserContext { get; set; }

        public User State { get; set; }
    }
}

