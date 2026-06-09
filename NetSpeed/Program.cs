using System.Diagnostics;

namespace NetSpeed;

class Program
{
    static void Main(string[] args)
    {
        ///
        /// how to measure the speed of the network
        /// we need to monitor the input and output of the device 
        /// and then see the capacity per second
        

        //step one monitor the input to out device
        // this step will be divided into a components 
        //the first component is how many processes are there running 

        //processes 

        var processes = Process.GetProcesses();
        while(true)
        {
            var changed = Process.GetProcesses();
            if(changed.Count() != processes.Count())
            {
                Console.WriteLine($"There are: {changed.Count()} processes running");
                processes = Process.GetProcesses();
            }
        }
    }
}
