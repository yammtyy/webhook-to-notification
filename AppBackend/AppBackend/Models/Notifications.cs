using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using Microsoft.Azure.NotificationHubs;

namespace AppBackend.Models
{
    public class Notifications
    {
        public static Notifications Instance = new Notifications();

        public NotificationHubClient Hub { get; set; }

        string acccessSignature = ConfigurationManager.AppSettings["DefaultFullSharedAccessSignature"];

        private Notifications()
        {
            Hub = NotificationHubClient.CreateClientFromConnectionString(acccessSignature, "orcNotification");
        }

    }
}