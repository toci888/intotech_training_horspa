using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.HornetReflection
{
    public class ReflectionExample
    {
        public void Hacking()
        {
            ReflectionClient reflectionClient = new ReflectionClient();

            PropertyInfo prI = reflectionClient.GetType().GetProperty("TypeName", BindingFlags.Instance | BindingFlags.NonPublic);

            prI.SetValue(reflectionClient, "Reflection hacker");
            //reflectionClient.
        }

        public void Models()
        {
            ReflectionClient reflectionClient = new ReflectionClient();

            PropertyInfo[] prI = reflectionClient.GetType().GetProperties();
        }
    }

    public class ReflectionClient
    {
        public int Id { get; set; }

        public double Cost;
        protected string Name { get; set; }

        private string TypeName { get; set; }

    }
}
