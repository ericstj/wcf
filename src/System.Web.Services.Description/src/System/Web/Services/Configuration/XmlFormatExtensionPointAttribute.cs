namespace System.Web.Services.Configuration
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class XmlFormatExtensionPointAttribute : Attribute {
        private string _name;

        public XmlFormatExtensionPointAttribute(string memberName) {
            _name = memberName;
        }

        public string MemberName {
            get { return _name == null ? string.Empty : _name; }
            set { _name = value; }
        }

        public bool AllowElements { get; set; } = true;
    }
}
