interface IStringContentFactory
{
    StringContent GenerateStringContent<T>(T value);
}