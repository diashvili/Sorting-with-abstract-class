
using System;

namespace masivis_zrdadobit_dalageba
{
	/* ამოცანა: 
	 * აიღეთ ჩვენი ფაუნას პროექტი გადაიტანეთ მასში სორტირების კლასი და Creature 
	 * კლასში დაამატეთ თვისება int Weight.
	 * შემდეგ შექმენით რამოდენიმე ძაღლის ობიექტი და დამისორტირეთ წონის მიხედვით.
	 */ 

	class Program
	{
		static void Main(string[] args)
		{
			Car[] cars =
			{
				new Car { Model = "Mercedes", Speed = 280 },
				new Car { Model = "Ford", Speed = 260 },
				new Car { Model = "BMW", Speed = 260 },
				new Car { Model = "Alfa Romeo", Speed = 400 },
			};

			ArrayHelper.Sort(cars);

			for (int i = 0; i < cars.Length; i++)
			{
				Console.WriteLine(cars[i]);
			}

			//Console.WriteLine();
			//ArrayHelper.Sort(x);

			//for (int i = 0; i < x.Length; i++)
			//{
			//	Console.WriteLine(x[i]);
			//}
		}
	}
}
