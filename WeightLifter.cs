using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abcsarction
{
    internal class WeightLifter: Member, IFitness
    {
        public override void Workout(string practice, DateTime times)
        {
            if(practice == null)
            {
                throw new ArgumentNullException(nameof(practice), "Name of practice can not null value");
            }
            else if(times == DateTime.MinValue) 
            {
                throw new ArgumentException("times can not equll with 00:00:00", nameof(times));
            }
            else if(times.TimeOfDay == TimeSpan.Zero) 
            {
                throw new ArgumentException("thimes can not in midnight");
            
            }
            Console.WriteLine($"Practice: {practice}, Times: {times.ToString("yyyy-MM-dd HH:mm:ss")}");
        }

        
        public void JoinClass()
        {
            
        }

        public void TrackProgress()
        {
            
        }
    }
}
