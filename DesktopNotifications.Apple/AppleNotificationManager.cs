﻿using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

#pragma warning disable 0067

namespace DesktopNotifications.Apple
{
    public class AppleNotificationManager : INotificationManager
    {
        public void Dispose()
        {
        }

        public NotificationManagerCapabilities Capabilities => NotificationManagerCapabilities.None;

        public event EventHandler<NotificationActivatedEventArgs>? NotificationActivated;
        public event EventHandler<NotificationDismissedEventArgs>? NotificationDismissed;

        public string? LaunchActionId { get; }

        public Task Initialize()
        {
            return Task.CompletedTask;
        }

        public Task ShowNotification(Notification notification, DateTimeOffset? expirationTime = null)
        {
            ShowNotification();

            return Task.CompletedTask;
        }

        public Task ScheduleNotification(Notification notification, DateTimeOffset deliveryTime,
            DateTimeOffset? expirationTime = null)
        {
            return Task.CompletedTask;
        }

        public Task HideNotification(Notification notification)
        {
            return Task.CompletedTask;
        }

        [DllImport("DesktopNotifications.Apple.Native.dylib")]
        private static extern void ShowNotification();
    }
}