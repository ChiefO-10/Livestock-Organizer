using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace LivestockDataAccess
{
    public class AnimalAdapter
    {
        public List<Animal> GetAllAnimals(string cnnString)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnVal(cnnString)))
            {
                return connection.Query<Animal>("dbo.spGetAllLivestock").ToList();
            }

        }
        public List<Animal> GetAnimalsByNumber(string cnnString,string animalNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnVal(cnnString)))
            {
                return connection.Query<Animal>($"spGetAnimalByNumber @AnimalNumber", new { AnimalNumber = animalNumber }).ToList();
            }
        }
    }
}
