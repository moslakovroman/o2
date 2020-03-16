using ServiceStack.DataAnnotations;

namespace model.ViewModels
{
    [Alias("o2fulladdress")]
    public class AllDbInfoViewModel :BaseModel
    {
        public string zc { get; set; }
        public string cn { get; set; }
        public string sn { get; set; }
    }
}