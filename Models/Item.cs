using System.ComponentModel.DataAnnotations;

public class Item
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }
}
