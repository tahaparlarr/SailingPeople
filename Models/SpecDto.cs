using SailingPeople.Domain;

namespace SailingPeople.Models
{
    public class SpecDto
    {
        public Guid Id { get; set; }
        public  string? NameTr { get; set; }
        public  string? NameEn { get; set; }

        public string? LocalizedName
        {
            get
            {
                var culture = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;

                if (culture == "tr")
                {
                    return NameTr;
                }
                return NameEn;
            }

        }
    }
}
