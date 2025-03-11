using SailingPeople.Domain;

namespace SailingPeople.Models;

public class CategoryDto
{
    public CategoryDto()
    {
    }

    public CategoryDto(Category category)
    {
        Id = category.Id;
        NameTr = category.NameTr;
        NameEn = category.NameEn;
    }
    public Guid Id { get; set; }
    public string NameTr { get; set; }
    public string NameEn { get; set; }

    public string LocalizedName
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
