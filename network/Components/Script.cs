
namespace  Components
{
    public class GetIpAddress 
	{
		public static GetIpAddress() 
		{
			
			using HttpClient client = new HttpClient();

			var response = await client.GetStringAsync("https://api.ipify.org/");

			Console.WriteLine(response);
		}

	}
}







