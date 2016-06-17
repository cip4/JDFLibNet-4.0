/*
 * ResourceAttribs.cs
 * JDFLib4Net
 * Created By Bob Babb (RBabb@kmbs.konicaminolta.us)
 * Last Modified 2016/06/16
 * 
 */

using System.Xml.Serialization;

namespace JDFLib4Net
{
    public class ResourceAttribs
    {
        /*
           <xs:attributeGroup name="ResourceAttribs">
            <xs:attribute name="AgentName" type="jdftyp:string" use="optional"/>
            <xs:attribute name="AgentVersion" type="jdftyp:string" use="optional"/>
            <xs:attribute name="Author" type="jdftyp:string" use="optional"/>
            <xs:attribute name="CatalogID" type="jdftyp:shortString" use="optional"/>
            <xs:attribute name="CatalogDetails" type="jdftyp:string" use="optional"/>
            <xs:attribute name="ID" type="jdftyp:ID" use="required"/>
            <xs:attribute name="Locked" type="jdftyp:boolean" default="false"/>
            <xs:attribute name="PartUsage" type="jdftyp:ePartUsage_" default="Explicit"/>
            <xs:attribute name="PipeID" type="jdftyp:shortString" use="optional"/>
            <xs:attribute name="PipeProtocol" type="jdftyp:NMTOKEN" use="optional"/>
            <xs:attribute name="PipeURL" type="jdftyp:URL" use="optional"/>
            <xs:attribute name="ProductID" type="jdftyp:shortString" use="optional"/>
            <xs:attribute name="rRefs" type="jdftyp:IDREFS" use="optional"/>
            <xs:attribute name="SpawnIDs" type="jdftyp:NMTOKENS" use="optional"/>
            <xs:attribute name="SpawnStatus" type="jdftyp:eSpawnStatus_" default="NotSpawned"/>
            <xs:attribute name="Status" type="jdftyp:eResourceStatus_" use="required"/>
            <xs:attribute name="UpdateID" type="jdftyp:NMTOKEN" use="optional"/>
          </xs:attributeGroup>
        */
        private string _CatalogID;
        private string _ID;
        private bool _Locked;
        private string _PartUsage;
        private string _PipeID;
        private string _PipeProtocol;
        private string _PipeURL;
        private string _ProductID;
        private string _rRefs;
        private string _SpawnIDs;
        private string _SpawnStatus;
        private string _Status;
        private string _UpdateID;

        [XmlAttribute(AttributeName = "AgentName")]
        public string AgentName { get; set; }
        [XmlAttribute(AttributeName = "AgentVersion")]
        public string AgentVersion { get; set; }
        [XmlAttribute(AttributeName = "Author")]
        public string Author { get; set; }
        [XmlAttribute(AttributeName = "CatalogID")]
        public string CatalogID { get { return _CatalogID; } set { _CatalogID = JDFTypes.SHORTSTRING(value); } }
        [XmlAttribute(AttributeName = "CatalogDetails")]
        public string CatalogDetails { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get { return _ID; } set { _ID = JDFTypes.ID(value); } }
        [XmlAttribute(AttributeName = "Locked")]
        public bool Locked { get { return _Locked; } set { _Locked = JDFTypes.BOOL(value.ToString()); } }
        [XmlAttribute(AttributeName = "PartUsage")]
        public string PartUsage { get { return _PartUsage; } set { _PartUsage = Tools.SetEnumValue(typeof(JDFTypes.ePartUsage), value); } }
        [XmlAttribute(AttributeName = "PipeID")]
        public string PipeID { get { return _PipeID; } set { _PipeID = JDFTypes.SHORTSTRING(value); } }
        [XmlAttribute(AttributeName = "PipeProtocol")]
        public string PipeProtocol { get { return _PipeProtocol; } set { _PipeProtocol = JDFTypes.NMTOKEN(value); } }
        [XmlAttribute(AttributeName = "PipeURL")]
        public string PipeURL { get { return _PipeURL; } set { _PipeURL = JDFTypes.URL(value); } }
        [XmlAttribute(AttributeName = "ProductID")]
        public string ProductID { get { return _ProductID; } set { _ProductID = JDFTypes.SHORTSTRING(value); } }
        [XmlAttribute(AttributeName = "rRefs")]
        public string rRefs { get { return _rRefs; } set { _rRefs = JDFTypes.ID(value); } }
        [XmlAttribute(AttributeName = "SpawnIDs")]
        public string SpawnIDs { get { return _SpawnIDs; } set { _SpawnIDs = JDFTypes.NMTOKENS(value); } }
        [XmlAttribute(AttributeName = "SpawnStatus")]
        public string SpawnStatus { get { return _SpawnStatus; } set { _SpawnStatus = Tools.SetEnumValue(typeof(JDFTypes.eSpawnStatus), value); } }
        [XmlAttribute(AttributeName = "Status")]
        public string Status { get { return _Status; } set { _Status = Tools.SetEnumValue(typeof(JDFTypes.eResourceStatus), value); } }
        [XmlAttribute(AttributeName = "UpdateID")]
        public string UpdateID { get { return _UpdateID; } set { _UpdateID = JDFTypes.NMTOKEN(value); } }

    }
}
