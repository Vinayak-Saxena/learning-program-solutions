namespace LAB_4
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public double Price { get; set; }

        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}