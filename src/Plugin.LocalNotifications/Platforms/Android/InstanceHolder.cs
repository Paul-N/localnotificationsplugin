using System;
namespace Plugin.LocalNotifications;

internal static class InstanceHolder
{
    public static WeakReference<LocalNotificationsImplementation> Instance { get; set; }
}

