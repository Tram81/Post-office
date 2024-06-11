namespace Project3.Comon
{
    public class GetRequestDTO
    {
        public List<FilterRequest> filterRequests { get; set; } = new List<FilterRequest>();

        public string colName { get; set; } = "Id";
        public bool isAsc { get; set; } = true;
        public int index { get; set; } = 1;
        public int size { get; set; } = 3;
    }
    public class FilterRequest
    {
        public string? colName { get; set; }
        public string? _RightSize { get; set; }
        public string? _operator { get; set; }
    }
    public class DeleteRequest
    {
        public int Id { get; set; }
    }
}
