using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionLine.Models
{
    [Synchronization]
    public class ProductionLine
    {
        private static int Id;
        public int ID { get; set; }
        public Image Image { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Size { get; set; }
        public List<Product> Products { get; set; }
        public List<Material> Materials { get; set; }
        public object Locker = new object();
        private ProductionLine next;
        public Mutex Mutex;
        public Generator generator;
        public Thread GenThread;
        public Thread SenderThread;
        public Thread RecieveThread;

        public bool isSend => next != null && Products.Count > 0;

        public ProductionLine()
        {
            Products=new List<Product>();
            Materials=new List<Material>();
            Id++;
            ID = Id;
            Mutex=new Mutex();
        }

        public void GenerateProduct(Form form,Action action)
        {
            RecieveMaterials();
             GenThread = new Thread((() =>
            {
                Logger.Log("produce product", this.ToString(), "product generator thread");
                Random rand = new Random();
                while (true)
                {
                    if (this.Materials.Count > 10)
                    {
                        var m = this.Materials.First();
                        Materials.Remove(m);
                        Debug.WriteLine("Removed material", this.ToString());
                        Thread.Sleep(2000 - Speed);
                        var p = new Product() { Id = ProductionLine.Id++, Name = Faker.Commerce.ProductName(), Quality = rand.Next(100), Type = m.Type };
                        Products.Add(p);
                       
                    }
                    else
                    {
                       RecieveMaterials();
                    }
                   
                   
                   
                }

               
                form.Invoke(action);
            }));
            GenThread.Start();
        }

        public void SendProduct(ProductionLine nextLine)
        {
             SenderThread = new Thread(()=> {
                try
                {
                    Monitor.Enter(Locker);
                    Logger.Log("produce sender product", this.ToString(), "product sender thread");
                    while (Products.Count>0)
                    {
                        Debug.WriteLine("product send to " + nextLine.ToString(), this.ToString());
                         List<Product> removelist= new List<Product>();
                        int count = Products.Count;
                        for (int i = 0; i < count; i++)
                        {
                            var p = Products.FirstOrDefault();
                            nextLine.GetMaterial(p?.Convert());
                            Products.Remove(p);
                        }
                      
                    }
                   

                }
                finally
                {
                    Monitor.Exit(Locker);
                }


            });
            SenderThread.Start();
        }

        public void RecieveMaterials()
        {

            
                if (generator.Materials.Count > 0 || generator.Status)
                {
                    Debug.WriteLine("get data", generator.Name);
                    var material = generator.Materials.Take(generator.Materials.Count - 1);
                    this.Materials.AddRange(material);
                    generator.Materials.RemoveRange(0, generator.Materials.Count - 1);


                }
           
           
            

        }

        public void GetMaterial(Material material) => Materials.Add(material);
        public override string ToString()
        {
            return $"{ID}-{Name}";
        }
    }
}
