namespace ObserverPattern
{
    public class ExFedObserver: ILogisticsObserver
    {
        public void SchedulePickup()
        {
            //in reality, you may have an API call here instead of console log.
            Console.WriteLine("ExFed has been notified that a shipment is ready for pick up.");
        }
    }
}
