namespace ESGI.DesignPattern.Projet
{
    public class UserSession: IUserSession
    {
        private static readonly UserSession userSession = new();

        private UserSession() { }

        public static UserSession GetInstance()
        {
            return userSession;
        }

        IUserSession IUserSession.GetInstance()
        {
            return GetInstance();
        }

        public bool IsUserLoggedIn(User user)
        {
            throw new DependendClassCallDuringUnitTestException(
                "UserSession.IsUserLoggedIn() should not be called in an unit test");
        }

        public User GetLoggedUser()
        {
            throw new DependendClassCallDuringUnitTestException(
                "UserSession.GetLoggedUser() should not be called in an unit test");
        }
    }
}