using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Configuration;

namespace MaintainableTestableCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcomeMessage = ConfigurationManager.AppSettings["welcomeMessage"];
            Console.WriteLine(welcomeMessage);
            int threadDelay = Convert.ToInt32(ConfigurationManager.AppSettings["threadDelay"]);
            Thread.Sleep(threadDelay);
            var jobTypes = new string[] { pm, dev, other };

            string jobTypeMessage = ConfigurationManager.AppSettings["jobTypeMessage"];
            Console.WriteLine(jobTypeMessage);

            foreach (var type in jobTypes)
                Console.WriteLine(type);

            string goodbyeMessage = ConfigurationManager.AppSettings["goodbyeMessage"];
            Console.WriteLine(goodbyeMessage);
        }
        public static int GetFirstMatchingIndex(List<int> nums, int valueToMatch)
        {
            int matchingIndex = -1;
            if (nums == null)
            {
                return matchingIndex;
            }
            if (nums.Count == 0)
            {
                return matchingIndex;
            }
            for (var i = 0; i < nums.Count; i++)
            {
                if (nums[i] == valueToMatch)
                {
                    matchingIndex = i;
                    break;
                }
            }
            return matchingIndex;
        }
        const string pm = "PM";
        const string dev = "Dev";
        const string other = "Other";
        public enum JobTypes { pm, dev, other };
        public static void DoStuffEnum()
        {
            const string welcomeMessage = "Hello Cohort!";
            Console.WriteLine(welcomeMessage);

            const int threadDelay = 2000;
            Thread.Sleep(threadDelay);

            const string jobTypeMessage = "The job types are:";
            Console.WriteLine(jobTypeMessage);

            var jobTypes = Enum.GetValues(typeof(JobTypes));
            foreach (var type in jobTypes)
                Console.WriteLine(type);

            const string goodbyeMessage = "Goodbye Cohort!";
            Console.WriteLine(goodbyeMessage);
        }

        public class C1
        {
            public void DoStuff() { }
        }

        public class C2
        {
            public void DoStuff() { }
        }

        public class C3
        {
            public void DoStuff() { }
        }

        public class C4
        {
            private C1 c1;
            private C2 c2;
            private C3 c3;

            public C4(C1 c1, C2 c2, C3 c3)
            {
                this.c1 = c1;
                this.c2 = c2;
                this.c3 = c3;
            }

            public void DoStuff(C1 c1, C2 c2, C3 c3)
            {
                c1.DoStuff();
                c2.DoStuff();
                c3.DoStuff();
            }
        }
    }
}
