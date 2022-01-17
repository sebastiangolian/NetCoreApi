using System.ComponentModel.DataAnnotations;
namespace NetCoreApi.Models
{
    public class Product
    {
        [RequiredAttribute]
        public string IdProduct { get; set; }

        [RequiredAttribute]
        public string Name { get; set; }

        [RequiredAttribute]
        public string Price { get; set; }
    }
}