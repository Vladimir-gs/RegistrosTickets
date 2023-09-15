using Radzen;

namespace RegistrosTickets.Extensors
{
    public static class Notificaciones
    {
        public static void ShowNotificacion(this NotificationService notifier,
            string titulo,
            string mensaje,
            NotificationSeverity severity)
        {
            var message = new NotificationMessage
            {
                Severity = severity,
                Summary = titulo,
                Detail = mensaje,
                Duration = 3000
            };

            notifier.Notify(message);
        }
    }
}
