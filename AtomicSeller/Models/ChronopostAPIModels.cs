using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Xml.Serialization;

namespace ChronopostAPI.Models
{
    /// <summary>
    /// shippingMultiParcelV4 Request
    /// </summary>
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope
    {
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Body
    {
        [XmlElement(ElementName = "shippingMultiParcelV4", Namespace = "")]
        public shippingMultiParcelV4 shippingMultiParcelV4 { get; set; }
    }

    [XmlRoot(ElementName = "shippingMultiParcelV4", Namespace = "")]
    public class shippingMultiParcelV4
    {
        [XmlElement(ElementName = "headerValue", Namespace = "")]
        public headerValue headerValue { get; set; }
        [XmlElement(ElementName = "shipperValue", Namespace = "")]
        public shipperValue shipperValue { get; set; }
        [XmlElement(ElementName = "customerValue", Namespace = "")]
        public customerValue customerValue { get; set; }
        [XmlElement(ElementName = "recipientValue", Namespace = "")]
        public recipientValue recipientValue { get; set; }
        [XmlElement(ElementName = "refValue", Namespace = "")]
        public refValue refValue { get; set; }
        [XmlElement(ElementName = "skybillValue", Namespace = "")]
        public skybillValue skybillValue { get; set; }

        [XmlElement(ElementName = "skybillParamsValue", Namespace = "")]
        public skybillParamsValue skybillParamsValue { get; set; }

        [XmlElement(ElementName = "password", Namespace = "")]
        public string password { get; set; }

        [XmlElement(ElementName = "modeRetour", Namespace = "")]
        public string modeRetour { get; set; }

        [XmlElement(ElementName = "numberOfParcel", Namespace = "")]
        public string numberOfParcel { get; set; }

        [XmlElement(ElementName = "version", Namespace = "")]
        public string version { get; set; }

        [XmlElement(ElementName = "multiParcel", Namespace = "")]
        public string multiParcel { get; set; }
    }

    [XmlRoot(ElementName = "headerValue", Namespace = "")]
    public class headerValue
    {
        public string accountNumber { get; set; }
        public string idEmit { get; set; }
        public string identWebPro { get; set; }
        public string subAccount { get; set; }
    }

    [XmlRoot(ElementName = "shipperValue", Namespace = "")]
    public class shipperValue
    {
        public string shipperAdress1 { get; set; }
        public string shipperAdress2 { get; set; }
        public string shipperCity { get; set; }
        public string shipperCivility { get; set; }
        public string shipperContactName { get; set; }
        public string shipperCountry { get; set; }
        public string shipperCountryName { get; set; }
        public string shipperEmail { get; set; }
        public string shipperMobilePhone { get; set; }
        public string shipperName { get; set; }
        public string shipperName2 { get; set; }
        public string shipperPhone { get; set; }
        public string shipperPreAlert { get; set; }
        public string shipperZipCode { get; set; }
        public string shipperType { get; set; }
    }

    [XmlRoot(ElementName = "customerValue", Namespace = "")]
    public class customerValue
    {
        public string customerAdress1 { get; set; }
        public string customerAdress2 { get; set; }
        public string customerCity { get; set; }
        public string customerCivility { get; set; }
        public string customerContactName { get; set; }
        public string customerCountry { get; set; }
        public string customerCountryName { get; set; }
        public string customerEmail { get; set; }
        public string customerMobilePhone { get; set; }
        public string customerName { get; set; }
        public string customerName2 { get; set; }
        public string customerPhone { get; set; }
        public string customerPreAlert { get; set; }
        public string customerZipCode { get; set; }
        public string printAsSender { get; set; }
    }

    [XmlRoot(ElementName = "recipientValue", Namespace = "")]
    public class recipientValue
    {
        public string recipientName { get; set; }
        public string recipientName2 { get; set; }
        public string recipientAdress1 { get; set; }
        public string recipientAdress2 { get; set; }
        public string recipientZipCode { get; set; }
        public string recipientCity { get; set; }
        public string recipientCountry { get; set; }
        public string recipientContactName { get; set; }
        public string recipientEmail { get; set; }
        public string recipientPhone { get; set; }
        public string recipientMobilePhone { get; set; }
        public string recipientPreAlert { get; set; }
        public string recipientType { get; set; }
    }

    [XmlRoot(ElementName = "refValue", Namespace = "")]
    public class refValue
    {
        public string customerSkybillNumber { get; set; }
        public string recipientRef { get; set; }
        public string shipperRef { get; set; }
        public string idRelais { get; set; }
    }

    [XmlRoot(ElementName = "skybillValue", Namespace = "")]
    public class skybillValue
    {
        public string bulkNumber { get; set; }
        public string codCurrency { get; set; }
        public string codValue { get; set; }
        public string content1 { get; set; }
        public string content2 { get; set; }
        public string content3 { get; set; }
        public string content4 { get; set; }
        public string content5 { get; set; }
        public string customsCurrency { get; set; }
        public string customsValue { get; set; }
        public string evtCode { get; set; }
        public string insuredCurrency { get; set; }
        public string insuredValue { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string masterSkybillNumber { get; set; }
        public string objectType { get; set; }
        public string portCurrency { get; set; }
        public string portValue { get; set; }
        public string productCode { get; set; }
        public string qualite { get; set; }
        public string service { get; set; }
        public string shipDate { get; set; }
        public string shipHour { get; set; }
        public string skybillRank { get; set; }
        public string source { get; set; }
        public string weight { get; set; }
        public string weightUnit { get; set; }
        public string height { get; set; }
        public string length { get; set; }
        public string width { get; set; }
        [XmlElement(ElementName = "as", Namespace = "")]
        public string _as { get; set; }
        public string subAccount { get; set; }
        public string toTheOrderOf { get; set; }
        public string skybillNumber { get; set; }
        public string carrier { get; set; }
        public string skybillBackNumber { get; set; }
        public string alternateProductCode { get; set; }
        public string labelNumber { get; set; }
    }
    [XmlRoot(ElementName = "skybillParamsValue", Namespace = "")]
    public class skybillParamsValue
    {
        public string duplicata { get; set; }
        public string mode { get; set; }
        public string withReservation { get; set; }

    }


    ///
    ///shippingMultiParcelV4 Response
    ///


    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class ResponseEnvelope
    {
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public ResponseBody Body { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class ResponseBody
    {
        [XmlElement(ElementName = "shippingMultiParcelV4Response", Namespace = "http://cxf.shipping.soap.chronopost.fr/")]
        public shippingMultiParcelV4Response shippingMultiParcelV4Response { get; set; }
    }


    [XmlRoot(ElementName = "shippingMultiParcelV4Response", Namespace = "http://cxf.shipping.soap.chronopost.fr/")]
    public class shippingMultiParcelV4Response
    {
        [XmlElement(ElementName = "return", Namespace = "")]
        public returnvalue returnvalue { get; set; }
    }


    [XmlRoot(ElementName = "return", Namespace = "")]
    public class returnvalue
    {
        public string errorCode { get; set; }
        public string errorMessage { get; set; }
        public string reservationNumber { get; set; }
        public resultMultiParcelValue resultMultiParcelValue { get; set; }

    }

    public class resultMultiParcelValue
    {
        public string codeDepot { get; set; }
        public string codeService { get; set; }
        public string destinationDepot { get; set; }
        public string geoPostCodeBarre { get; set; }
        public string geoPostNumeroColis { get; set; }
        public string groupingPriorityLabel { get; set; }
        public string pdfEtiquette { get; set; }
        public string serviceMark { get; set; }
        public string serviceName { get; set; }
        public string signaletiqueProduit { get; set; }
        public string skybillNumber { get; set; }
    }



}