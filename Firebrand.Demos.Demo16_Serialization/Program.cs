using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
namespace Firebrand.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Person[]{
            new Person(2000){Name= "Bob" ,Age=34},
            new Person(30000){Name="John", Age=32},
            new Person(50000){Name="Barbola",Age=25}
            };
            var dir = Directory.GetCurrentDirectory();
            // Create File
            var jFileName = dir + "\\myjasonserializer.txt";
            var sFileName = dir + "\\mysoapserializer.txt";
            var xFileName = dir + "\\myxmlserializer.txt";
            var jformatter = new DataContractJsonSerializer(typeof(Person[]));
            var sformatter = new SoapFormatter();
            var formatter = new XmlSerializer(typeof(Person[]));
            // Serialize
            using (FileStream stream = File.Create(jFileName))
            {
               jformatter.WriteObject(stream, people);
                
            }
            using (FileStream stream = File.Create(xFileName))
            {
                formatter.Serialize(stream, people);
               
            }
            using (FileStream stream = File.Create(sFileName))
            {
                sformatter.Serialize(stream, people);
            }
            Console.ReadKey();
        }
    }
    [Serializable]
    public class Person : ISerializable
    {
        public string Name;
        private decimal _salary; // Willl not be serialised because it is not public
        [NonSerialized] // read by runtime serializers
        [XmlIgnore] // read by XML serializer
        [IgnoreDataMember] // wcf data content
        public int Level;
        
        public int Age { get; set; }

        // default constructor need for xml  serialization
        public Person()
        {
        }
        public Person(decimal salary)
        {
            _salary = salary;
        }
        public Person(SerializationInfo info, StreamingContext context)
        {
            // gets execute when we serialize
            Name = info.GetString("name");
            Age = info.GetInt32("age");
            _salary = info.GetDecimal("salary");
            Level = info.GetInt32("level");
        }
        public decimal GetSalary { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        { 
            // get executed when we serialize an object
            info.AddValue("name", Name);
            info.AddValue("salary", _salary);
            info.AddValue("age", Age);
            info.AddValue("level", Level);
        }
    }
}
