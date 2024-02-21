using DataLibrary.DataAccesss;
using DataLibrary.Models;
using System.Collections.Generic;

namespace DataLibrary.BusinessLogic
{
    public static class PartnerProcessor
    {
        public static int CreatePartner(string firstName, string lastName, string address, string partnerNumber,
            string croatianPIN, int partnerTypeId, string createByUser,
            bool isForeign, string externalCode, string gender)
        {
            Partner data = new Partner
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                PartnerNumber = partnerNumber,
                CroatianPIN = croatianPIN,
                PartnerTypeId = partnerTypeId,
                CreateByUser = createByUser,
                IsForeign = isForeign,
                ExternalCode = externalCode,
                Gender = gender

            };

            string sql = @"insert into dbo.Partner (FirstName, LastName, Address, PartnerNumber, CroatianPIN,
                        PartnerTypeId, CreateByUser, IsForeign, ExternalCode, Gender, CreatedAtUtc) values 
                        (@FirstName, @LastName, @Address, @PartnerNumber, @CroatianPIN, @PartnerTypeId, @CreateByUser, 
                        @IsForeign, @ExternalCode, @Gender, GETUTCDATE());";

            return SqlDataAccess.SaveData(sql, data);

        }

        public static List<Partner> LoadPartners()
        {
            string sql = @"select Id, FirstName, LastName, Address, PartnerNumber, CroatianPIN,  
                          PartnerTypeId, CreateByUser, IsForeign, ExternalCode, Gender, CreatedAtUtc from dbo.Partner;";

            return SqlDataAccess.LoadData<Partner>(sql);
        }

        public static List<AllDetails> LoadDetails(int id)
        {
            string sql = @"select FirstName, LastName, Address, PartnerNumber, CroatianPIN,  
                          PartnerTypeId, CreateByUser, IsForeign, ExternalCode, Gender, CreatedAtUtc, PolicyNumber, PolicyAmount from dbo.Partner left join dbo.Policy on dbo.Partner.Id = dbo.Policy.PartnerId where dbo.Partner.Id =" + id.ToString() + ";";

            return SqlDataAccess.LoadData<AllDetails>(sql);
        }
    }
}
