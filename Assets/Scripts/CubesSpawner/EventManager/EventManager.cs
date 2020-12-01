using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSpawner
{
    public static class EventManager
    {
        private static List<ISubscriberDataChange> subsDataChange = new List<ISubscriberDataChange>();
        private static List<ISubscriberDespawner> subsDespawner = new List<ISubscriberDespawner>();
        
        public static void Subscribe(ISubscriberDataChange subscriberDataChange)
        {
            subsDataChange.Add(subscriberDataChange);
        }

        public static void Unsubscribe(ISubscriberDataChange subscriberDataChange)
        {
            subsDataChange.Remove(subscriberDataChange);
        }

        public static void RaiseEvent(LevelData leveldata)
        {
            foreach (var s in subsDataChange)
            {
                s.RaiseEvent(leveldata);
            }
        }
    }
}
