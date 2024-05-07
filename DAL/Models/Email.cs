﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	//[Keyless]
	public class Email
	{
		public int Id { get; set; }
		public string To { get; set; } 
		public string Subject { get; set; }
		public string Body { get; set; }
	}
}
