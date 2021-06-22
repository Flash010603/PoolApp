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
        private IMongoCollection<DataTable> _datatable;

        public PoolServices(IPoolSettings settings)
        {
            var client = new MongoClient(settings.Server);
            var db = client.GetDatabase(settings.Database);
            _user = db.GetCollection<User>("User");
            _poolplace = db.GetCollection<Poolplace>("PoolSwimm");
            _datatable = db.GetCollection<DataTable>("DataTable");
        }

        public List<User> TraerUsuarios()
        {
            return _user.Find(u => true).ToList();
        }
        public User TraerUsuarioId(string id)
        {
            return _user.Find(u => u.Id == id).SingleOrDefault();
        }
        public User LogInUser(string pass, string user)
        {
            string passEncript = EncriptarPassword(pass);
            return _user.Find(u => u.Username == user && u.Password == passEncript).SingleOrDefault();
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

        // ===================== Pool Swim =============================

        public List<Poolplace> TraerPoolId(string id)
        {
            return _poolplace.Find(u => u.Id == id).ToList();
        }

        public Poolplace TraerPoolIdUsuario(string id)
        {
            return _poolplace.Find(u => u.IdUser == id).SingleOrDefault();
        }

        public Poolplace CreateNewPool(Poolplace pool)
        {
            _poolplace.InsertOne(pool);
            return pool;
        }

        public Poolplace UpdatePool(Poolplace pool)
        {
            _poolplace.ReplaceOne(u => u.Id == pool.Id, pool);
            return pool;
        }

        public void DeletePool(string id)
        {
            _poolplace.DeleteOne(u => u.Id == id);
        }

        // ===================== Data table =============================
        public List<DataTable> TraerDataTable()
        {
            return _datatable.Find(u => true).ToList();
        }

        public DataTable CreateDataTable(DataTable dt)
        {
            DataTable data = new DataTable();
            
            data.Fecha = dt.Fecha;
            data.Temp_max = dt.Temp_max;
            data.Temp_min = dt.Temp_min;
            data.Ph_max = dt.Ph_max;            
            data.Ph_min = dt.Ph_min;            
            data.IdUser = dt.IdUser;

            _datatable.InsertOne(data);
            return data;
        }
    }
}