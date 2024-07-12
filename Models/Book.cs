namespace LibraryGrpcService.Models
{
    public class Book
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public int PublicationYear { get; set; }
    }
}