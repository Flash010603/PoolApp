using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using MongoDB.Driver;
using Pool.Core.Models;

namespace Pool.Infraestructure.Data
{
    public class PoolServices
    {
        private IMongoCollection<User> _user;
        private IMongoCollection<Poolplace> _poolplace;

        public PoolServices(IPoolSettings settings)
        {
            var client = new MongoClient(settings.Server);
            var db = client.GetDatabase(settings.Database);
            _user = db.GetCollection<User>("User");
            _poolplace = db.GetCollection<Poolplace>("PoolSwimm");
        }

        // retornar un usuario
        public User TraerUsuarioId(string id)
        {
            return _user.Find(u => u.Id == id).SingleOrDefault();
        }

        public User CreateUser(User user)
        {
            User u = new User();
            u.Name = user.Name;
            u.Email = user.Email;
            u.Username = user.Username;
            string newPassword = EncriptarPassword(user.Password);
            u.Password = newPassword;
            _user.InsertOne(u);
            return u;
        }

        public void UpdateUser(string id, User user)
        {
            _user.ReplaceOne(u => u.Id == id, user);
        }

        public void DeleteUser(string id)
        {
            _user.DeleteOne(u => u.Id == id);
        }

        public string EncriptarPassword(string pass)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(pass));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        // ==============================================================

        public Poolplace TraerPoolId(string id)
        {
            return _poolplace.Find(u => u.Id == id).SingleOrDefault();
        }

    }
}