/*
 * CustomerInfo.cs
 * JDFLib4Net
 * Created By Bob Babb (RBabb@kmbs.konicaminolta.us)
 * Last Modified 2016/05/09
 * 
 */

using System.Xml.Serialization;

namespace JDFLib4Net
{
    public class CustomerInfo
    {
        /*
          <xs:complexType name="CustomerInfo_" mixed="false">
            <xs:annotation>
              <xs:appinfo>
                <Version Path="@CustomerProjectID" First="1.2"/>
                <Version Path="@rRefs" Last="1.1"/>
                <Version Path="Company" Last="1.0"/>
                <Version Path="CompanyRef" Last="1.0"/>
                <Version Path="Contact" First="1.1"/>
                <Version Path="ContactRef" First="1.1"/>
                <Version Path="CustomerMessage" First="1.2"/>
                <Constraint Path="Company" minOccurs="0" maxOccurs="1"/>
                <Constraint Path="CompanyRef" minOccurs="0" maxOccurs="1"/>
              </xs:appinfo>
            </xs:annotation>
            <xs:complexContent mixed="false">
              <xs:extension base="jdf:BaseElement_">
                <xs:sequence minOccurs="0" maxOccurs="unbounded">
                  <xs:group ref="jdf:GenericElements" minOccurs="0"/>
                  <xs:element name="Company" type="jdf:Company_re" minOccurs="0"/>
                  <xs:element ref="jdf:CompanyRef" minOccurs="0"/>
                  <xs:element name="Contact" type="jdf:Contact_re" minOccurs="0"/>
                  <xs:element ref="jdf:ContactRef" minOccurs="0"/>
                  <xs:element name="CustomerMessage" type="jdf:CustomerInfo_CustomerMessage_l" minOccurs="0"/>
                </xs:sequence>
                <xs:attribute name="BillingCode" type="jdftyp:string" use="optional"/>
                <xs:attribute name="CustomerID" type="jdftyp:shortString" use="optional"/>
                <xs:attribute name="CustomerJobName" type="jdftyp:longString" use="optional"/>
                <xs:attribute name="CustomerOrderID" type="jdftyp:shortString" use="optional"/>
                <xs:attribute name="CustomerProjectID" type="jdftyp:string" use="optional"/>
                <xs:attribute name="rRefs" type="jdftyp:IDREFS" use="optional"/>
              </xs:extension>
            </xs:complexContent>
          </xs:complexType>
        */

        private string _CustomerID;
        private string _CustomerJobName;
        private string _CustomerOrderID;
        private string _rRefs;

        [XmlAttribute(AttributeName = "BillingCode")]
        public string BillingCode { get; set; }
        [XmlAttribute(AttributeName = "CustomerID")]
        public string CustomerID { get { return _CustomerID; } set { _CustomerID = JDFTypes.SHORTSTRING(value); } }
        [XmlAttribute(AttributeName = "CustomerJobName")]
        public string CustomerJobName { get { return _CustomerJobName; } set { _CustomerJobName = JDFTypes.LONGSTRING(value); } }
        [XmlAttribute(AttributeName = "CustomerOrderID")]
        public string CustomerOrderID { get { return _CustomerOrderID; } set { _CustomerOrderID = JDFTypes.SHORTSTRING(value); } }
        [XmlAttribute(AttributeName = "CustomerProjectID")]
        public string CustomerProjectID { get; set; }
        [XmlAttribute(AttributeName = "rRefs")]
        public string rRefs { get { return _rRefs; } set { _rRefs = JDFTypes.ID(value); } }
        [XmlElement(ElementName = "Company", IsNullable = true)]
        public Company Company { get; set; }
    }
}
