namespace EFLoadings.ExplicitLoading;

public class Contact
{
    public int Id { get; set; }
    public string? Phone { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
    public Provider? Provider { get; set; }
    public int ProviderId { get; set; }
}

public class Provider
{
    public int Id { get; set; }
    public string? Name { get; set; }
}