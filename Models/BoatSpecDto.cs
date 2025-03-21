using SailingPeople.Domain;

namespace SailingPeople.Models;

public class BoatSpecDto
{
    public Guid BoatId { get; set; }
    public Guid SpecId { get; set; }
    public string? ValueTr { get; set; }
    public string? ValueEn { get; set; }
    public virtual BoatDto? Boat { get; set; }
    public virtual SpecDto? Spec { get; set; }
    public string LocalizedValue
    {
        get
        {
            var culture = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;

            if (culture == "tr")
            {
                return ValueTr;
            }
            return ValueEn;
        }

    }
}
