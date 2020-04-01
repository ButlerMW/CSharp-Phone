using System;

public class Galaxy : PhoneModel, IRingable
{
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
    
    public string Ring()
    {
        return $"...{ ringTone }...";
    }

    public string Unlock()
    {
        return $"Galaxy { versionNumber } unlocked with fingerprint scanner";
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine("##############################");
        Console.WriteLine($"Galaxy { versionNumber }"); // versionNumber?
        Console.WriteLine($"Battery Percentage: { batteryPercentage }");
        Console.WriteLine($"Carrier: { carrier }");
        Console.WriteLine($"RingTone: { ringTone }");
        Console.WriteLine("##############################");
    }
}