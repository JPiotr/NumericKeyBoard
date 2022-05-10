using System;

namespace NumericKeyBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
			char[,] map = new char[,] { { ' ', '1', '\x00', '\x00','\x00','2' },
										{ 'A', 'B', 'C', '2', '\x00', '4' }, 
										{ 'D', 'E', 'F', '3', '\x00', '4' }, 
										{ 'G', 'H', 'I', '4', '\x00', '4' }, 
										{ 'J', 'K', 'L', '5', '\x00', '4' }, 
										{ 'M', 'N', 'O', '6', '\x00', '4' },  
										{ 'P', 'Q', 'R', 'S','7', '5' }, 
										{ 'T', 'U', 'V', '8','\x00', '4' }, 
										{ 'W', 'X', 'Y', 'Z', '9', '5' }, 
										{ '*', '\x00', '\x00', '\x00', '\x00', '1'}, 
										{ '0', '+', '\x00' ,'\x00' , '\x00', '2'}, 
			};

			string input = "3284446661533777781777788733777";

			int mod = 0;
			int div = 0;
			int buff = 0;
			double row = 0;
			char pref = input[0];
			for (int i = 0; i < input.Length; i++)
			{

				if (i != 0) pref = input[i - 1];
				if (pref != input[i] || i == input.Length - 1)
				{
					//wypisanie litery
					row = Char.GetNumericValue(pref);
					div = (int)Char.GetNumericValue(map[(int)row - 1, 5]);
					mod = (buff % div);
					if (mod == 0) mod = 1;
					if (i != input.Length - 1)buff = 0;
					else mod++;

					Console.Write(map[(int)row - 1, mod - 1]);

					

				}
				buff++;
			}
			Console.ReadLine();
		}
    }
}
