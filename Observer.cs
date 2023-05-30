using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    abstract class Subject
    {
        private List<Observer> m_lstObserver = new List<Observer>();

        public void Attach(Observer observer)
        {
            m_lstObserver.Add(observer);
        }

        public void Detach(Observer observer)
        {
            m_lstObserver.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in m_lstObserver)
                observer.Update();
        }
    }

    class ConcreteSubject : Subject
    {
        private string m_strSubjectState;

        public string SubjectState
        {
            get { return m_strSubjectState; }
            set { m_strSubjectState = value; }
        }
    }

    abstract class Observer
    {
        public abstract void Update();
    }

    class ConcreateObserver : Observer
    {
        private string m_strName;
        private string m_strObserverState;
        private ConcreteSubject m_Subject;

        public ConcreateObserver(ConcreteSubject subject, string strName)
        {
            this.m_Subject = subject;
            this.m_strName = strName;
        }

        public override void Update()
        {
            m_strObserverState = m_Subject.SubjectState;
            Debug.Print("Observer name: {0} State: {1}", m_strName, m_strObserverState);
        }

        public ConcreteSubject Subject
        {
            get { return this.m_Subject; }
            set { m_Subject = value; }
        }
    }
}
