using CSharpMafAgentsAi.Agents.Tools;
using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;
using OllamaSharp;

namespace CSharpMafAgentsAi.Agents.Abstractions;

public abstract class AgentCreator
{
    protected abstract string Uri { get; }
    protected abstract string Model { get; }
    protected abstract string SystemPrompt { get; }
    
    public  ChatClientAgent CriateAgent() => new OllamaApiClient(Uri, Model)
        .AsAIAgent(
            SystemPrompt,
            tools: AgentsTools.All);
}