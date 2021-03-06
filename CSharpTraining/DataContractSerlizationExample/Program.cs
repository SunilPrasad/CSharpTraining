﻿using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;

namespace DataContractSerializerExample
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                WriteObject("DataContractSerializerExample.xml");
                ReadObject("DataContractSerializerExample.xml");

            }

            catch (SerializationException serExc)
            {
                Console.WriteLine("Serialization Failed");
                Console.WriteLine(serExc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(
                    "The serialization operation failed: {0} StackTrace: {1}",
                    exc.Message, exc.StackTrace);
            }

            finally
            {
                Console.WriteLine("Press <Enter> to exit....");
                Console.ReadLine();
            }
        }

        public static void WriteObject(string fileName)
        {
            Console.WriteLine("Creating a Person object and serializing it.");

            Person p1 = new Person("Zighetti", "Barbara", 101);

            FileStream writer = new FileStream(fileName, FileMode.Create);

            DataContractSerializer ser = new DataContractSerializer(typeof(Person));

            ser.WriteObject(writer, p1);

            writer.Close();
        }

        public static void ReadObject(string fileName)
        {
            Console.WriteLine("Deserializing an instance of the object.");
            FileStream fs = new FileStream(fileName,FileMode.Open);
            XmlReader reader = new XmlTextReader(fs);

            DataContractSerializer ser = new DataContractSerializer(typeof(Person));

            // Deserialize the data and read it from the instance.
            Person deserializedPerson = (Person)ser.ReadObject(reader, true);
            reader.Close();
            fs.Close();

            Console.WriteLine(String.Format("{0} {1}, ID: {2}",
                deserializedPerson.FirstName, deserializedPerson.LastName,
                deserializedPerson.ID));
        }
    }

    // You must apply a DataContractAttribute or SerializableAttribute
    // to a class to have it serialized by the DataContractSerializer.
    [DataContract(Name = "Customer")]
    class Person
    {
        [DataMember()]
        public string FirstName;

        [DataMember]
        public string LastName;

        [DataMember()]
        public int ID;

        public Person(string newfName, string newLName, int newID)
        {
            FirstName = newfName;
            LastName = newLName;
            ID = newID;
        }
       
    }

    
}