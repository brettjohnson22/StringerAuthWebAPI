using System.ComponentModel.DataAnnotations;

namespace StringerWebAPI.DataTransferObjects
{
    public class UserForDisplayDto
    {
        //DTO used when displaying User linked with FK
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    }
}
