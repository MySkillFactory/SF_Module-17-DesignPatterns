using System;
namespace CompositeExample.Components
{
    /// <summary>
    /// Представляет компонент самого низкого уровня
    /// Который не может содержать подкомпонентов
    /// </summary>
    class FileComponent : Component
	{
        public FileComponent(string name) : base(name)
        { }

        // Метод для добавления подкомпонентов не поддерживается
        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Console.WriteLine(Name);
        }

        // Метод для удаления подкомпонентов не поддерживается
        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
}

