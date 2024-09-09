﻿using System;
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


		public User(UserDTO user)
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

		public UserDTO GetUserDto()
		{
			return new UserDTO 
			{ 
				Id = this.Id, 
				Name = this.Name, 
				UserType = this.UserType, 
				DateofBirth = this.DateofBirth, 
				Department = this.Department, 
				PhoneNo = this.PhoneNo, 
				Email = this.Email 
			};
		}
	}
}
