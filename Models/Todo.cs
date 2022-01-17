using System.ComponentModel.DataAnnotations;

namespace NetCoreApi.Models
{
    public class Todo
    {
        [RequiredAttribute]
        public long Id { get; set; }
        [RequiredAttribute]
        public string Name { get; set; }
        [RequiredAttribute]
        public bool IsComplete { get; set; }
    }
}