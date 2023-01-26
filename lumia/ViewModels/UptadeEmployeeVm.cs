namespace lumia.ViewModels
{
    public class UptadeEmployeeVm
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public IFormFile Image { get; set; }
        public string? ImageUrL { get; set; }
        public string Description { get; set; }
        public int PositionId { get; set; }

        public string? FacebookUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? LinkedInUrl { get; set; }
    }
}
