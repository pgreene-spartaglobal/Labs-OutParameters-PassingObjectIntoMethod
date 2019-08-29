using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

/* Lab 1 : Out parameters
 * Declare a method which inputs three integers and returns the product ie the value of the three numbers multiplied together. 
 * Also return an out parameter which contains the sum of the three integers. 
 * 
 * Lab 2 : Passing an object into a method 
 * Create a Cat class which has a name and an age property.
 * Create a constructor method also. 
 * In the Methods class, create a static method called Age() which takes a Cat object as an input parameter. 
 * Inside the method, add 5 years to the age of the cat passed in. 
 * Instantiate a Cat instance cat01 in the Main() method. 
 * In the constructor pass in the name as 'Tibby' with age 2. 
 * Pass the Cat instance into the Age() method. Repeat this another time so the Age() method is called twice in all.
 * Use these two lines 
 * using System.Web.Script.Serialization; (note you must add a Reference first - you will have to Google for the reference name to add) and 
 * var json = new JavaScriptSerializer().Serialize(cat01); to help you serialize the final cat object into JSON and return this JSON string. 
 * {"name":"tilly","age":12}
 */

namespace MethodsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunLab1();
            RunLab2();
        }
        static void RunLab1()
        {
            OutParameters outParameters = new OutParameters();
            int[] inputArray = new int[3];
            int productValue = 0;
            int sumValue = 0;

            inputArray = outParameters.ReadInputs(inputArray);
            productValue = outParameters.CalculateProduct(inputArray[0], inputArray[1], inputArray[2], out sumValue);
            outParameters.DisplayOutput(productValue, sumValue);
        }

        static void RunLab2()
        {
            Cat cat01 = new Cat("Tibby", 2);
            Console.WriteLine(String.Format("Created cat01\ncat01.name: {0}\ncat01.age: {1}\n", cat01.name, cat01.age));
            
            for (int i = 0; i < 2; i++)
            {
                Methods.Age(cat01);
                Console.WriteLine(String.Format("Current age of {0}: {1}\n", cat01.name, cat01.age));
            }

            Methods.DisplaySerializeCatJSON(cat01);
        }
    }

    class OutParameters
    {     
        public int[] ReadInputs(int[] inputValues)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(String.Format("Please enter integer {0}:", i + 1));
                inputValues[i] = Convert.ToInt32(Console.ReadLine());
            }
            return inputValues;
        }

        public int CalculateProduct(int firstNumber, int secondNumber, int thirdNumber, out int sum)
        {
            sum = firstNumber + secondNumber + thirdNumber;
            return firstNumber * secondNumber * thirdNumber;
        }

        public void DisplayOutput(int product, int sum)
        {
            Console.WriteLine(String.Format("Product: {0}", product));
            Console.WriteLine(String.Format("Sum: {0}", sum));
            Console.WriteLine();
        }
    }

    class Cat
    {
        public string name;
        public int age;

        public Cat(string catName, int catAge)
        {
            name = catName;
            age = catAge;
        }
    }
    class Methods
    {
        public static void Age(Cat catObj)
        {
            catObj.age += 5;
            Console.WriteLine(String.Format("{0} aged 5 years...", catObj.name));
        }

        public static void DisplaySerializeCatJSON(Cat catObj)
        {
            Console.WriteLine("Serialized JSON string");
            var json = new JavaScriptSerializer().Serialize(catObj);
            Console.WriteLine(json);
        }
    }
}
