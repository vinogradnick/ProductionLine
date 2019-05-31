using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ProductionLine.Models
{
    [Synchronization]
    public class Generator
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public List<Material> Materials { get; set; }
        public bool Status { get; set; }
        public Thread thread;
        public void GenerateMaterialsThread()
        {
            Debug.WriteLine("start product generation",this.ToString());
            if (Status)
            {
                thread = new Thread(() =>
                {
                    while (Status)
                    {
                        Debug.WriteLine("add product",this.ToString());
                        Materials.Add(new Material());
                        if (thread.Priority == ThreadPriority.Highest)
                        {
                            Thread.Sleep(10);
                        }
                        if (thread.Priority == ThreadPriority.Normal)
                        {
                            Thread.Sleep(1000-Speed);
                        }
                        if (thread.Priority == ThreadPriority.Lowest)
                            Thread.Sleep(4000);

                    }
                });
                thread.Start();
            }
           
        }

        public void AbortThread()
        {
            if (thread.IsAlive)
            {
                thread.Abort();
            }
        }
        public override string ToString()
        {
            return $"{Name}-{Status}";
        }

    }
}