namespace knightmoves;

public class Ageable{
    protected int Year;

    protected Age(int year){
        Year = year;
    }
}

public class Company : Ageable{
    private string Name;
    private string Id;
    private decimal TaxRate;

    public Company(string name, string taxId, int yearEstablished, decimal taxRate) : base(year){
        Name = name;
        Id = taxId;
        Year = yearEstablished;
        TaxRate = taxRate;
    }
}

public class Person : Ageable{
    private string Name;
    private string Id;
    private decimal TaxRate;

    public Person(string name, string ssn, int birthYear, decimal taxRate) : base(year){
        Name = name;
        Id = ssn;
        Year = birthYear;
        TaxRate = taxRate;
    }
}

public class Car : Ageable{
    private string Name;
    private string Id;
    private int Year;

    public Car(string model, string vin, int year) : base(year){
        Name = model;
        Id = vin;
        Year = year;
    }
}
