using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using app.Models;

namespace app.domain.Models
{
	public class CapsulesInformation: Entity
	{
		public string Titre { get; set; }
		public string Texte { get; set; }
		public string Lien { get; set; }
		public string Status { get; set; }
	}
}


