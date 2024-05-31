namespace BackOffice.Models.Courses;

public class CourseModel
{

    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Ingress { get; set; } = null!;
    public string Reviews { get; set; } = null!;
    public string ImageUri { get; set; } = null!;
    public string ImageHeaderUri { get; set; } = null!;
    public string[]? Categories { get; set; }
    public decimal StarRating { get; set; }
    public decimal LikesInNumber { get; set; }
    public decimal LikesInPercent { get; set; }
    public decimal HoursToComplete { get; set; }
    public bool IsDigital { get; set; }
    public bool IsBestSeller { get; set; }


    public virtual Prices Prices { get; set; } = null!;
    public virtual List<Authors> Authors { get; set; } = null!;
    public virtual Content Content { get; set; } = null!;

    //public virtual List<Categories>? Categories { get; set; }
}

//public class Categories
//{
//    public int Id { get; set; }
//    public string? CategoryName { get; set; }
//}

public class Authors
{
    public string AuthorName { get; set; } = null!;

    //public int Id { get; set; }
    //public string? AuthorTitle { get; set; }
    //    public string? AuthorImageUrl { get; set; }
    //    public string? AuthorDescription { get; set; }
    //    public decimal? YoutubeSubs { get; set; }
    //    public decimal? FacebookSubs { get; set; }
}

public class Prices
{
    public decimal Price { get; set; }
    public decimal DiscountedPrice { get; set; }
    public string? Currency { get; set; }
}

public class Content
{
    public string Description { get; set; } = null!;
    public string[] Includes { get; set; } = null!;
    public virtual List<ProgramDetails>? ProgramDetails { get; set; } = null!;
    public string[] LearnPoints { get; set; } = null!;
}

public class ProgramDetails
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
}

