using System;

namespace V2
{
    class Program
    {
        static void Main(string[] args)
        {
			bool GameStart = true;
			Console.WriteLine("Enter box1");
			Console.WriteLine("Enter box2");
			Console.WriteLine("Enter box3");
			int box1 = int.Parse(Console.ReadLine());
			int box2 = int.Parse(Console.ReadLine());
			int box3 = int.Parse(Console.ReadLine());
			while (GameStart == true)
			{
				Console.WriteLine("A Choose box");
				Console.WriteLine("(1) Box1 (2) Box2 (3) Box 3");
				int Abox = int.Parse(Console.ReadLine());
				Console.WriteLine("A Enter amount");
				int Aamount = int.Parse(Console.ReadLine());
				switch (Abox)
				{
					case 1:
						box1 = box1 - Aamount;
						break;
					case 2:
						box2 = box2 - Aamount;
						break;
					case 3:
						box3 = box3 - Aamount;
						break;
					default:
						Console.WriteLine("Fail");
						break;
				}
				if (box1 <= 0 & box2 <= 0 & box3 <= 0)
				{
					Console.WriteLine("B is Winner");
					GameStart = false;
					return;
				}
				Console.WriteLine("B Choose box");
				Console.WriteLine("(1) Box1 (2) Box2 (3) Box 3");
				int Bbox = int.Parse(Console.ReadLine());
				Console.WriteLine("B Enter amount");
				int Bamount = int.Parse(Console.ReadLine());
				switch (Bbox)
				{
					case 1:
						box1 = box1 - Bamount;
						break;
					case 2:
						box2 = box2 - Bamount;
						break;
					case 3:
						box3 = box3 - Bamount;
						break;
					default:
						Console.WriteLine("Fail");
						break;
				}
				if (box1 <= 0 & box2 <= 0 & box3 <= 0)
				{
					Console.WriteLine("A is Winner");
					GameStart = false;
					return;
				}
			}
		}
    }
}

