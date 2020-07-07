using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_4DatingGameOOPEncapAbstract
{
    public class DatingProfile
    {

        public string firstName { get; set; }
        private string lastName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string bio { get; set; }
        public List<Message> myMessages { get; set; }

        public DatingProfile(string firstName, string lastName, int age, string gender) 
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            myMessages = new List<Message>();

        }

        public void WriteBio(string text)
        {
            bio = text;
        }

        public void AddToInbox(Message message) 
        {

            myMessages.Add(message);
        
        }

        public void SendMessage(string messageTitle, string messageData, DatingProfile toProfile)
        {

            Message message = new Message(this, messageTitle, messageData);
            toProfile.AddToInbox(message);

        }

        public void ReadMessage()
        {

            foreach (Message message in myMessages) 
            {

                if (message.isRead == false) 
                {
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;
                }
            
            }

        }
    }
}
