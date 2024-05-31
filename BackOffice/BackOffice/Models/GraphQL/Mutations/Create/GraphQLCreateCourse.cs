using BackOffice.Models.Courses;

namespace BackOffice.Models.GraphQL.Mutations;

public class GraphQLCreateCourse
{
    public string Query { get; set; } = null!;
    public object? Variables { get; set; }
}
