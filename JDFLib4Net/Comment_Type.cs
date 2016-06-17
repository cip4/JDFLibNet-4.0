using System;
using System.Xml;
/*
 * Comment_Type.cs
 * JDFLib4Net
 * Created By Bob Babb (RBabb@kmbs.konicaminolta.us)
 * Last Modified 2016/06/16
 * 
 */
using System.Xml.Serialization;

namespace JDFLib4Net
{
    public class Comment_Type
    {
        /*
          <xs:complexType name="Comment_Type">
            <xs:annotation>
              <xs:appinfo>
                <Version Path="@Attribute" First="1.1"/>
                <Version Path="@AgentName" First="1.3"/>
                <Version Path="@AgentVersion" First="1.3"/>
                <Version Path="@Author" First="1.3"/>
                <Version Path="@ID" First="1.3"/>
                <Version Path="@TimeStamp" First="1.3"/>
              </xs:appinfo>
            </xs:annotation>
            <xs:simpleContent>
              <xs:extension base="jdftyp:CommentString_">
                <xs:attribute name="AgentName" type="jdftyp:string" use="optional"/>
                <xs:attribute name="AgentVersion" type="jdftyp:string" use="optional"/>
                <xs:attribute name="Attribute" type="jdftyp:NMTOKEN" use="optional"/>
                <xs:attribute name="Author" type="jdftyp:string" use="optional"/>
                <xs:attribute name="Box" type="jdftyp:rectangle" use="optional"/>
                <xs:attribute name="ID" type="jdftyp:ID" use="optional"/>
                <xs:attribute name="Language" type="jdftyp:language" use="optional"/>
                <xs:attribute name="Name" type="jdftyp:NMTOKEN" default="Description"/>
                <xs:attribute name="Path" type="jdftyp:PDFPath" use="optional"/>
                <xs:attribute name="TimeStamp" type="jdftyp:dateTime" use="optional"/>
                <xs:anyAttribute namespace="##other" processContents="lax"/>
              </xs:extension>
            </xs:simpleContent>
          </xs:complexType>
        */
        private string _Attribute;
        private string _Name;
        private TypeRectangle _Box;
        private string _ID;

        [XmlAttribute(AttributeName = "AgentName")]
        public string AgentName { get; set; }
        [XmlAttribute(AttributeName = "AgentVersion")]
        public string AgentVersion { get; set; }
        [XmlAttribute(AttributeName = "Attribute")]
        public string Attribute { get { return _Attribute; } set { _Attribute = JDFTypes.NMTOKEN(value); } }
        [XmlAttribute(AttributeName = "Author")]
        public string Author { get; set; }
        [XmlAttribute(AttributeName = "Box")]
        public TypeRectangle Box { get { return _Box; } set { _Box = JDFTypes.BOX(value.ToString()); } }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get { return _ID; } set { _ID = JDFTypes.ID(value); } }
        [XmlAttribute(AttributeName = "Language")]
        public string Language { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get { return _Name; } set { _Name = JDFTypes.NMTOKEN(value); } }
        [XmlAttribute(AttributeName = "TimeStamp")]
        public DateTime TimeStamp { get; set; }
        [XmlAnyAttribute]
        public XmlAttribute[] other { get; set; }


    }
}
