using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
<<<<<<< HEAD
=======
using MongoProject.Model;
>>>>>>> Development

namespace DAL
{
    public class DAO
    {
        private MongoClient client;
<<<<<<< HEAD
=======
        private IMongoDatabase db;
        private IMongoCollection<BsonDocument> collection;
>>>>>>> Development

        public DAO()
        {
            client = new MongoClient("mongodb+srv://projecttickets:wFK6NeiHfAKvHAiB@cluster0.tpy88by.mongodb.net/");
<<<<<<< HEAD
        }

        public List<Databases_Model> GetDatabases()
        {
            List<Databases_Model> all_databases = new List<Databases_Model>();
            
            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                all_databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
            }
            return all_databases;
        }
=======
            db = client.GetDatabase("TicketProject");
        }

        /*public void AddEmployee(Employee employee)
        {
            collection = db.GetCollection<BsonDocument>("Employees");
            var document = new BsonDocument
            {
                {"FirstName", employee.firstName },
                {"LastName", employee.lastName },
                {"username", employee.username },
                {"password", employee.password },
                {"EmailAddress", employee.email },
                {"PhoneNumber", employee.phoneNumber },
                {"Location", employee.location },
                {"isServiceDesk", employee.isServiceDesk }
            };
            collection.InsertOne(document);
        }*/

        
>>>>>>> Development
    }


}
