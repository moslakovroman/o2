using ServiceStack.DataAnnotations;

namespace model.db
{
    [Alias("cloneo2alladdresses")]
    public class Address : BaseModel
    {
        public string zc { get; set; }
        public string cn { get; set; }
        public string sn { get; set; }
    }
}