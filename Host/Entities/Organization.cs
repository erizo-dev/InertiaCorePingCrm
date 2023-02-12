
using PingCrm.Host.Entities.Abstracts;

namespace PingCrm.Host.Entities;

public class Organization : SoftDeletable
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }

    // foreign keys
    public Guid AccountId { get; set; }

    // navigation
    public Account Account { get; set; } = null!;
    public ICollection<Contact> Contacts { get; set; } = null!;

}