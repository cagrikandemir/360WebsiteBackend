namespace _360Backend.EntityLayer.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int Numberofroom { get; set; }
        public int Area { get; set; }
        public int Layer { get; set; }
        public int Price { get; set; }
        public DateTime DeliveryTime { get; set; }
    }
}
