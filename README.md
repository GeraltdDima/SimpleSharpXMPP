# SimpleSharpXMPP

## Explanation:
1.This application helps you to post contnet to url.
2.Simple code, you can edit this code very simple.

## Syntax
1.ConsoleLogger:
ConsoleLogger contains - interface for console and concrect realization.Console logger helps to write something in console
Custom realization example -
public class YourRealization : IConsoleLogger
{
      public void Log<T>(T value)
      {
            // Your code
      }
}

2.StringContentFactory:
StringContentFactory contains - interface for factory that makes StringContent and concrect realization.StringContentFacotry helps to convert data to StringContent
Custom realization example -
public class YourRealization : IStringContentFactory
{
        public StringContent GenereateStringContent<T>(T value)
        {
                // Your code
        }
}

3.FishingNetwork:
FishingNetwork is main application part.Contains interface for network and concrect realization.FishingNetwork helps to post data to url
Custom realization example:
public class YourRealization : IFishingNetwork
{
        public async Task PostMessageAsync(string message, string url)
        {
                // Your code
        }
}

## Using

When you start the application you must to write message in string format, that you want to post.
After you must to write url.
