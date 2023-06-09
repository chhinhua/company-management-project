﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company_management.Models
{
    public enum UserRole
    {
        Admin,
        Employee
    }

    public class User
    {
        private int idUser;
        private string username;
        private string password;
        private string fullName;
        private string email;
        private string phoneNumber;
        private string address;
        private UserRole role;
        private byte[] avatar;

        public int IdUser { get => idUser; set => idUser = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public UserRole Role { get => role; set => role = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }

        public User() { }

        public User(string username, string password, string fullName, 
<<<<<<< HEAD
                    string email, string address, UserRole role)
=======
                    string email, string phoneNumber, string address, UserRole role)
>>>>>>> hua
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Role = role;
        }

        public User(string username, string password, string fullName, 
<<<<<<< HEAD
                    string email, string address, UserRole role, byte[] avatar)
=======
                    string email, string phoneNumber, string address, UserRole role, byte[] avatar)
>>>>>>> hua
        {
            Username = username;
            Password = password;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Role = role;
            Avatar = avatar;
        }

        public override string ToString() 
            => $"Username: {Username}\nFullName: {FullName}" +
<<<<<<< HEAD
               $"\nEmail: {Email}\nAddress: {Address}\nRole: {Role}";
=======
               $"\nEmail: {Email}\nPhone: {PhoneNumber}" +
               $"\nAddress: {Address}\nRole: {Role}";
>>>>>>> hua

    }
}
