using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dekstop_csharp.model
{
    
    internal class sessionUser
    {
        public sessionUser(int id, string username, string password, string nama, string level)
        {
            Id_petugas = id;
            Username = username;
            Password = password;
            Nama_petugas = nama;
            Level = level.ToLower();
            IsLoggedin = true;

        }

        public static void Clearsession(string id_petugas, string username, string password, string nama_petugas, string level)
        {
            id_petugas = null;
            username = null;
            password = null;
            nama_petugas = null;
            level = null;
            IsLoggedin = IsLoggedin;

        }

        public static int Id_petugas { get; set; }
        public static  string Username { get; set; }
        public static string Password { get; set; }
        public static string Nama_petugas { get; set; }
        public static string Level { get; set; }
        public static string IsLoggedin { get; set; }

        public static bool IsAdmin()
        {
            return Level == "admin";
        }
    }
}
