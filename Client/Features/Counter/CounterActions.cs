namespace FluxorBlazor.Client.Features.Counter;

public record CounterIncrementAction();

public record CounterSetStateAction(CounterState CounterState);

public record CounterPersistStateAction(CounterState CounterState);
public record CounterPersistStateSuccessAction();
public record CounterPersistStateFailureAction(string ErrorMessage);

public record CounterLoadStateAction();
public record CounterLoadStateSuccessAction();
public record CounterLoadStateFailureAction(string ErrorMessage);

public record CounterClearStateAction();
public record CounterClearStateSuccessAction();
public record CounterClearStateFailureAction(string ErrorMessage);