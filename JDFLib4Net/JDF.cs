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
using System.Xml;
using System.Xml.Serialization;

namespace JDFLib4Net
{
    [XmlRoot(ElementName = "JDF")]
    public class JDF
    {
        /*
         <xs:attribute name="Activation" type="jdftyp:eActivation_" use="optional"/>
         <xs:attribute name="Category" type="jdftyp:NMTOKEN" use="optional"/>
         <xs:attribute name="ICSVersions" type="jdftyp:NMTOKENS" use="optional"/>
         <xs:attribute name="ID" type="jdftyp:ID" use="required"/>
         <xs:attribute name="JobID" type="jdftyp:shortString" use="optional"/>
         <xs:attribute name="JobPartID" type="jdftyp:shortString" use="optional"/>
         <xs:attribute name="MaxVersion" type="jdftyp:JDFJMFVersion" use="optional"/>
         <xs:attribute name="NamedFeatures" type="jdftyp:NMTOKENS" use="optional"/>
         <xs:attribute name="ProjectID" type="jdftyp:shortString" use="optional"/>
         <xs:attribute name="RelatedJobID" type="jdftyp:shortString" use="optional"/>
         <xs:attribute name="RelatedJobPartID" type="jdftyp:shortString" use="optional"/>
         <xs:attribute name="SpawnID" type="jdftyp:NMTOKEN" use="optional"/>
         <xs:attribute name="Status" type="jdftyp:eNodeStatus_" use="required"/>
         <xs:attribute name="StatusDetails" type="jdftyp:shortString" use="optional"/>
         <xs:attribute name="Template" type="jdftyp:boolean" default="false"/>
         <xs:attribute name="TemplateID" type="jdftyp:shortString" use="optional"/>
         <xs:attribute name="TemplateVersion" type="jdftyp:string" use="optional"/>
         <xs:attribute name="Type" type="jdftyp:NMTOKEN" use="required"/>
         <xs:attribute name="Types" type="jdftyp:NMTOKENS" use="optional"/>
         <xs:attribute name="Version" type="jdftyp:JDFJMFVersion" use="optional"/>
         <xs:anyAttribute namespace="##other" processContents="lax"/>    
       */
        private AncestorPool _AncestorPool = new AncestorPool();
        private AuditPool _AuditPool = new AuditPool();
        private CustomerInfo _CustomerInfo = new CustomerInfo();
        private JDF _JDF = new JDF();
        private NodeInfo _NodeInfo = new NodeInfo();
        private ResourcePool _ResourcePool = new ResourcePool();
        private ResourceLinkPool _ResourceLinkPool = new ResourceLinkPool();
        private StatusPool _StatusPool = new StatusPool();
        private string _Activation;
        private string _Category;
        private string _ICSVersions;
        private string _ID;
        private string _JobID;
        private string _JobPartID;
        private string _MaxVersion;
        private string _NamedFeatures;
        private string _ProjectID;
        private string _RelatedJobID;
        private string _RelatedJobPartID;
        private string _SpawnID;
        public string _Status;
        public string _StatusDetails;
        public bool _Template;
        public string _Type;
        public string _Types;
        public string _Version;

        [XmlAttribute(AttributeName = "Activation")]
        public string Activation { get { return _Activation; } set { _Activation = Tools.SetEnumValue(typeof(JDFTypes.eActivation), value); } }
        [XmlAttribute(AttributeName = "Category")]
        public string Category { get { return _Category; } set { _Category = JDFTypes.NMTOKEN(value); } }
        [XmlAttribute(AttributeName = "ICSVersions")]
        public string ICSVersions { get { return _ICSVersions; } set { _ICSVersions = JDFTypes.NMTOKEN(value); } }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get { return _ID; } set { _ID = JDFTypes.ID(value); } }
        [XmlAttribute(AttributeName = "JobID")]
        public string JobID { get { return _JobID; } set { _JobID = JDFTypes.SHORTSTRING(value); } }
        [XmlAttribute(AttributeName = "JobPartID")]
        public string JobPartID { get { return _JobPartID; } set { _JobPartID = JDFTypes.SHORTSTRING(value); } }
        [XmlAttribute(AttributeName = "MaxVersion")]
        public string MaxVersion { get { return _MaxVersion; } set { _MaxVersion = Tools.ValidateString(JDFTypes.JDFJMFVersion, value); } }
        [XmlAttribute(AttributeName = "NamedFeatures")]
        public string NamedFeatures { get { return _NamedFeatures; } set { _NamedFeatures = JDFTypes.NMTOKEN(value); } }
        [XmlAttribute(AttributeName = "ProjectID")]
        public string ProjectID { get { return _ProjectID; } set { _ProjectID = JDFTypes.SHORTSTRING(value); } }
        [XmlAttribute(AttributeName = "RelatedJobID")]
        public string RelatedJobID { get { return _RelatedJobID; } set { _RelatedJobID = JDFTypes.SHORTSTRING(value); } }
        [XmlAttribute(AttributeName = "RelatedJobPartID")]
        public string RelatedJobPartID { get { return _RelatedJobPartID; } set { _RelatedJobPartID = JDFTypes.SHORTSTRING(value); } }
        [XmlAttribute(AttributeName = "SpawnID")]
        public string SpawnID { get { return _SpawnID; } set { _SpawnID = JDFTypes.NMTOKEN(value); } }
        [XmlAttribute(AttributeName = "Status")]
        public string Status { get { return _Status; } set { _Status = Tools.SetEnumValue(typeof(JDFTypes.eNodeStatus), value); } }
        [XmlAttribute(AttributeName = "StatusDetails")]
        public string StatusDetails { get { return _StatusDetails; } set { _StatusDetails = JDFTypes.SHORTSTRING(value); } }
        [XmlAttribute(AttributeName = "Template")]
        public bool Template { get { return _Template; } set { _Template = JDFTypes.BOOL(value.ToString()); } }
        [XmlAttribute(AttributeName = "TemplateVersion")]
        public string TemplateVersion { get; set; }
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get { return _Type; } set { _Type = JDFTypes.NMTOKEN(value); } }
        [XmlAttribute(AttributeName = "Types")]
        public string Types { get { return _Types; } set { _Types = JDFTypes.NMTOKEN(value); } }
        [XmlAnyAttribute]
        public XmlAttribute[] other { get; set; }

        //Possible Elements
        [XmlElement(ElementName = "NodeInfo", IsNullable = true)]
        public NodeInfo NodeInfo { get { return _NodeInfo; } set { _NodeInfo = value; } }
        [XmlElement(ElementName = "JDF")]
        public JDF JDFa { get { return _JDF; } set { _JDF = value; } }
        [XmlElement(ElementName = "CustomerInfo", IsNullable = true)]
        public CustomerInfo CustomerInfo { get { return _CustomerInfo; } set { _CustomerInfo = value; } }
        [XmlElement(ElementName = "ResourcePool", IsNullable = true)]
        public ResourcePool ResourcePool { get { return _ResourcePool; } set { _ResourcePool = value; } }
        [XmlElement(ElementName = "ResourceLinkPool", IsNullable = true)]
        public ResourceLinkPool ResourceLinkPool { get { return _ResourceLinkPool; } set { _ResourceLinkPool = value; } }
        [XmlElement(ElementName = "AncestorPool", IsNullable = true)]
        public AncestorPool AncestorPool { get { return _AncestorPool; } set { _AncestorPool = value; } }
        [XmlElement(ElementName = "StatusPool", IsNullable = true)]
        public StatusPool StatusPool { get { return _StatusPool; } set { _StatusPool = value; } }
        [XmlElement(ElementName = "AuditPool", IsNullable = true)]
        public AuditPool AuditPool { get { return _AuditPool; } set { _AuditPool = value; } }
    }
}
