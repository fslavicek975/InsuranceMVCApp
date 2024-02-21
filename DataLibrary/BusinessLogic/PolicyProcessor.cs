using DataLibrary.DataAccesss;
using DataLibrary.Models;

namespace DataLibrary.BusinessLogic
{
    public static class PolicyProcessor
    {
        public static int CreatePolicy(string policyNumber, decimal policyAmount, int partnerId)
        {
            Policy data = new Policy
            {
                PolicyNumber = policyNumber,
                PolicyAmount = policyAmount,
                PartnerId = partnerId
            };

            string sql = @"INSERT INTO dbo.Policy (PolicyNumber, PolicyAmount, PartnerId) 
                       VALUES (@PolicyNumber, @PolicyAmount, @PartnerId);";

            return SqlDataAccess.SaveData(sql, data);
        }
    }
}