// создаем объет сразу в каким-то состоянии
var contextObject = new ContextObject(new StateOne());
contextObject.Switch(); // Переход в состояние StateTwo
contextObject.Switch(); // Переход в состояние StateOne

Console.ReadKey();

/// <summary>
/// Общий интерфейс, определяющий состояния
/// </summary>
abstract class State
{
    public abstract void Handle(ContextObject contextObject);
}

/// <summary>
/// Сам объект, поведение которого должно изменяться
/// </summary>
class ContextObject
{
    public State State { get; set; }
    public ContextObject(State state)
    {
        State = state;
    }

    public void Switch()
    {
        Console.WriteLine(this.State.ToString());
        State.Handle(this);
    }
}

/// <summary>
/// Первое состояние
/// </summary>
class StateOne : State
{
    public override void Handle(ContextObject contextObject)
    {
        contextObject.State = new StateTwo();
    }
}

/// <summary>
/// Второе состояние
/// </summary>
class StateTwo : State
{
    public override void Handle(ContextObject contextObject)
    {
        contextObject.State = new StateOne();
    }
}
