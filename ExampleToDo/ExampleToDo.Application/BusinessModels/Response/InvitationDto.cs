using System;

namespace ExampleToDo.Application.BusinessModels.Response
{
    public class InvitationDto
    {
        public string Message { get; set; }

        public DateTime SentIn { get; set; }

        public UserBriefInformationDto SenderInformation { get; set; }
    }
}
