using System;
namespace assign2
{
	public abstract class Cathy 
	{
        public abstract void change(Dog dog);
        public abstract void change(Fish fish);
        public abstract void change(Bird bird);
        private int herMood;
        public int HerMood() { return herMood; }
		public void increseMood()
        {
          

            herMood += 1;
        }
		
    }
	public class Good : Cathy
	{
        private static Good instance;
        private  Good()  
        {

        }
        public static Good Instance()
        {
            if (instance == null)
            {
                instance = new Good();
            }
            return instance;
        }
        public override void change(Dog a)
		{
			a.modify(3);
		}
        public override void change(Bird a)
        {
            a.modify(2);
        }
        public override void change(Fish a)
        {
            a.modify(1);
        }
    }
    public class Ordinary : Cathy
    {
        private static Ordinary instance;
        private Ordinary() 
        {

        }
        public static Ordinary Instance()
        {
            if(instance == null)
            {
                instance = new Ordinary();
            }
            return instance;
        }
        public override void change(Dog a)
        {
            
        }
        public override void change(Bird a)
        {
            a.modify(-1);
        }
        public override void change(Fish a)
        {
            a.modify(-3);
        }
    }
    public class Bad : Cathy
    {
        private static Bad instance;
        private Bad() 
        {

        }
        public static Bad Instance()
        {
            if (instance == null)
            {
                instance = new Bad();
            }
            return instance;
        }
        public override void change(Dog a)
        {
            a.modify(-10);
        }
        public override void change(Bird a)
        {
            a.modify(-3);
        }
        public override void change(Fish a)
        {
            a.modify(-5);
        }
    }
}

