namespace ExampleToDo.Application.BusinessModels.Response
{
    public class CustomTaskListGroupDto : NamedIdentifiableModel
    {
        public CustomTaskListDto[] CustomTaskLists { get; set; }
    }
}
