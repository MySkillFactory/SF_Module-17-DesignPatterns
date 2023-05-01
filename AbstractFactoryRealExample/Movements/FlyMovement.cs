using System;
namespace AbstractFactoryRealExample.Movements
{
    public class FlyMovement : IMovement
    {
        /// <summary>
        /// Летающим монстрам доступно движение полета
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Летим");
        }
    }
}

