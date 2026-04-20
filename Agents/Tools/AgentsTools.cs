using Microsoft.Extensions.AI;

namespace CSharpMafAgentsAi.Agents.Tools;

public static class AgentsTools
{
    public static AITool[] All =>
    [
        AIFunctionFactory.Create(WeatherTool.GetWeather)
    ];
}