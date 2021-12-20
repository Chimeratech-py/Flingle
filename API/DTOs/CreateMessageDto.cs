using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class CreateMessageDto
    {
        public CreateMessageDto(string recipientUsername, string content)
        {
            RecipientUsername = recipientUsername;
            Content = content;
        }

        public string RecipientUsername { get; set; }
        public string Content { get; set; }
    }
}