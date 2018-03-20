// Built from tag v0.99.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Ressurser.Lasstyring;

namespace FINT.Model.Ressurser.Lasstyring
{
	public class Las {
		public enum Relasjonsnavn
        {
			LOKASJON
        }
        
	
		public Periode Gyldighetsperiode { get; set; }
		public Sikkerhetsprofil Sikkerhetsprofil { get; set; }
		public DateTime Sistsett { get; set; }
		public string Status { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
