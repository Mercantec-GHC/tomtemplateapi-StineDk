using System.Security.Cryptography.X509Certificates;

namespace DomainModels
{
	public class RootObject
	{
		public AdTypeProperties adTypeProperties { get; set; }
	}
	public class AdTypeProperties
	{
		public AdnuntiusDisplay adnuntiusDisplay { get; set; }
	}
	public class AdnuntiusDisplay
	{
		public List<Kv> kv { get; set; }
	}
	public class Kv
	{
		public List<string> attr_classifications { get; set; }
		public List<string> attr_makemodel { get; set; }
		public List<string> Variant { get; set; }
		public List<string> listing_price_raw { get; set; }
		public List<string> attr_vintage { get; set; } 
		public List<string> attr_fuel { get; set; }
		public List<string> listing_contact_municipality { get; set; }
		public List<string> listing_contact_region { get; set; }
		public List<string> attr_imageurls { get; set; }
    }
}
