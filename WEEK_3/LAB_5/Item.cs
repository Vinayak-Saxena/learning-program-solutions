namespace LAB_5
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}