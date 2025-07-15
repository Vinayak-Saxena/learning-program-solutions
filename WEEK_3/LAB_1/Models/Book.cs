namespace LAB_1.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }

    public int GenreId { get; set; }
    public Genre Genre { get; set; }
}