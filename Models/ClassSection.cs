namespace SchoolManagementApp.Models
{
    public class ClassSection
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string SessionId { get; set; } = string.Empty;
        public string SessionName { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string SectionName { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string DisplayName => string.IsNullOrWhiteSpace(SectionName)
            ? ClassName
            : $"{ClassName} - {SectionName}";
    }
}
