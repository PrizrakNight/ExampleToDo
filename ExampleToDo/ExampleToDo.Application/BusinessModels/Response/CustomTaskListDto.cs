namespace ExampleToDo.Application.BusinessModels.Response
{
    public class CustomTaskListDto : NamedIdentifiableModel
    {
        public CustomTaskDto[] CustomTasks { get; set; }
    }
}
