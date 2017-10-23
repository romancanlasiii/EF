using EF.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Models.Models
{
	public class Employee : Entity<int>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
