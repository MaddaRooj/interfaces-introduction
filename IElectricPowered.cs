namespace intro_interfaces
{
    public interface IElectricPowered {
        double BatteryKWh { get; set; }
        void ChargeBattery ();
    }
}