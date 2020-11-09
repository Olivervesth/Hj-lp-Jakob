using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_jakob
{
    

    public class MessageHandler
    {   
      readonly  Convert convert = new Convert();

       
        public void SendMessage(MessageCarrier.Type type, Message m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Type.Smtp))
            {
                if (isHTML)
                    m.Body = convert.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.Type.VMessage))
            {
                if (isHTML)
                    m.Body = convert.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }


        public void SendMessageToAll(MessageCarrier.Type type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Type.Smtp))
            {
                if (isHTML)
                    m.Body = convert.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.Type.VMessage))
            {
                if (isHTML)
                    m.Body = convert.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

    }
}
