using ClosedXML.Excel;

namespace AgriculturePresentation.Controllers
{
    public class ContactModel
    {
        public int ContactID { get; internal set; }
        public DateTime ContactDate { get; internal set; }
        public string ContactMail { get; internal set; }
        public string ContactMessage { get; internal set; }
        public XLCellValue ContactName { get; internal set; }
    }
}