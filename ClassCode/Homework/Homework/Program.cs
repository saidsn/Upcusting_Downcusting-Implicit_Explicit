using Homework.Models;
using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Params
            //int[] arr = { 1, 2, 3, 4 };
            //Getelements(1, 2, 3, 4, 5);
            #endregion

            #region Enum
            //CheckRole(2);
            #endregion

            #region Nullable
            //Test test = new Test();
            //Console.WriteLine(test.Number);

            //string name = null;
            //int ?Age = null;


            //var result = Age == null ? 55 : 60;
            //var result = Age ?? 60;
            //Console.WriteLine(result);

            //Test test = null;
            //Console.WriteLine(test.ToString());
            #endregion

            #region Struct
            //Test1 test = new Test1("orxan");
            //Console.WriteLine(test.Num);

            //Test2 test2 = new Test2(2);
            #endregion

            #region Upcasting_Implicit_Boxing
            //burda bele basa dusdum "byte=Eagle,Shark"; "Int= Animal"
            //byte m = 5;
            //int n = m;


            //Eagle eagle1 = new Eagle();
            //Eagle eagle3 = new Eagle();
            //Eagle eagle2 = new Eagle();

            //Shark shark1 = new Shark();
            //Shark shark2 = new Shark();

            ////burada ise "eagle1=500" ve Eagle4-u byte hesab etsek zaten 500 - e daxildir.
            //   Animal eagle4 = eagle1;

            //Animal[] animals = { eagle1, eagle2, eagle3, eagle4, shark1, shark2 };

            //foreach (var item in animals)
            //{
            //    item.Eat();
            //}
            #endregion

            #region Downcasting_Implicit_Boxing
            //int m = 230;
            //byte n = (byte)m;
            //Console.WriteLine(n);

            //Shark shark1 = new Shark();

            //Animal shark2 = new Shark();

            //Shark shark3 = (Shark)shark2;

            //object[] objects = { 2, 5, "Salam", shark2 };

            //foreach (var item in objects)
            //{
            //    Shark shark = item as Shark;
            //    if (shark != null)
            //    {
            //        Console.WriteLine(shark.Weight);
            //    }
            //    //if (item is Shark t)
            //    //{
            //    //    t.Weight = 500;
            //    //    Console.WriteLine(t.Weight);
            //    //}

            //}
            #endregion

        }

        #region Params
        //public static void Getelements(params int[] nums)
        //{
        //    foreach (var item in nums)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        #endregion

        #region Enum
        //static void CheckRole(int roleId)
        //{
        //    switch (roleId)
        //    {
        //        case (int)Roles.SuperAdmin:
        //            Console.WriteLine("Super admin");
        //            break;
        //        case (int)Roles.Admin:
        //            Console.WriteLine("Admin");
        //            break;
        //        case (int)Roles.Member:
        //            Console.WriteLine("Member");
        //            break;
        //        default:
        //            Console.WriteLine("Not found roleId");
        //            break;
        //    }
        //}
        #endregion
    }
    #region Struct
    //struct Test1
    //{
    //    public int Num { get; set; }

    //    public Test1(string name)
    //    {
    //        Num = 66;
    //    }


    //}

    //class Test2
    //{
    //    public int MyProperty { get; set; } = 77;

    //    public Test2()
    //    {
    //        Console.WriteLine("bosh");
    //    }
    //    public Test2(int b)
    //    {
    //        Console.WriteLine("dolu");
    //    }
    //}
    //struct Test3
    //{

    //}

    //interface ITest
    //{

    //}
    #endregion

    #region Nullable
    //class Test
    //{
    //    public int? Number { get; set; }

    //    public string Word { get; set; }
    //}
    #endregion

    #region Enum
    //public enum Roles
    //{
    //    SuperAdmin,
    //    Admin,
    //    Member
    //}
    #endregion

}
