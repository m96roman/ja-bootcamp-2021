using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;

namespace LiveCoding8
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------- Get Assembly types

            //Assembly assembly = Assembly.GetExecutingAssembly();
            //Type[] allTypes = assembly.GetTypes();

            //foreach (var type in allTypes)
            //{
            //    Console.WriteLine(type.FullName);
            //}


            //---------------- Get types information -----------------------

            //Type personType = typeof(Person);
            //Type weekDayEnum = typeof(WeekDay);

            //Console.WriteLine("----PERSON----");
            //Console.WriteLine(personType.IsPublic);
            //Console.WriteLine(personType.IsClass);
            //Console.WriteLine(personType.IsAbstract);
            //Console.WriteLine(personType.IsEnum);

            //Console.WriteLine("----WeekDay----");
            //Console.WriteLine(weekDayEnum.IsPublic);
            //Console.WriteLine(weekDayEnum.IsClass);
            //Console.WriteLine(weekDayEnum.IsAbstract);
            //Console.WriteLine(weekDayEnum.IsEnum);

            //--------------- Get methods and fields and write their information -----------------------------


            //Type personType = typeof(Person);

            //MethodInfo[] methods = personType.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            //FieldInfo[] fields = personType.GetFields();

            //foreach (var methodInfo in methods)
            //{
            //    Console.WriteLine(methodInfo.Name);
            //}

            //Console.WriteLine("--------------------------------");

            //foreach (var fieldInfo in fields)
            //{
            //    Console.WriteLine(fieldInfo.Name);
            //}


            //----------------Invoke method using reflection -------------------

            //var personType = typeof(Person);
            //var person = new Person
            //{
            //    FullName = "Mykhailo Roman"
            //};

            //MethodInfo method = personType.GetMethod("GetName", BindingFlags.NonPublic | BindingFlags.Instance);
            //var result = method.Invoke(person, null);

            //Console.WriteLine(result);

            //--------------- Get all properties and their attributes ---------

            //var personType = typeof(Person);
            //var properties = personType.GetProperties();

            //foreach (var propertyInfo in properties)
            //{
            //    var attributes = propertyInfo.GetCustomAttributes();
            //    Console.WriteLine(propertyInfo.Name);
            //    foreach (var attribute in attributes)
            //    {
            //        Console.WriteLine(attribute);
            //    }

            //    Console.WriteLine("-------------------------------");
            //}

            //-----------  Get methods without specific attribute --------- 

            //var personType = typeof(Person);
            //var methods = personType.GetMethods();
            //var nonObsoleteMethods = methods.Where(it => it.GetCustomAttribute<ObsoleteAttribute>() == null);

            //foreach (var nonObsoleteMethod in nonObsoleteMethods)
            //{
            //    Console.WriteLine(nonObsoleteMethod.Name);
            //}

            //---------- Dispose MemoryStream --------------------

            //using (var memoryStream = new MemoryStream())
            //{

            //}

            //-------------------------------------------------

            // ----- Custom disposable object --------
            //var memoryStreamWrapper = new MemoryStreamWrapper();
            //memoryStreamWrapper.Dispose();
        }
    }

    public class Person
    {
        private Lazy<List<int>> someInts = new Lazy<List<int>>(() => Enumerable.Range(0, 10000000).ToList());

        [JsonIgnore]
        public string FullName { get; set; }

        [JsonIgnore]
        [Obsolete]
        public int Age { get; set; }

        [Obsolete]
        public string GetName()
        {
            return $"My name is {FullName}";
        }

        public int GetAge()
        {
            return Age;
        }


        public List<int> GetInts()
        {
            Console.WriteLine(someInts.IsValueCreated);

            return someInts.Value;
        }
    }

    enum WeekDay
    {
        [Description("This is Monday")]
        Monday,
        [Description("This is second day of week")]
        Tuesday
    }


    [AttributeUsage(AttributeTargets.Field)]
    public class DescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public DescriptionAttribute(string description)
        {
            Description = description;
        }
    }

    public static class EnumExtension
    {
        public static string ToDescription<T>(this T enumeration) where T : Enum
        {
            return enumeration
                .GetType()
                .GetField(enumeration.ToString())
                .GetCustomAttribute<DescriptionAttribute>()
                .Description;
        }
    }

    public class MemoryStreamWrapper : IDisposable
    {
        private MemoryStream _stream;

        public MemoryStreamWrapper()
        {
            _stream = new MemoryStream();
        }

        public void Dispose()
        {
            _stream.Dispose();
        }
    }
}
