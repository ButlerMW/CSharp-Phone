public abstract class PhoneModel
{
    private string _versionNumber;
    private int _batteryPercentage;
    private string _carrier;
    private string _ringTone;
    public string versionNumber 
    {
        get { return _versionNumber; }
        set { _versionNumber = value; }
    }
    public int batteryPercentage 
    {
        get { return _batteryPercentage; }
        set { _batteryPercentage = value; }
    }
    public string carrier 
    {
        get { return _carrier; }
        set { _carrier = value; }
    }
    public string ringTone 
    {
        get { return _ringTone; }
        set { _ringTone = value; }
    }


    public PhoneModel(string versionNumber, int batteryPercentage, string carrier, string ringTone)
    {
        _versionNumber = versionNumber;
        _batteryPercentage = batteryPercentage;
        _carrier = carrier;
        _ringTone = ringTone;
    }

    public abstract void DisplayInfo();
    
}