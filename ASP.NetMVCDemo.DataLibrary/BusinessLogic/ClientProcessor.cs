using ASP.NetMVCDemo.DataLibrary.DataAccess;
using ASP.NetMVCDemo.DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NetMVCDemo.DataLibrary.BusinessLogic
{
    public static class ClientProcessor
    {
        public static int CreateClient(string firstName, string lastname, string companyName, string companyAddress, string companyPostcode, string emailAddress, string phoneNumber)
        {
            ClientModel data = new ClientModel
            {
                FirstName = firstName,
                LastName = lastname,
                CompanyName = companyName,
                CompanyAddress = companyAddress,
                CompanyPostCode = companyPostcode,
                EmailAddress = emailAddress,
                PhoneNumber = phoneNumber
            };
            string sql = @"insert into dbo.Client (FirstName, LastName, CompanyName, CompanyAddress, CompanyPostcode, EmailAddress, PhoneNumber)
                            values (@FirstName, @LastName, @CompanyName, @CompanyAddress, @CompanyPostcode, @EmailAddress, @PhoneNumber);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<ClientModel> LoadClients()
        {
            string sql = @"select FirstName, LastName, CompanyName, CompanyAddress, CompanyPostcode, EmailAddress, PhoneNumber
                            from dbo.Client;";

            return SqlDataAccess.LoadData<ClientModel>(sql);
        }
    }
}
