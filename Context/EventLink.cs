namespace crm.service.database
{
    public class EventLink
    {
        public int Id { get; set; }
        public int CrmKey { get; set; }
        public System.Guid lCKey { get; set; }

        public string Title { get; set; }
        public string Type { get; set; }
        public string Department { get; set; }
        public string PartTime { get; set; }
    }
}