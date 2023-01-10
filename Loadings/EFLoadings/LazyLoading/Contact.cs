namespace EFLoadings.LazyLoading;

public class Contact
{
    public int Id { get; set; }
    public string? Phone { get; set; }

    public int UserId { get; set; }
    public virtual User? User { get; set; }
    public virtual Provider? Provider { get; set; }
    public int ProviderId { get; set; }
}

public class Provider
{
    public int Id { get; set; }
    public string? Name { get; set; }
}