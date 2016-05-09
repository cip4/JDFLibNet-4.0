/*
 * JDF.cs
 * JDFLib4Net
 * Created By Bob Babb (RBabb@kmbs.konicaminolta.us)
 * Last Modified 2016/05/09
 * 
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JDFLib4Net
{
   [XmlRoot(ElementName = "JDF")]
    public class JDF
    {
       private AncestorPool _AncestorPool = new AncestorPool();
       private AuditPool _AuditPool = new AuditPool();
       private CustomerInfo _CustomerInfo = new CustomerInfo();
       private JDF _JDF = new JDF();
       private NodeInfo _NodeInfo = new NodeInfo();
       private ResourcePool _ResourcePool = new ResourcePool();
       private ResourceLinkPool _ResourceLinkPool = new ResourceLinkPool();
       private StatusPool _StatusPool = new StatusPool();

        [XmlAttribute(AttributeName = "Activation")]
        public string Activation { get; set; }
        [XmlAttribute(AttributeName = "Category")]
        public string Category { get; set; }
        [XmlAttribute(AttributeName = "CommentURL")]
        public string CommentURL { get; set; }
        [XmlAttribute(AttributeName = "ICSVersions")]
        public string ICSVersions { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "JobID")]
        public string JobID { get; set; }
        [XmlAttribute(AttributeName = "JobPartID")]
        public string JobPartID { get; set; }
        [XmlAttribute(AttributeName = "MaxVersion")]
        public string MaxVersion { get; set; }
        [XmlAttribute(AttributeName = "SettingsPolicy")]
        public string SettingsPolicy { get; set; }
        [XmlAttribute(AttributeName = "Status")]
        public string Status { get; set; }
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "Types")]
        public string Types { get; set; }
        [XmlAttribute(AttributeName = "Version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xmlns", Namespace = "http://www.CIP4.org/JDFSchema_1_1")]
        public string XMLNS { get; set; }
        [XmlAttribute(AttributeName = "xmlns:xsi", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string XMLNSxsi { get; set; }
        [XmlAttribute(AttributeName = "xsi:type", Namespace = "Combined")]
        public string XSIType { get; set; }
        [XmlElement(ElementName = "NodeInfo")]
        public NodeInfo NodeInfo { get { return _NodeInfo; } set { _NodeInfo = value; } }
        [XmlElement(ElementName = "JDF")]
        public JDF JDFUnbounded { get { return _JDF; } set { _JDF = value; } }
        [XmlElement(ElementName = "CustomerInfo")]
        public CustomerInfo CustomerInfo { get { return _CustomerInfo; } set { _CustomerInfo = value; } }
        [XmlElement(ElementName = "ResourcePool")]
        public ResourcePool ResourcePool { get { return _ResourcePool; } set { _ResourcePool = value; } }
        [XmlElement(ElementName = "ResourceLinkPool")]
        public ResourceLinkPool ResourceLinkPool { get { return _ResourceLinkPool; } set { _ResourceLinkPool = value; } }
        [XmlElement(ElementName = "AncestorPool")]
        public AncestorPool AncestorPool { get { return _AncestorPool; } set { _AncestorPool = value; } }
        [XmlElement(ElementName = "StatusPool")]
        public StatusPool StatusPool { get { return _StatusPool; } set { _StatusPool = value; } }
        [XmlElement(ElementName = "AuditPool")]
        public AuditPool AuditPool { get { return _AuditPool; } set { _AuditPool = value; } }
    }
}
