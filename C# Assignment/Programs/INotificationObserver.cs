using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{

// Observer Interface
public interface INotificationObserver
    {
        void Update(string message);
    }

    // Concrete Observers
    public class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"📧 Email Notification: {message}");
        }
    }

    public class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"📱 SMS Notification: {message}");
        }
    }

    // Subject (Observable)
    public class NotificationService
    {
        private List<INotificationObserver> _observers = new List<INotificationObserver>();

        public void Subscribe(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        NotificationService service = new NotificationService();

    //        INotificationObserver emailNotifier = new EmailNotifier();
    //        INotificationObserver smsNotifier = new SMSNotifier();

    //        service.Subscribe(emailNotifier);
    //        service.Subscribe(smsNotifier);

    //        Console.WriteLine("🔔 Sending Notification...");
    //        service.Notify("New product launch tomorrow!");

    //        service.Unsubscribe(smsNotifier);

    //        Console.WriteLine("\n🔔 Sending another Notification...");
    //        service.Notify("Flash sale starts now!");
    //    }
    //}

}