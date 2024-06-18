namespace glitcher.core.Servers
{
    /// <summary>
    /// (Class/Object Definition) WebSocket Server Event (EventArgs)
    /// </summary>
    /// <remarks>
    /// Author: Marco Fernandez (marcofdz.com / glitcher.dev)<br/>
    /// Last modified: 2024.06.18 - June 18, 2024
    /// </remarks>
    public class WebSocketServerEvent : EventArgs
    {
        public string? eventType { get; } = null;

        /// <summary>
        /// Event on WebSocket Server
        /// </summary>
        /// <param name="eventType">Event Type</param>
        public WebSocketServerEvent(string eventType)
        {
            this.eventType = eventType;
        }
    }
}