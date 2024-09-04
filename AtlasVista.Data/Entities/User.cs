using System;
using AtlasVista.Common;

namespace AtlasVista.Data
{
	public class User
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public UserType UserType { get; set; }

		public DateTime DateofBirth { get; set; }

		public Department Department { get; set; }

		public string PhoneNo { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }


		public User() { }

		public User(UserDTOS user)
		{
			Id = user.Id;
			Name = user.Name;
			UserType = user.UserType;
			DateofBirth = user.DateofBirth;
			Department = user.Department;
			PhoneNo = user.PhoneNo;
			Email = user.Email;
			Password = user.Password;
		}
	}
}
