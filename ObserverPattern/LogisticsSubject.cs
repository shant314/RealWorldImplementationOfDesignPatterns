using System;

namespace ObserverPattern
{
    // a class that can be observed, this class allows us to add observers 
    public class LogisticsSubject
    {
        //enforce immutability at the class level.
        private readonly List<ILogisticsObserver> _logisticsObservers;

        public LogisticsSubject()
        {
            _logisticsObservers = new List<ILogisticsObserver>();
        }

        //add observer to the private list.
        public void Attach(ILogisticsObserver observer)
        {
            _logisticsObservers.Add(observer);
            PrintObserverCount();
        }

        //remove observer form the list.
        public void Detach(ILogisticsObserver observer)
        {
            _logisticsObservers.Remove(observer);
            PrintObserverCount();
        }

        //simply prints the number of observers stored within the private _logisticsObservers field.
        private void PrintObserverCount()
        {
            switch (_logisticsObservers.Count)
            {
                case <= 0:
                    Console.WriteLine("There are no observers.");
                    break;
                case 1:
                    Console.WriteLine("There is 1 observer.");
                    break;
                case > 1:
                    Console.WriteLine("There are " + _logisticsObservers.Count + " observers.");
                    break;

            }
        }


        // send notification to all subscribed observers, one by one.
        public void NotifyPickupAvailable()
        {
            foreach (var observer in _logisticsObservers)
            {
                observer.SchedulePickup();
            }
        }
    }
}
/*About using a readony list.
    In the case of a List<ILogisticsObserver> like _logisticsObservers, making it readonly 
    means that the reference to the list itself cannot be changed after it's been assigned. 
    However, it's important to note that the content of the list (i.e., the elements within the list) can still be modified.
    You can add, remove, or modify elements within the list, but you cannot assign a new list to the _logisticsObservers variable.
 */