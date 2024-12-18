using System;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class FishingNetwork : IFishingNetwork
{
	private readonly HttpClient client;
	private readonly IConsoleLogger consoleLogger;
	private readonly IStringContentFactory stringContentFactory;

	public FishingNetwork()
	{
		client = new HttpClient();
		consoleLogger = new ConsoleLogger();
		stringContentFactory = new StringContentFactory();
	}

	private StringContent GenerateStringContent<T>(T value) =>
		stringContentFactory.GenerateStringContent(value);

	public async Task PostMessageAsync(string message, string url)
	{
		var content = GenerateStringContent(message);
		var response = await client.PostAsync(url, content);

		if (response.IsSuccessStatusCode)
		{
			Log("Message sended successfly");
		}

		else
		{
			Log("Error!Message did not send");
		}
	}

	private void Log<T>(T message) => consoleLogger.Log(message);
}
