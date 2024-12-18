using System;
using System.Text;
using System.Text.Json;

public class StringContentFactory : IStringContentFactory
{
    public StringContent GenerateStringContent<T>(T value)
    {
        var json = JsonSerializer.Serialize(value);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        return content;
    }
}