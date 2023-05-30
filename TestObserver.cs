using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserver
    {
        void Attach(IListenr listenr);
        void Detach(IListenr listenr);
        void Update();
    }

    public interface IListenr
    {
        void NotifyAction();
    }

    public class ObserverSubject : IObserver
    {
        List<IListenr> lstObservers = new List<IListenr>();

        public void Attach(IListenr listenr)
        {
            lstObservers.Add(listenr);
        }

        public void Detach(IListenr listenr)
        {
            lstObservers.Remove(listenr);
        }

        public void Update()
        {
            foreach (IListenr listenr in lstObservers)
                listenr.NotifyAction();
        }
    }
}
