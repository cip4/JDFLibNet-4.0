/*
 * PhysicalResourceAttribs.cs
 * JDFLib4Net
 * Created By Bob Babb (RBabb@kmbs.konicaminolta.us)
 * Last Modified 2016/06/16
 * 
 */
using System.Xml.Serialization;

namespace JDFLib4Net
{
    public class PhysicalResourceAttribs
    {
        /*
          <xs:attributeGroup name="PhysicalResourceAttribs">
            <xs:attribute name="AlternateBrand" type="jdftyp:string" use="optional"/>
            <xs:attribute name="Amount" type="jdftyp:double" use="optional"/>
            <xs:attribute name="AmountProduced" type="jdftyp:double" use="optional"/>
            <xs:attribute name="AmountRequired" type="jdftyp:double" use="optional"/>
            <xs:attribute name="BatchID" type="jdftyp:shortString" use="optional"/>
            <xs:attribute name="Brand" type="jdftyp:string" use="optional"/>
            <xs:attribute name="GrossWeight" type="jdftyp:double" use="optional"/>
            <xs:attribute name="LotControl" type="jdftyp:eLotControl_" use="optional"/>
            <xs:attribute name="Manufacturer" type="jdftyp:string" use="optional"/>
            <xs:attribute name="ResourceWeight" type="jdftyp:double" use="optional"/>
            <xs:attribute name="Unit" type="jdftyp:NMTOKEN" use="optional"/>
          </xs:attributeGroup>
        */

        private string _BatchID;
        private string _LotControl;
        private string _Unit;
        private double _Amount = 0;
        private double _AmountProduced = 0;
        private double _AmountRequired = 0;
        private double _GrossWeight = 0;
        private double _ResourceWeight = 0;

        [XmlAttribute(AttributeName = "AlternateBrand")]
        public string AlternateBrand { get; set; }
        [XmlAttribute(AttributeName = "Amount")]
        public double Amount { get { return _Amount; } set { _Amount = Tools.ValidateDouble(value.ToString()); } }
        [XmlAttribute(AttributeName = "AmountProduced")]
        public double AmountProduced { get { return _AmountProduced; } set { _AmountProduced = Tools.ValidateDouble(value.ToString()); } }
        [XmlAttribute(AttributeName = "AmountRequired")]
        public double AmountRequired { get { return _AmountRequired; } set { _AmountRequired = Tools.ValidateDouble(value.ToString()); } }
        [XmlAttribute(AttributeName = "BatchID")]
        public string BatchID { get { return _BatchID; } set { _BatchID = JDFTypes.SHORTSTRING(value); } }
        [XmlAttribute(AttributeName = "Brand")]
        public string Brand { get; set; }
        [XmlAttribute(AttributeName = "GrossWeight")]
        public double GrossWeight { get { return _GrossWeight; } set { _GrossWeight = Tools.ValidateDouble(value.ToString()); } }
        [XmlAttribute(AttributeName = "LotControl")]
        public string LotControl { get { return _LotControl; } set { _LotControl = Tools.SetEnumValue(typeof(JDFTypes.eLotControl), value); } }
        [XmlAttribute(AttributeName = "Manufacturer")]
        public string Manufacturer { get; set; }
        [XmlAttribute(AttributeName = "ResourceWeight")]
        public double ResourceWeight { get { return _ResourceWeight; } set { _ResourceWeight = Tools.ValidateDouble(value.ToString()); } }
        [XmlAttribute(AttributeName = "Unit")]
        public string Unit { get { return _Unit; } set { _Unit = JDFTypes.NMTOKEN(value); } }
    }
}
