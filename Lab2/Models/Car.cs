using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
	[Table("Fleet")]
	public class Car
	{
		[Key]
		[Column("Registration_ID")]
		public string Registration { get; set; }
		[Column("Make")]
		public string Make { get; set; }
		[Column("Model")]
		public string Model { get; set; }
		[Column("Engine_Size")]
		[Range(50, 4000)]	
		public int EngineSize { get; set; }
	}
}
