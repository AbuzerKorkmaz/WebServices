namespace WebApplication1.Models.Entities
{
    public class Kitap
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public int PageCount { get; set; }
        public List<string> Authors { get; set; } 
    }
}
