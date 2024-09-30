using System;
using System.IO;
using TextFile;
using System.Collections.Generic;
namespace assign2
{
	public abstract class Animals
	{
		protected string name;
		protected int exhib;

		public Animals(string name, int exhib)
		{
			this.name = name;
			this.exhib = exhib;
		}
		public abstract void theirExhib(Cathy c);
		public string Name()
		{
			return name;
		}
		public int Exhib()
		{
			return exhib;
		}
		public void modify(int e)
		{
			exhib += e;
		}
		public bool alive()
		{
			return (exhib > 0);
		}
		public static List<Animals> create(ref TextFileReader reader)
		{

			List<Animals> animalsList = new List<Animals>();
			string line = reader.ReadLine();
			int n = Convert.ToInt32(line);
            
            for (int i = 0; i < n; i++)
			{

				reader.ReadLine(out line);
				char type = Convert.ToChar(line.Split(" ")[0]);
				String name = line.Split(" ")[1];
				int theirExhib = Convert.ToInt32(line.Split(" ")[2]);
				switch (type)
				{
					case 'D':
						animalsList.Add(new Dog(name, theirExhib));
						break;
					case 'B':
						animalsList.Add(new Bird(name, theirExhib));
						break;
					case 'F':
						animalsList.Add(new Fish(name, theirExhib));
						break;
						

				}
			}
			return animalsList;
		}
		   public static List<char> create2(ref TextFileReader reader) { 
            reader.ReadLine(out String line);
				String moods = line;
				List<char> moodsList = new List<char>();
				foreach (var mood in moods)
				{
					moodsList.Add(mood);
				}
				return moodsList;

		}

		
	}
	public class Dog : Animals
	{
		public Dog(string name, int exhib) : base(name, exhib)
		{

		}
        public override void theirExhib(Cathy c)
        {
			c.change(this);
        }
    }
    public class Fish : Animals
    {
        public Fish(string name, int exhib) : base(name, exhib)
        {

        }
        public override void theirExhib(Cathy c)
        {
            c.change(this);
        }
    }
    public class Bird : Animals
    {
        public Bird(string name, int exhib) : base(name, exhib)
        {

        }
        public override void theirExhib(Cathy c)
        {
            c.change(this);
        }
    }
}

