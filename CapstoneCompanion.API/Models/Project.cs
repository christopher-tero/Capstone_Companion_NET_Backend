namespace CapstoneCompanion.API.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Features { get; set; }
        public int User_id { get; set; }
        public bool Current { get; set; }
    }
}