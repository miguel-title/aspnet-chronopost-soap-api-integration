using AtomicSeller.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Web;
using AtomicSeller.ViewModels;
using ChronopostAPI.Models;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

using System.Xml.Serialization;
using System.Xml;
using System.Text;

namespace AtomicSeller.Helpers.eCommerceConnectors
{
    public class Chronopost
    {

        private static String m_AccountNumber = "19869502";
        private static String m_Password = "255562";
        private static String API_URL = "https://ws.chronopost.fr/shipping-cxf/ShippingServiceWS";

        public ResponseEnvelope Chronopost_SendParcelInfo()
        {
            string jsonParam = string.Empty;

            Envelope _Envelope= new Envelope();
            Body _Body = new Body();
            _Envelope.Body = _Body;
            shippingMultiParcelV4 _shippingMultiParcelV4 = new shippingMultiParcelV4();
            _Body.shippingMultiParcelV4 = _shippingMultiParcelV4;
            headerValue _headerValue = new headerValue();
            _shippingMultiParcelV4.headerValue = _headerValue;
            _headerValue.accountNumber = m_AccountNumber;
            _headerValue.idEmit = "CHRFR";
            _headerValue.identWebPro = "";
            _headerValue.subAccount = "";
            shipperValue _shipperValue = new shipperValue();
            _shippingMultiParcelV4.shipperValue = _shipperValue;
            _shipperValue.shipperAdress1 = "ADRESSE EXPEDITEUR";
            _shipperValue.shipperAdress2 = "ADRESSE EXPEDITEUR";
            _shipperValue.shipperCity = "PARIS";
            _shipperValue.shipperCivility = "M";
            _shipperValue.shipperContactName = "CONTACT EXPEDITEUR";
            _shipperValue.shipperCountry = "FR";
            _shipperValue.shipperCountryName = "FRANCE";
            _shipperValue.shipperEmail = "adresse@mail.fr";
            _shipperValue.shipperMobilePhone = "";
            _shipperValue.shipperName = "NOM EXPEDITEUR";
            _shipperValue.shipperName2 = "ADRESSE EXPEDITEUR";
            _shipperValue.shipperPhone = "0102030405";
            _shipperValue.shipperPreAlert = "0";
            _shipperValue.shipperZipCode = "75002";
            _shipperValue.shipperType = "1";
            customerValue _customerValue = new customerValue();
            _shippingMultiParcelV4.customerValue = _customerValue;
            _customerValue.customerAdress1 = "ADRESSE CLIENT";
            _customerValue.customerAdress2 = "";
            _customerValue.customerCity = "PARIS";
            _customerValue.customerCivility = "M";
            _customerValue.customerContactName = "CONTACT CLIENT";
            _customerValue.customerCountry = "FR";
            _customerValue.customerCountryName = "FRANCE";
            _customerValue.customerEmail = "adresse@mail.fr";
            _customerValue.customerMobilePhone = "";
            _customerValue.customerName = "NOM CLIENT";
            _customerValue.customerName2 = "";
            _customerValue.customerPhone = "0600000000";
            _customerValue.customerPreAlert = "0";
            _customerValue.customerZipCode = "75002";
            _customerValue.printAsSender = "N";
            recipientValue _recipientValue = new recipientValue();
            _shippingMultiParcelV4.recipientValue = _recipientValue;
            _recipientValue.recipientName = "NOM DESTINATAIRE";
            _recipientValue.recipientName2 = "";
            _recipientValue.recipientAdress1 = "ADRESSE 1 DESTINATAIRE";
            _recipientValue.recipientAdress2 = "NOMADRESSE 2 DESTINATAIRE";
            _recipientValue.recipientZipCode = "1030";
            _recipientValue.recipientCity = "BRUXELLES";
            _recipientValue.recipientCountry = "BE";
            _recipientValue.recipientContactName = "CONTACT DESTINATAIRE";
            _recipientValue.recipientEmail = "mail@gmail.com";
            _recipientValue.recipientPhone = "1234567890";
            _recipientValue.recipientMobilePhone = "";
            _recipientValue.recipientPreAlert = "0";
            _recipientValue.recipientType = "2";
            refValue _refValue = new refValue();
            _shippingMultiParcelV4.refValue = _refValue;
            _refValue.customerSkybillNumber = "";
            _refValue.recipientRef = "REF DESTINATAIRE";
            _refValue.shipperRef = "REF EXPEDITEUR";
            _refValue.idRelais = "";
            skybillValue _skybillValue = new skybillValue();
            _shippingMultiParcelV4.skybillValue = _skybillValue;
            _skybillValue.bulkNumber = "1";
            _skybillValue.codCurrency = "EUR";
            _skybillValue.codValue = "0";
            _skybillValue.content1 = "";
            _skybillValue.content2 = "";
            _skybillValue.content3 = "";
            _skybillValue.content4 = "";
            _skybillValue.content5 = "";
            _skybillValue.customsCurrency = "EUR";
            _skybillValue.customsValue = "";
            _skybillValue.evtCode = "DC";
            _skybillValue.insuredCurrency = "EUR";
            _skybillValue.insuredValue = "0";
            _skybillValue.latitude = "";
            _skybillValue.longitude = "";
            _skybillValue.masterSkybillNumber = "";
            _skybillValue.objectType = "MAR";
            _skybillValue.portCurrency = "";
            _skybillValue.portValue = "0";
            _skybillValue.productCode = "44";
            _skybillValue.qualite = "";
            _skybillValue.service = "0";
            _skybillValue.shipDate = "2020-07-08";
            _skybillValue.shipHour = "17";
            _skybillValue.skybillRank = "1";
            _skybillValue.source = "";
            _skybillValue.weight = "10";
            _skybillValue.weightUnit = "KGM";
            _skybillValue.height = "30";
            _skybillValue.length = "50";
            _skybillValue.width = "40";
            _skybillValue._as = "";
            _skybillValue.subAccount = "";
            _skybillValue.toTheOrderOf = "";
            _skybillValue.skybillNumber = "";
            _skybillValue.carrier = "1";
            _skybillValue.skybillBackNumber = "";
            _skybillValue.alternateProductCode = "";
            _skybillValue.labelNumber = "";
            skybillParamsValue _skybillParamsValue = new skybillParamsValue();
            _shippingMultiParcelV4.skybillParamsValue = _skybillParamsValue;
            _skybillParamsValue.duplicata = "N";
            _skybillParamsValue.mode = "PDF";
            _skybillParamsValue.withReservation = "2";
            _shippingMultiParcelV4.password = m_Password;
            _shippingMultiParcelV4.modeRetour = "2";
            _shippingMultiParcelV4.numberOfParcel = "1";
            _shippingMultiParcelV4.version = "2.0";
            _shippingMultiParcelV4.multiParcel = "N";

            XmlSerializer xsSubmit = new XmlSerializer(typeof(Envelope));

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            ns.Add("soap", "http://schemas.xmlsoap.org/soap/envelope/");
            ns.Add("cxf", "http://cxf.shipping.soap.chronopost.fr/");

            string XML = string.Empty;

            using (var sww = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.OmitXmlDeclaration = true;
                //settings.ConformanceLevel = ConformanceLevel.Fragment;
                //settings.CloseOutput = false;

                using (XmlWriter writer = XmlWriter.Create(sww, settings))
                {
                    xsSubmit.Serialize(
                        writer,
                        _Envelope,
                        ns
                        );
                    XML = sww.ToString().Replace(" xmlns=\"\"", "");
                }
            }

            HttpWebRequest _HttpWebRequest = CreateWebRequest();

            var encodingType = Encoding.GetEncoding("ISO-8859-1"); // Encoding.UTF8; // Encoding.Unicode Encoding.ASCII Encoding.GetEncoding("ISO-8859-1")

            using (StreamWriter writer = new StreamWriter(_HttpWebRequest.GetRequestStream(), encodingType))
            {
                writer.WriteLine(XML);
            }

            string soapResult = string.Empty;
            ResponseEnvelope _ResponseEnvelope = new ResponseEnvelope();
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)_HttpWebRequest.GetResponse())
                {
                    using (StreamReader rd = new StreamReader(response.GetResponseStream(), encodingType))
                    {
                        soapResult = rd.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                return _ResponseEnvelope;
            }

            _ResponseEnvelope = deserialize(soapResult);

            return _ResponseEnvelope;
        }

        public ResponseEnvelope deserialize(string inputXml)
        {
            ResponseEnvelope Result = new ResponseEnvelope();

            XmlSerializer serializer = new XmlSerializer(typeof(ResponseEnvelope));

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            ns.Add("soap", "http://schemas.xmlsoap.org/soap/envelope/");
            ns.Add("ns1", "http://cxf.shipping.soap.chronopost.fr/");

            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(inputXml);
            writer.Flush();
            stream.Position = 0;

            StreamReader reader = new StreamReader(stream);
            Result = (ResponseEnvelope)serializer.Deserialize(reader);

            return Result;
        }

        private HttpWebRequest CreateWebRequest()
        {
            const SslProtocols _Tls12 = (SslProtocols)0x00000C00;
            const SecurityProtocolType Tls12 = (SecurityProtocolType)_Tls12;
            ServicePointManager.SecurityProtocol = Tls12;

            System.Net.HttpWebRequest httpWebRequest;

            httpWebRequest = (HttpWebRequest)WebRequest.Create(API_URL);

            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "text/xml";

            return httpWebRequest;

        }

        public static string ErrorMessage = "";

    }
}