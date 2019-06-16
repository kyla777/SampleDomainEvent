using System;
using System.Collections.Generic;
using System.Text;
using SampleDomainEvent.Interfaces;
using StructureMap;
using SampleDomainEvent.Infrastructure;

namespace SampleDomainEvent.Events
{
    public static class DomainEvents
    {
        public static readonly Container _container = new Container();

        public static Container GetContainer()
        {
            return _container;
        }

        public static void Raise<T>(T args) where T : IDomainEvent
        {
            if(_container != null)
            {
                foreach (var handler in _container.GetAllInstances<IHandle<T>>())
                {
                    handler.Handle(args);
                }
            }
        }

        #region Test
        public static void Register<T>(Action<T> callback) where T : IDomainEvent
        {
            if (actions == null)
            {
                actions = new List<Delegate>();
            }
            actions.Add(callback);
        }
        #endregion


        //private static List<Delegate> actions;
        //Raise
        //if(actions != null)
        //{
        //    foreach (var action in actions)
        //    {
        //        if(action is Action<T>) {
        //            ((Action<T>)action)(args);
        //        }
        //    }
        //}
    }
}
