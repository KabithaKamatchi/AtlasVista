using System;

namespace AtlasVista.Common
{
	public class UserDTO
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public UserType UserType { get; set; }

		public DateTime DateofBirth { get; set; }

		public Department Department { get; set; }

		public string PhoneNo { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string ConfirmPassword { get; set; }

	}
}
