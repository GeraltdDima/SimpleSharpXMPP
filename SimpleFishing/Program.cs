using System;
using System.Net;
using System.Threading.Tasks;
using System.Text;

public class Program
{
	private static readonly IFishingNetwork fishingNetwork = new FishingNetwork();

	public static void Main(string[] args)
	{
		while (true)
		{
			Run();
		}
	}

	public static string ReadInfo() => Console.ReadLine();

	public static async Task SendMessageAsync(string message, string url) =>
		await fishingNetwork.PostMessageAsync(message, url);

	
	public static async Task Run()
	{
		Console.Write("Message: ");
		string message = ReadInfo();

		Console.Write("Url: ");
		string url = ReadInfo();

		await SendMessageAsync(message, url);
	}
}
