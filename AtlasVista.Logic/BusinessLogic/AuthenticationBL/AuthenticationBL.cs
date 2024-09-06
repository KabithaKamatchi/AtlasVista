using System.Data.Common;
using AtlasVista.Common;
using AtlasVista.Data;

namespace AtlasVista.Logic
{
    public  class AuthenticationBL
    {
        public bool Register(UserDTO user)
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

            var newUser = new User(user);

            AtlasVistaContext.Users.Add(newUser);
            return true;
        }

        public UserDTO Login(UserDTO user)
        {
            foreach(var existingUser in AtlasVistaContext.Users )           
            {
                if (existingUser.Email == user.Email)
                {
                    if( existingUser.Password == user.Password)
                    {
                        return new  UserDTO
                        {
                            Id = existingUser.Id,
                            Name = existingUser.Name,
                            UserType = existingUser.UserType,
							DateofBirth = existingUser.DateofBirth,
							Department = existingUser.Department,
							PhoneNo = existingUser.PhoneNo,
							Email = existingUser.Email,
							Password = existingUser.Password

						};
                    }
                }
            }
            return null;
        }
    }
}
