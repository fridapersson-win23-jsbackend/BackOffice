using BackOffice.Models.Courses;
using static BackOffice.Components.Pages.Courses.EditCourse;

namespace BackOffice.Models.GraphQL.Mutations.Update;

public class GraphQLUpdateVariables
{
    public CourseModel? Input { get; set; }
}
