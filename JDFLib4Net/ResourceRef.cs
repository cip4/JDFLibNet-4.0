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
    public class ResourceRef
    {
        /*
          <xs:complexType name="ResourceRef" mixed="false">
            <xs:annotation>
              <xs:appinfo>
                <Version Path="Part" First="1.1"/>
                <Version Path="@rSubRef" Last="1.1"/>
                <Constraint Path="Part" minOccurs="0" maxOccurs="1"/>
              </xs:appinfo>
            </xs:annotation>
            <xs:complexContent mixed="false">
              <xs:extension base="jdf:BaseElement_">
                <xs:sequence minOccurs="0" maxOccurs="unbounded">
                  <xs:group ref="jdf:GenericElements" minOccurs="0"/>
                  <xs:element name="Part" type="jdf:Part" minOccurs="0" maxOccurs="unbounded"/>
                </xs:sequence>
                <xs:attribute name="rRef" type="jdftyp:IDREF" use="required"/>
                <xs:attribute name="rSubRef" type="jdftyp:IDREF" use="optional"/>
              </xs:extension>
            </xs:complexContent>
          </xs:complexType>
        */


    }
}
