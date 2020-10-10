namespace ExampleToDo.Application.BusinessModels.Response
{
    public class CustomTaskFileDto : IdentifiableModel
    {
        public string FileName { get; set; }
        public string MimeType { get; set; }
    }
}
