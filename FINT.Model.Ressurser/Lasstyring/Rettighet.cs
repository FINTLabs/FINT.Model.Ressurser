// Built from tag v0.99.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Ressurser.Lasstyring
{
	public class Rettighet {
		public enum Relasjonsnavn
        {
			LAS
        }
        
	
		public Periode Gyldighetsperiode { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
