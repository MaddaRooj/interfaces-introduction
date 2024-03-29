using System.Collections.Generic;

namespace intro_interfaces
{
    public interface IStation<T>
    {
        int Capacity { get; set; }
        void Refuel(List<T> vehicles);
    }
}