﻿using company_management.Models;
using System.Windows.Forms;

namespace company_management.Controllers
{
    public class UserDAO
    {
        private readonly DBConnection dBConnection;

        public UserDAO() => dBConnection = new DBConnection();

        public void loadUser(DataGridView dataGridView) => dBConnection.loadData(dataGridView, "users");

        public void addUser(User user)
        {
<<<<<<< HEAD
            string sqlStr = string.Format("INSERT INTO users(username, password, fullname, email, address, role)" +
                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                   user.Username, user.Password, user.FullName, user.Email, user.Address, user.Role);
=======
            string sqlStr = string.Format("INSERT INTO users(username, password, fullname, email, phoneNumber, address, role)" +
                   "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                   user.Username, user.Password, user.FullName, user.Email, user.PhoneNumber, user.Address, user.Role);
>>>>>>> hua
            dBConnection.executeQuery(sqlStr);
        }

        public void updateUser(User user)
        {
            string sqlStr = string.Format("UPDATE users SET " +
                   "username = '{0}', password = '{1}', fullname = '{2}', email = '{3}', address = '{4}', role = '{5}' WHERE id = '{6}'",
                   user.Username, user.Password, user.FullName, user.Email, user.Address, user.Role, user.IdUser);
            dBConnection.executeQuery(sqlStr);
        }

        public void deleteUser(int id)
        {
            string sqlStr = string.Format("DELETE FROM users WHERE id = '{0}'", id);
            dBConnection.executeQuery(sqlStr);
        }

        //=================================================

        /*public byte[] ConvertImageToByteArray(PictureBox pictureBox)
        {
            byte[] imageBytes = null;
            if (pictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }
            return imageBytes;
        }*/

        
    }
}
