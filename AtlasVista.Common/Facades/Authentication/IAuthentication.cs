

namespace AtlasVista.Common
{
    public  interface IAuthentication
    {
        bool Register(UserDTOS user);

        bool Login(UserDTOS user);
    }
}
