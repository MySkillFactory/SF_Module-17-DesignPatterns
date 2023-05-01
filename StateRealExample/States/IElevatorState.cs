using System;
namespace StateRealExample.States
{
    /// <summary>
    /// Интерфейс состояния лифта
    /// </summary>
    public interface IElevatorState
	{
        void Up(Elevator elevator);
        void Down(Elevator elevator);
    }
}

