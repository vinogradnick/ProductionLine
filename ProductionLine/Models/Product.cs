namespace ProductionLine.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quality { get; set; }

        public  Material Convert() => new Material() {Name = this.Name, Type = this.Type};
    }
}