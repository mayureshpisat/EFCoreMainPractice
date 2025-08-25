namespace EFCoreMainPractice.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionOfGame { get; set; }
        
        public int CategoryId { get; set; }
    }
}
