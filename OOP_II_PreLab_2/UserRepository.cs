using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace OOP_II_PreLab_2
{
    internal class UserRepository : IUserRepository
    {
        public async Task<bool> Insert(User user)
        {
            using (IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
            {
                var result = await db.ExecuteAsync(OOP_II_PreLab_2.Properties.Resources.InsertUser, new { UserName = user.Username, Password = user.Password, FullName = user.FullName, PhoneNumber = user.PhoneNumber, Address = user.Address, City = user.City, Country = user.Country, Email = user.Email });
                return result > 0;
            }
        }
    }
}
