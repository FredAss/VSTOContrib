﻿using System.Collections.Specialized;
using FacebookToOutlook.Core;

namespace FacebookToOutlook.Properties
{
    public interface IApplicationSettings
    {
        int AppointmentTaskPaneWidth { get; set; }
        StringCollection FacebookEventCache { get; set; }
        bool MarkAsPrivate { get; set; }
        bool EventReminder { get; set; }
        int RemindMinutesBefore { get; set; }
        BusyStatus ShowTimeAs { get; set; }
        RsvpStatus DownloadTypes { get; set; }
        string Category { get; set; }
        void Save();
    }
}