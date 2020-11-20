using System;
using System.Collections.Generic;

namespace Singleton
{
    public class MessageQueue
    {
        #region Properties
        private static readonly Lazy<MessageQueue> lazyInstance = new Lazy<MessageQueue>(() => new MessageQueue());
        public static MessageQueue Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }
        private Queue<Message> Queue = new Queue<Message>();
        #endregion

        private MessageQueue() 
        {
            Console.WriteLine("Initialized!");
        }

        public void EnqueueMessage(Message message)
        {
            Console.WriteLine("Message getting Queued - Id: {0}, Text: {1}, CreatedTime: {2}", message.Id, message.Text, message.CreatedTime);
            lock (Queue)
            {
                Queue.Enqueue(message);
            }
        }

        public Message DequeueMessage()
        {
            Message message;
            Queue.TryDequeue(out message);
            return message;
        }

        public void DequeueAll()
        {
            while(Queue.Count != 0)
            {
                Message message = DequeueMessage();
                Console.WriteLine("Message getting Dequeued - Id: {0}, Text: {1}, CreatedTime: {2}", message.Id, message.Text, message.CreatedTime);
            }
        }
    }
}
