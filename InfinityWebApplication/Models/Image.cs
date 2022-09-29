using System.ComponentModel.DataAnnotations;
namespace InfinityWebApplication.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        [Required]
        public byte[] ImageData { get; set; } = null!;
    }
}