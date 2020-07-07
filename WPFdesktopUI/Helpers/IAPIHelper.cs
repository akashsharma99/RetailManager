using System.Threading.Tasks;
using WPFdesktopUI.Models;

namespace WPFdesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}