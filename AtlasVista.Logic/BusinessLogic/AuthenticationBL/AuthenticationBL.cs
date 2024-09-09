using System.Linq;
using AtlasVista.Common;
using AtlasVista.Data;

namespace AtlasVista.Logic
{
    public  class AuthenticationBL
    {
        public bool Register(UserDTO user)
        {
           bool userExists = AtlasVistaContext.Users.Any(u => u.Email == user.Email);

            var newUser = new User(user);

            AtlasVistaContext.Users.Add(newUser);
            return true;
        }

        public UserDTO Login(UserDTO user)
        {
          var existingUser = AtlasVistaContext.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
            
            if(existingUser != null)
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
                          
            return null;
        }
    }
}
