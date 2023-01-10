namespace EFLoadings.ExplicitLoading;

public class Address
{
    public int Id { get; set; }
    public string AddressName { get; set; }

    public List<Region>? Regions { get; set; }
}

public class Region
{
    public int Id { get; set; }
    public string? Name { get; set; }


    public Address? Address { get; set; }
    public int? AddressId { get; set; }
}
