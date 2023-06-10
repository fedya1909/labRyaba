using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labRyaba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractTruck truck;
            string name;
            int e_type, b_type;

            Console.WriteLine("Введите производителя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите тип двигателя: \n1. e_type1\n2. e_type2\n3. e_type3\n4. e_type4");
            e_type = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите тип кузова: \n1. b_type1\n2. b_type2\n3. b_type3\n4. b_type4");
            b_type = Convert.ToInt32(Console.ReadLine());


            if ((e_type==1 || e_type==2) && b_type==1)
                truck = new TwoAxisTruck(name, e_type.ToString(), b_type.ToString());
            else if (e_type==3 && b_type==2)
                truck = new ThreeAxisTruck(name, e_type.ToString(), b_type.ToString());
            else if (e_type==4 && (b_type==3 || b_type==4))
                truck = new FourAxisTruck(name, e_type.ToString(), b_type.ToString());
            else truck = new Default(name);

            Console.WriteLine(truck.GetName());
            Console.WriteLine(truck.GetTruckType());
            Console.WriteLine(truck.GetEngineType());
            Console.WriteLine(truck.GetBodyType());
        }
    }
}
