using System;

namespace DBProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public string Messages { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
