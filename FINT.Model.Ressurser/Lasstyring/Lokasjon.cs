// Built from tag v0.99.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Ressurser.Lasstyring;

namespace FINT.Model.Ressurser.Lasstyring
{
	public class Lokasjon {
		public enum Relasjonsnavn
        {
			LAS
        }
        
	
		public List<Adresse> Adresse { get; set; }
		public string Bygning { get; set; }
		public string Etasje { get; set; }
		public string Navn { get; set; }
		public Koordinat Posisjon { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
