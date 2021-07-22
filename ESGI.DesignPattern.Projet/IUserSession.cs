namespace ESGI.DesignPattern.Projet
{
    public interface IUserSession
    {
        public IUserSession GetInstance();
        public bool IsUserLoggedIn(User user);
        public User GetLoggedUser();

    }
}