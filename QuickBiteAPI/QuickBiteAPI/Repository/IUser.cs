using QuickBiteAPI.Models;

namespace QuickBiteAPI.Repository
{
    public interface IUser
    {
        void addUser(UserModel user);
        IEnumerable<UserModel> getUsers();

    }
}
