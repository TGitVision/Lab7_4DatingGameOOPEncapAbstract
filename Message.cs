using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_4DatingGameOOPEncapAbstract
{
    public class Message
    {
        public DatingProfile sender { get; set; }
        public string messageTitle { get; set; }

        public string messageData { get; set; }

        public bool isRead { get; set; }

        public Message(DatingProfile sender, string title, string message) 
        {

            this.sender = sender;
            this.messageTitle = title;
            this.messageData = message;
            this.isRead = false;

        }

    }
}
