using System;
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

			if(userExists)
			{
				throw new InvalidOperationException("User already exists");
			}

			var newUser = new User(user);

			AtlasVistaContext.Users.Add(newUser);
			return true;
		}

		public UserDTO Login(string strEmail, string strPassword)
		{
			User existingUser = AtlasVistaContext.Users.FirstOrDefault(u => u.Email == strEmail && u.Password == strPassword);

			if(existingUser != null)
			{
				return existingUser.GetUserDto();
			}

			return default;
		}
	}
}
