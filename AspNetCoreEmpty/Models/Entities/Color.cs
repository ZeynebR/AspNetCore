namespace AspNetCoreEmpty.Models.Entities
{
    public class Color
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? HexCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}
