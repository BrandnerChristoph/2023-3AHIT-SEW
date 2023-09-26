using Interfaces_Devices_2023_09_13.Classes;
using Interfaces_Devices_2023_09_13.Interfaces;

List<IDevice> _devices = new List<IDevice>();

Random rnd = new Random();
for(int i = 0 ; i < 10; i++)
{
    int rndInt = rnd.Next(1,50);
    bool powerStatus = (rnd.Next(1, 101) % 2 == 0) ? false : true;

    if ((rndInt % 6) == 0)
        _devices.Add(new MultifunctionalDevice("HP Laser Jet Drucker MFP M480f", "Multifunktionsgerät", powerStatus));
    else if ((rndInt % 3) == 0)
        _devices.Add(new Scanner("Canon imageFORMULA DR-C230", "Dokumetenscanner", powerStatus));
    else
    {
        string[] printerNames = { "Brother HL-L2350DW", 
                                    "HP LaserJet Pro M110we", 
                                    "Canon i-SENSYS LBP631Cw",
                                    "Kyocera PA2001w"};

        bool tonerStatus = (rnd.Next(1, 20) % 2 == 0) ? false : true;
        _devices.Add(new Printer(printerNames[rnd.Next(0,printerNames.Length)], null, powerStatus, tonerStatus));
    }
}

foreach(var device in _devices)
{
    Console.WriteLine($"{device.GetType()} : {device.Name} (verfügbar: {(device.IsAvailable() ? "Ja" : "Nein")})");
    if (device.GetType() == typeof(Printer))
    {
        (device as Printer).Print();
    }
}