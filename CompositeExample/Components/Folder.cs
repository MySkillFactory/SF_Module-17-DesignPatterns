using System;
using System.ComponentModel;

namespace CompositeExample.Components
{
    /// <summary>
    /// Представляет папку - компонент, который может содержать другие компоненты
    /// Здесь реализован механизм для добавления / удаления новых компонентов
    /// </summary>
    class Folder : Component
	{
        List<Component> subFolders = new List<Component>();
		public Folder(string name) : base(name)
		{ }

        // Метод для добавления новых подкомпонентов
        public override void Add(Component c)
        {
            subFolders.Add(c);
            Console.WriteLine($"В {this.Name} добавлено: {c.Name} ");
        }

        // Метод для отображения нижестоящих компонентов
        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} содержит:");
            foreach (Component component in subFolders)
                component.Display();
        }

        // Метод для удаления
        public override void Remove(Component c)
        {
            subFolders.Remove(c);
            Console.WriteLine($"Из {this.Name} удалено: {c.Name} ");
        }
    }
}

