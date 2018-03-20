// Built from tag v0.99.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Ressurser.Tilganger
{
	public class Identitet {
		public enum Relasjonsnavn
        {
			RETTIGHET,
			PERSONALRESSURS
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}
