﻿using CitizenFX.Core;
using System;
using System.Threading.Tasks;

namespace VORP.Inventory.Server.Scripts
{
    public class Manager : BaseScript
    {
        public PluginManager Instance = PluginManager.Instance;

        public void AddEvent(string eventName, Delegate @delegate) => Instance.Hook(eventName, @delegate);
        public void AttachTickHandler(Func<Task> task) => Instance.AttachTickHandler(task);
        public void DetachTickHandler(Func<Task> task) => Instance.AttachTickHandler(task);
    }
}
