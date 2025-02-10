using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Reflection;

namespace Bibliotheque
{
    public class Bibliotheque
    {
        public List<Livre> Livres { get; set; }
        public List<Utilisateur> Utilisateurs { get; set; }

        // utilise factory pattern pour choisir la stratégie de sérialisation
        public void Serialize(string fileName)
        {
            string extension = Path.GetExtension(fileName);

            ISerializationStrategy strategy = SerializationFactory.GetSerializationStrategy(extension);

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            strategy.Serialize(this, filePath);
        }

        // utilise factory pattern pour choisir la stratégie de désérialisation
        public static Bibliotheque Deserialize(string fileName)
        {
            string extension = Path.GetExtension(fileName);

            ISerializationStrategy strategy = SerializationFactory.GetSerializationStrategy(extension);

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            return strategy.Deserialize(filePath);
        }
    }

    // Interface
    public interface ISerializationStrategy
    {
        void Serialize(Bibliotheque bibliotheque, string filePath);
        Bibliotheque Deserialize(string filePath);
    }

    // JSON 
    public class JsonSerializationStrategy : ISerializationStrategy
    {
        public void Serialize(Bibliotheque bibliotheque, string filePath)
        {
            string json = JsonConvert.SerializeObject(bibliotheque);
            File.WriteAllText(filePath, json);
        }

        public Bibliotheque Deserialize(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Bibliotheque>(json);
        }
    }

    // XML 
    public class XmlSerializationStrategy : ISerializationStrategy
    {
        public void Serialize(Bibliotheque bibliotheque, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Bibliotheque));
                serializer.Serialize(fs, bibliotheque);
            }
        }

        public Bibliotheque Deserialize(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Bibliotheque));
                return (Bibliotheque)serializer.Deserialize(fs);
            }
        }
    }

    // Factory
    public class SerializationFactory
    {
        public static ISerializationStrategy GetSerializationStrategy(string fileExtension)
        {
            if (fileExtension.Equals(".json", StringComparison.OrdinalIgnoreCase))
            {
                return new JsonSerializationStrategy();
            }
            else if (fileExtension.Equals(".xml", StringComparison.OrdinalIgnoreCase))
            {
                return new XmlSerializationStrategy();
            }
            else
            {
                throw new InvalidOperationException("Unsupported file format");
            }
        }
    }
}
