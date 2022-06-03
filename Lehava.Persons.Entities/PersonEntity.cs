using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Lehava.Persons.Entities
{
    public class PersonEntity //: Model.Person
    {
        System.Collections.Generic.List<Model.Person> persons = new List<Model.Person>();
        Model.Person p;
        // Saved in UI project - Startup Project
        // string path = @"persons.txt";
        // Saved in current project
        string path = @".\..\..\..\Lehava.Persons.Entities\bin\Debug\persons.txt";

        public void AddRecord(string name, int age)
        {
            p = new Model.Person();
            p.Name = name;
            p.Age = age;
            persons.Add(p);
        }

        // Serialization
        public void SaveAll()
        {
            string str = JsonSerializer.Serialize(persons);
            File.WriteAllText(path, str);
        }

        // Deserialization
        public void Load()
        {
            string loadStr = File.ReadAllText(path);
            Model.Person[] loadPersons = JsonSerializer.Deserialize<Model.Person[]>(loadStr);
        }
    }
}
