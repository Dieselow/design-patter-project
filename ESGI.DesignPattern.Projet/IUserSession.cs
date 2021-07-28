namespace ESGI.DesignPattern.Projet
{
    public interface IUserSession
    {
        public bool IsUserLoggedIn(User user);
        public User GetLoggedUser();

    }
}