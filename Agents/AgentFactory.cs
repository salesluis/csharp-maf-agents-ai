using CSharpMafAgentsAi.Agents.Abstractions;
using CSharpMafAgentsAi.Agents.Catalog;
using Microsoft.Agents.AI;

namespace CSharpMafAgentsAi.Agents;

public static class AgentFactory
{
    // ReSharper disable once InconsistentNaming
    private static readonly Dictionary<string, AgentCreator> _agents = new()
    {
        ["generic"] = new GenericAgent(),
        ["weather"] = new WeatherAgent(),
        ["translate"] = new TranslateAgent(),
    };

    public static ChatClientAgent? GetAgent(string agentName)
    {
        if (!_agents.TryGetValue(agentName, out var agent))
            throw new InvalidOperationException($"Agente {agentName} não existe, crie ou busque pelo nome correto");

        return agent!.CriateAgent();
    }
}