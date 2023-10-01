using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
	internal class Program
	{
		static readonly string delimeter = "\n-----------------------------------------\n";
		static void Main(string[] args)
		{
			DayOfWeek day = DayOfWeek.Friday;
            Console.WriteLine(day);
            Console.WriteLine();
			string[] dayName = Enum.GetNames(typeof(DayOfWeek));
			for (int i = 0; i < dayName.Length; i++)
			{
				Console.WriteLine(i + "\t" + dayName[i]);
			}
			foreach (string name in dayName) 
			{
                Console.WriteLine(name);
            }
			Console.WriteLine(delimeter);

			DistanceFromSun dfs = DistanceFromSun.Earth;
			Console.WriteLine(dfs + " " + dfs.GetHashCode());
			string[] distNames = Enum.GetNames(typeof(DistanceFromSun));
			Console.WriteLine(Enum.GetUnderlyingType(typeof(DistanceFromSun)));
			ulong[] distValues = (ulong[])Enum.GetValues(typeof(DistanceFromSun));
			/*for (int i = 0;i < distNames.Length; i++)
			{
				Console.WriteLine($"{ distNames[i]} { distValues[i]}");
            }*/
		}
	}
	enum DayOfWeek{Monday, Tuesday, Wednesday, Friday, Saturday, Sunday}
	enum DistanceFromSun : ulong 
	{	Sun = 0, 
		Mercury = 57900000,
		Venus = 108200000,
		Earth = 140600000

	}
}
