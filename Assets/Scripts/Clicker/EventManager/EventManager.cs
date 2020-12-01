using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clicker
{
    public static class EventManager
    {
        private static List<ISubscriber> subs = new List<ISubscriber>();

        public static void Subscribe(ISubscriber subscriber)
        {
            subs.Add(subscriber);
        }

        public static void Unsubscribe(ISubscriber subscriber)
        {
            subs.Remove(subscriber);
        }

        public static void RaiseEvent(string text)
        {
            foreach (var s in subs)
            {
                s.RaiseEvent(text);
            }
        }
    }
}
