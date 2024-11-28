namespace FluxorBlazor.Client.Features.Hubs.CounterHub;

public record CounterHubSetConnectedAction(bool Connected);
public record CounterHubStartAction();
public record CounterHubReceiveCountAction(int Count);
public record CounterHubSendCountAction(int Count);
public record CounterHubSendCountFailedAction(string Message);
