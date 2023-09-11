using System.ComponentModel.DataAnnotations;

namespace FarmerAppithoneSensor.Models
{
	public class Tempreture
	{
        [Key]
        public int Id { get; set; }
        public int Value { get; set; }
        //public DateTime DateofValue { get; set; } = DateTime.Now;


    }
}
