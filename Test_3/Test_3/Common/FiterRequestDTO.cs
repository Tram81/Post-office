namespace Test_3.Common
{
    public class GetRequestDTO
    {
        public List<FilterRequest> filters { get; set; } = new List<FilterRequest>();
        public string colName { get; set; } = "Id";
        public bool isAsc { get; set; } = true;
        public int index { get; set; } = 1;
        public int size { get; set; } = 10;
    }

    public class FilterRequest
    {
        public string? colName { get; set; }
        public string? _operator { get; set; }
        public string? rightSize { get; set; }
    }
}
