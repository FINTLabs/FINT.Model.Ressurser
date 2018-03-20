// Built from tag v0.99.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Ressurser.Tilganger
{
	public class Rettighet : Begrep {
		public enum Relasjonsnavn
        {
			IDENTITET
        }
        
	
		public string Beskrivelse { get; set; }
		public string Navn { get; set; }
		
	}
}
