using Homework.Models;
using System;

namespace Homework
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Home params
            //int[] Get = { 1, 4, 3, 6 };
            //Numbers(1, 4, 6, 8);
            //SumNums(Get);
            #endregion

            #region Home Enum
            //Responsiblity(2);
            #endregion

            #region Home Nullable
            //Check check = new Check();
            //Console.WriteLine(check.Hello);

            //string word = null;
            //int ?weight = 40;
            //Console.WriteLine(weight);

            //var result = weight == null ? 44 : 30;

            //var result2 = weight ?? 56;
            //Console.WriteLine(result2);

            //if (word == null)
            //{
            //    Console.WriteLine("correct");
            //}

            //Check check = null;
            //Console.WriteLine(check.Hello.ToLower());
            #endregion

            #region Home Struct
            //Excam excam = new Excam(11);

            //var result = excam.Age;

            //Console.WriteLine(result);
            //Excam1 excam1 = new Excam1();
            //var result1 = excam1.Num;
            //Console.WriteLine(result1);
            #endregion

            #region Home Upcusting_Implicit_Boxing
            //Teacher teacher = new Teacher();
            //Person teacher1 = teacher;
            //Teacher teacher2 = new Teacher();
            //teacher1 = teacher;


            //Assistant assistant = new Assistant();
            //Doctor assistant1 = assistant;
            //Doctor assistant3 = assistant1;

            //Person[] people = { teacher, teacher1, teacher2 };

            //Person[] Human = { assistant1, assistant, assistant3, teacher, teacher1, teacher2 };
            //foreach (var item in Human)
            //{
            //    item.Work();
            //}
            //for (int i = 0; i < people.Length; i++)
            //{
            //    people[i].Work();
            //}
            #endregion

            #region  Home Downcusting_Implicit_Boxing
            //int monthday = 4;
            //sbyte weekday = (sbyte)monthday;
            //Console.WriteLine(weekday);

            //Teacher teacher1 = new Teacher();

            //Person teacher2 = new Teacher();

            //Teacher teacher = (Teacher)teacher2;

            //teacher2 = teacher1;
            //object[] mixeds = { 3," ", 6, teacher2 };
            //foreach (var item in mixeds)
            //{
            //    Teacher teacher = item as Teacher;
            //    if (teacher != null)
            //    {
            //        Console.WriteLine(teacher.seniority);
            //    }

            //    if (item is Teacher n)
            //    {
            //        n.seniority = 12;
            //        Console.WriteLine(n.seniority);
            //    }
            //}
            #endregion


        }
        #region Home Params
        //public static void Numbers(params int[] nums)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        Console.WriteLine(nums[i]);
        //    }
        //}

        //public static void SumNums(int[] Get)
        //{

        //}
        #endregion

        #region Home Enum
        //static void Responsiblity(int ClubId)
        //{
        //    switch (ClubId)
        //    {
        //        case (int)Club.Direktor:
        //            Console.WriteLine("Direktor");
        //            break;
        //        case (int)Club.Muellim:
        //            Console.WriteLine("Muellim");
        //            break;
        //        case (int)Club.Sagird:
        //            Console.WriteLine("Sagird");
        //            break;
        //        default:
        //            Console.WriteLine("not");
        //            break;
        //    }
        //}
        #endregion


    }
    #region Home Enum
    //enum Club
    //{
    //    Direktor,
    //    Muellim,
    //    Sagird
    //}
    #endregion

    #region Home Nullable
    //class Check
    //{
    //    public int Numbers { get; set; }

    //    public string Hello { get; set; }
    //}
    #endregion

    #region Home Struct
    //public struct Excam :Excam4
    //{
    //    public int Age { get; set; }
    //    public Excam(int num)
    //    {
    //        Age = 17;

    //    }
    //}
    //class Excam1
    //{
    //    public int Num { get; set; } = 12;

    //    public Excam1()
    //    {
    //        Console.WriteLine("passed");
    //    }
    //    public Excam1(int number)
    //    {
    //        Console.WriteLine("not passed");
    //    }
    //}

    //struct Excam3
    //{
    //    public int MyProperty { get; set; }
    //}
    //interface Excam4
    //{

    //}
    #endregion


}
