namespace MetaTracker.Domain.Entities;

public class DeckIcon
{
    public int Id { get; set; }
    public string DeckId { get; set; } = string.Empty;
    public string IconName { get; set; } = string.Empty;

    public DeckArchetype Deck { get; set; } = null!;
}