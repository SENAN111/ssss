using lumia.Models.Base;

namespace lumia.Models
{
    public class Employee:BaseEntitiyName
    {
       
        public string SurName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string LinkedInUrl { get; set; }

    }
}
