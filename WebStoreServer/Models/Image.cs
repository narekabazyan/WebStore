using System.ComponentModel.DataAnnotations;

namespace WebStoreServer.Models
{
    public class Image
    {
        public int Id { get; set; }
        [DataType(DataType.ImageUrl)]
        public string Url { get; set; }
    }
}