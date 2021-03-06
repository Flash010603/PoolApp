using System;
using System.Collections.Generic;
using System.IO.Ports;
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

        SerialPort sp = new SerialPort();
        

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

        public Poolplace TraerPoolId(string id)
        {
            return _poolplace.Find(u => u.Id == id).SingleOrDefault();
        }

        public List<Poolplace> TraerPoolIdUsuario(string id)
        {
            
            return _poolplace.Find(u => u.IdUser == id).ToList();
        }

        public Poolplace CreateNewPool(Poolplace pool)
        {
            _poolplace.InsertOne(pool);
            return pool;
        }

        public Poolplace UpdatePool(Poolplace pool)
        {
            sp.PortName = "COM6";
            sp.BaudRate = 9600;
            sp.DataBits = 8;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.Handshake = Handshake.None;
            sp.Open();
            string data_ph = sp.ReadLine();
            string data_temp = sp.ReadLine();

            string ph = data_ph.Substring(0, data_ph.Length - 2);
            string temp = data_temp.Substring(0, data_temp.Length - 2);
            
            decimal ph_final = Convert.ToDecimal(ph) / 10;
            decimal temp_final = Convert.ToDecimal(temp) / 10;

            pool.Ph_current = ph_final;
            pool.Temp_current = temp_final;

            sp.Close();


            _poolplace.ReplaceOne(u => u.Id == pool.Id, pool);
            return pool;
        }

        public void DeletePool(string id)
        {
            _poolplace.DeleteOne(u => u.Id == id);
        }

       

        // ===================== Data table =============================
        public List<DataTable> TraerDataTable(string id)
        {
            return _datatable.Find(u => u.IdUser == id).ToList();
        }

        public DataTable CreateDataTable(DataTable dt)
        {
            

            DataTable data = new DataTable();

            data.Fecha = dt.Fecha;
            data.Temp_max_register = dt.Temp_max_register;
            data.Temp_min_register = dt.Temp_min_register;
            data.Ph_max_register = dt.Ph_max_register;
            data.Ph_min_register = dt.Ph_min_register;
            data.IdUser = dt.IdUser;

            _datatable.InsertOne(data);

            return data;
        }
    }
}