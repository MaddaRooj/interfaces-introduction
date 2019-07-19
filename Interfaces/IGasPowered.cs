namespace intro_interfaces
{
    public interface IGasPowered {
        double FuelCapacity { get; set; }
        void RefuelTank ();
    }
}