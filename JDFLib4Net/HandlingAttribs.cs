/*
 * HandlingAttribs.cs
 * JDFLib4Net
 * Created By Bob Babb (RBabb@kmbs.konicaminolta.us)
 * Last Modified 2016/06/16
 * 
 */
using System.Xml.Serialization;

namespace JDFLib4Net
{
    public class HandlingAttribs
    {
        /*
          <xs:attributeGroup name="HandlingAttribs">
            <xs:attribute name="Class" type="jdftyp:NMTOKEN" use="required" fixed="Handling"/>
          </xs:attributeGroup>
        */
        private string _Class;
        [XmlAttribute(AttributeName = "Class")]
        public string Class { get { return _Class; } set { _Class = JDFTypes.NMTOKEN(value); } }

    }
}
