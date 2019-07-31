namespace CapstoneCompanion.API.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Project_id { get; set; }
    }
}