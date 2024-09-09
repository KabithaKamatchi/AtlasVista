using System.Linq;
using AtlasVista.Common;
using AtlasVista.Data;

namespace AtlasVista.Logic
{
	public class AuthenticationBL
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
			User existingUser = AtlasVistaContext.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);

			if(existingUser != null)
			{
				return existingUser.GetUserDto();
			}

			return default;
		}
	}
}
