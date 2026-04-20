using System.ComponentModel;

namespace CSharpMafAgentsAi.Agents.Tools;

public static class WeatherTool
{
    //uso de DataAnotation para descrever bem o método e o que ele faz para ajudar
    // a NLP pegar o contexto e encontrar essa Tool
    [Description("Obtém a temperatura atual de uma determinada localização passada como parametro")]
    public static string GetWeather(
        [Description("localização de onde a temperatura será consultada")]
        string location) => 
            $"temperatura atual em {location} é de 30 graus";
}