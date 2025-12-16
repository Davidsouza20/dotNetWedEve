using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Model
{
    public class SimpleAuthService
    {
        public bool IsAuthenticated { get; private set; } = false;
        public string? Username { get; private set; }

        public void Login(string username)
        {
            IsAuthenticated = true;
            Username = username;
        }

        public void Logout()
        {
            IsAuthenticated = false;
            Username = null;
        }
    }
}
