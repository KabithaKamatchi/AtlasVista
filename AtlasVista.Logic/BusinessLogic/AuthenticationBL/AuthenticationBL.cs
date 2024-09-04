using AtlasVista.Common;
using AtlasVista.Data;

namespace AtlasVista.Logic.BusinessLogic.AuthenticationBL
{
    public  class AuthenticationBL:IAuthentication
    {
            public bool Register(UserDTOS user)
            {
                    foreach( var existingUser in AtlasVistaContext.Users)
                    {
                        if(existingUser.Email == user.Email)
                        {
                            return false;
                        }
                    }

                    if(user.Password != user.ConfirmPassword)
                    {
                        return false;
                    }

                    var newUser = new User
                    {
                        Id = user.Id,
                        Name = user.Name,
                        UserType = user.UserType,
                        DateofBirth = user.DateofBirth,
                        Department = user.Department,
                        PhoneNo = user.PhoneNo,
                        Email = user.Email,
                        Password = user.Password
                    };

                    AtlasVistaContext.Users.Add(newUser);
                    return true;
            }

            public bool Login(UserDTOS user)
            {
                    foreach(var existingUser in AtlasVistaContext.Users )           
                    {
                        if (existingUser.Email == user.Email)

                        {
                            return existingUser.Password == user.Password;
                        }
                   
                    }

                    return false;
            }
    }
}
