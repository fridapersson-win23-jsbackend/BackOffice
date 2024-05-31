namespace BackOffice.Models.GraphQL.Mutations.Update
{
    public class GraphQLUpdateCourse
    {
        public string Query { get; set; } = null!;
        public object? UpdatedVariables { get; set; }
    }
}
