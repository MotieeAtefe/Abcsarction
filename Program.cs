namespace Abcsarction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            WeightLifter wf = new WeightLifter();
            DateTime time = DateTime.Now;
            time = time.AddHours(1);  
            time = time.AddMinutes(23); 
            time = time.AddSeconds(1);  
            string practice = "dambel";
            wf.Workout(practice, time);
        }
    }
}