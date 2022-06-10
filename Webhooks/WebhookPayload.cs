namespace mluvii.ApiModels.Webhooks
{
    public class WebhookPayload<T> where T : class, new()
    {
        public string EventType { get; set; }

        public T Data { get; set; }
    }
}
