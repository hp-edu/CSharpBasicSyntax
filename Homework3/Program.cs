/*
Expected output: 
*Note: 'Avenue' should be replaced with 'Ave.' Reference: https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes

Address: 123 Main St., Floors: 5
Address: 456 Elm St., Floors: 10
Address: 1000 Big Creek Ave., Floors: 3
*/


Building building1 = new Building();
building1.Address = "123 Main Street";
building1.Floors = 5;

Building building2 = new Building();
building2.Address = "456 Elm Street";
building2.Floors = 10;

Building building3 = building2;
building3.Address = "1000 Big Creek Avenue";
building3.Floors = 3;

building1.DisplayBuildingInfo();
building2.DisplayBuildingInfo();
building3.DisplayBuildingInfo();

public class Building
{
    private string _address;
    private int _floors;

    public string Address
    {
        get
        {
            return _address;
        }
        set
        {
            if (value.EndsWith(" Street"))
            {
                _address = value[..^7] + " St.";
            }
            else
            {
                _address = value;
            }

        }
    }

    public int Floors
    {
        get
        {
            return _floors;
        }
        set
        {
            _floors = value;
        }
    }

    public void DisplayBuildingInfo()
    {
        Console.WriteLine($"Address: {_address}, Floors: {_floors}");
    }
}