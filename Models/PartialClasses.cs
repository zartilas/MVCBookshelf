using MVCBookshelf.Models.Metadata;
using System.ComponentModel.DataAnnotations;

namespace MVCBookshelf.Models
{
    [MetadataType(typeof(AuthorsMetadata))]
    public partial class authors
    { }

    [MetadataType(typeof(DiscountsMetadata))]
    public partial class discounts
    { }

    [MetadataType(typeof(EmployeeMetadata))]
    public partial class employee
    { }

    [MetadataType(typeof(JobsMetadata))]
    public partial class jobs
    { }

    [MetadataType(typeof(PublishersMetadata))]
    public partial class publishers
    { }

    [MetadataType(typeof(PubInfoMetadata))]
    public partial class pub_info
    { }

    [MetadataType(typeof(RoyschedMetadata))]
    public partial class roysched
    { }

    [MetadataType(typeof(SalesMetadata))]
    public partial class sales
    { }

    [MetadataType(typeof(StoreMetadata))]
    public partial class stores
    { }

    [MetadataType(typeof(TitleAuthorsMetadata))]
    public partial class titleauthor
    { }

    [MetadataType(typeof(TitlesMetadata))]
    public partial class titles
    { }
}