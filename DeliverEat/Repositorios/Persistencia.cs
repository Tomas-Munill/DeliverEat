using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DeliverEat.Repositorios
{
    public class Persistencia
    {
    }

    public class Repository<T> : List<T> where T : class
    {
        private string filePath;

        public Repository(string filePath)
        {
            this.filePath = filePath;
            string datos = Path.Combine(Environment.CurrentDirectory, @"Datos");


            if (!Directory.Exists(datos))
            {
                Directory.CreateDirectory(datos);
            }

            if (!File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);
                fs.Close();
            }

            Load();
        }

        private void Load()
        {
            string contents = File.ReadAllText(filePath);
            if (contents == null)
                return;

            T[] values = JsonConvert.DeserializeObject<T[]>(contents);

            if (values != null)
                AddRange(values);
        }

        public void Commit()
        {
            string serialized = JsonConvert.SerializeObject(ToArray());

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(serialized);
            }
        }

        public T[] SelectAll()
        {
            return ToArray();
        }

        public T[] Where(Func<T, bool> where)
        {
            return this.Where<T>(where).ToArray();
        }
    }
    
}
