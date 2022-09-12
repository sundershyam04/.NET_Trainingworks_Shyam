using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\SHYAM SUNDER\Desktop\HandsOn .NET\handon_assignments©\12Sept_Reflection_Attributes\MathsLogic\bin\Debug\MathsLogic.dll";

            Assembly asm = Assembly.LoadFrom(path);
            //  Assembly asm1=Assembly.GetAssembly(typeof(path));
            Type[] types = asm.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine("name= " + item.Name);//classname
                Console.WriteLine("Full Name= " + item.FullName);//assemblyname/namespacename and class
                Console.WriteLine("IS Class=" + item.IsClass);
                Console.WriteLine("IS Absatract=" + item.IsAbstract);
                Console.WriteLine("Whether public " + item.IsPublic);


                Console.WriteLine("-------Member info----------");
                MemberInfo[] minfo = item.GetMembers();

                foreach (var minfoitem in minfo)
                {

                    Console.WriteLine("Member Info Name= " + minfoitem.Name);

                    Console.WriteLine("Declaring type=" + minfoitem.DeclaringType);
                }

                Console.WriteLine("--------Method info-------------");
                MethodInfo[] methodInfos = item.GetMethods();
                foreach (var methodInfosItem in methodInfos)
                {

                    Console.WriteLine("name = " + methodInfosItem.Name);
                    Console.WriteLine("IS PUBLIC =" + methodInfosItem.IsPublic);
                    Console.WriteLine("IS STATIC =" + methodInfosItem.IsStatic);

                    ParameterInfo[] pinfo = methodInfosItem.GetParameters();
                  

                    if (methodInfosItem.Name !=null)
                    {
                        Console.WriteLine("---method Parameters----");
                        foreach (var par in pinfo)
                        {
                            Console.WriteLine(par.Name);
                            Console.WriteLine(par.Position);
                            Console.WriteLine(par.ParameterType);


                        }
                    }


                }
                Console.WriteLine("----------------------------------------------------");
                Type t = asm.GetType(item.FullName);

                object obj = Activator.CreateInstance(t);

                //int ans = (int)item.InvokeMember("addThreeNos", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[3] { 20, 20,20 });

                //             Console.WriteLine(ans);
                //PropertyInfo ifo=t.GetProperty("empid");
                //ifo.SetValue("empid", 101);


                item.InvokeMember("Acceptdata", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[2] { "honda","refined engines" });

                item.InvokeMember("Displaydata", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, null);

                break;

            }


            Console.ReadLine();
        }
    }
}
