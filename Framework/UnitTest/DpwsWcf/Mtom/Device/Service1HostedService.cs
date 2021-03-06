//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     .NET Micro Framework MFSvcUtil.Exe
//     Runtime Version:2.0.00001.0001
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Text;
using System.Xml;
using Dpws.Device;
using Dpws.Device.Services;
using Ws.Services;
using Ws.Services.Mtom;
using Ws.Services.WsaAddressing;
using Ws.Services.Xml;
using Ws.Services.Binding;
using Ws.Services.Soap;

namespace tempuri.org
{
    
    
    public class IDataAccessService : DpwsHostedService
    {
        
        private IIDataAccessService m_service;
        
        public IDataAccessService(IIDataAccessService service, ProtocolVersion version) : 
                base(version)
        {
            // Set the service implementation properties
            m_service = service;

            // Set base service properties
            ServiceNamespace = new WsXmlNamespace("ida", "http://tempuri.org/");
            ServiceID = "urn:uuid:358c10f8-ff82-4e9e-977d-236f02d75e7d";
            ServiceTypeName = "IDataAccessService";

            // Add service types here
            ServiceOperations.Add(new WsServiceOperation("http://tempuri.org/IDataAccessService", "GetData"));
            ServiceOperations.Add(new WsServiceOperation("http://tempuri.org/IDataAccessService", "SetData"));
            ServiceOperations.Add(new WsServiceOperation("http://tempuri.org/IDataAccessService", "SetFileInfo"));
            ServiceOperations.Add(new WsServiceOperation("http://tempuri.org/IDataAccessService", "GetNestedData"));
            ServiceOperations.Add(new WsServiceOperation("http://tempuri.org/IDataAccessService", "SetNestedData"));

            // Add event sources here
        }
        
        public IDataAccessService(IIDataAccessService service) : 
                this(service, new ProtocolVersion10())
        {
        }
        
        public virtual WsMessage GetData(WsMessage request)
        {
            // Build request object
            GetDataDataContractSerializer reqDcs;
            reqDcs = new GetDataDataContractSerializer("GetData", "http://tempuri.org/");
            reqDcs.BodyParts = request.BodyParts;
            GetData req;
            req = ((GetData)(reqDcs.ReadObject(request.Reader)));

            // Create response object
            // Call service operation to process request and return response.
            GetDataResponse resp;
            resp = m_service.GetData(req);

            // Create response header
            WsWsaHeader respHeader = new WsWsaHeader("http://tempuri.org/IDataAccessService/GetDataResponse", request.Header.MessageID, m_version.AnonymousUri, null, null, null);
            WsMessage response = new WsMessage(respHeader, resp, WsPrefix.Wsdp);

            // Create response serializer
            GetDataResponseDataContractSerializer respDcs;
            respDcs = new GetDataResponseDataContractSerializer("GetDataResponse", "http://tempuri.org/");
            response.Serializer = respDcs;

            // Indicate that message is Mtom encoded
            response.BodyParts = new WsMtomBodyParts();
            return response;
        }
        
        public virtual WsMessage SetData(WsMessage request)
        {
            // Build request object
            SetDataDataContractSerializer reqDcs;
            reqDcs = new SetDataDataContractSerializer("SetData", "http://tempuri.org/");
            reqDcs.BodyParts = request.BodyParts;
            SetData req;
            req = ((SetData)(reqDcs.ReadObject(request.Reader)));

            // Create response object
            // Call service operation to process request and return response.
            SetDataResponse resp;
            resp = m_service.SetData(req);

            // Create response header
            WsWsaHeader respHeader = new WsWsaHeader("http://tempuri.org/IDataAccessService/SetDataResponse", request.Header.MessageID, m_version.AnonymousUri, null, null, null);
            WsMessage response = new WsMessage(respHeader, resp, WsPrefix.Wsdp);

            // Create response serializer
            SetDataResponseDataContractSerializer respDcs;
            respDcs = new SetDataResponseDataContractSerializer("SetDataResponse", "http://tempuri.org/");
            response.Serializer = respDcs;

            // Indicate that message is Mtom encoded
            response.BodyParts = new WsMtomBodyParts();
            return response;
        }
        
        public virtual WsMessage SetFileInfo(WsMessage request)
        {
            // Build request object
            SetFileInfoDataContractSerializer reqDcs;
            reqDcs = new SetFileInfoDataContractSerializer("SetFileInfo", "http://tempuri.org/");
            reqDcs.BodyParts = request.BodyParts;
            SetFileInfo req;
            req = ((SetFileInfo)(reqDcs.ReadObject(request.Reader)));

            // Create response object
            // Call service operation to process request and return response.
            SetFileInfoResponse resp;
            resp = m_service.SetFileInfo(req);

            // Create response header
            WsWsaHeader respHeader = new WsWsaHeader("http://tempuri.org/IDataAccessService/SetFileInfoResponse", request.Header.MessageID, m_version.AnonymousUri, null, null, null);
            WsMessage response = new WsMessage(respHeader, resp, WsPrefix.Wsdp);

            // Create response serializer
            SetFileInfoResponseDataContractSerializer respDcs;
            respDcs = new SetFileInfoResponseDataContractSerializer("SetFileInfoResponse", "http://tempuri.org/");
            response.Serializer = respDcs;

            // Indicate that message is Mtom encoded
            response.BodyParts = new WsMtomBodyParts();
            return response;
        }
        
        public virtual WsMessage GetNestedData(WsMessage request)
        {
            // Build request object
            GetNestedDataDataContractSerializer reqDcs;
            reqDcs = new GetNestedDataDataContractSerializer("GetNestedData", "http://tempuri.org/");
            reqDcs.BodyParts = request.BodyParts;
            GetNestedData req;
            req = ((GetNestedData)(reqDcs.ReadObject(request.Reader)));

            // Create response object
            // Call service operation to process request and return response.
            GetNestedDataResponse resp;
            resp = m_service.GetNestedData(req);

            // Create response header
            WsWsaHeader respHeader = new WsWsaHeader("http://tempuri.org/IDataAccessService/GetNestedDataResponse", request.Header.MessageID, m_version.AnonymousUri, null, null, null);
            WsMessage response = new WsMessage(respHeader, resp, WsPrefix.Wsdp);

            // Create response serializer
            GetNestedDataResponseDataContractSerializer respDcs;
            respDcs = new GetNestedDataResponseDataContractSerializer("GetNestedDataResponse", "http://tempuri.org/");
            response.Serializer = respDcs;

            // Indicate that message is Mtom encoded
            response.BodyParts = new WsMtomBodyParts();
            return response;
        }
        
        public virtual WsMessage SetNestedData(WsMessage request)
        {
            // Build request object
            SetNestedDataDataContractSerializer reqDcs;
            reqDcs = new SetNestedDataDataContractSerializer("SetNestedData", "http://tempuri.org/");
            reqDcs.BodyParts = request.BodyParts;
            SetNestedData req;
            req = ((SetNestedData)(reqDcs.ReadObject(request.Reader)));

            // Create response object
            // Call service operation to process request and return response.
            SetNestedDataResponse resp;
            resp = m_service.SetNestedData(req);

            // Create response header
            WsWsaHeader respHeader = new WsWsaHeader("http://tempuri.org/IDataAccessService/SetNestedDataResponse", request.Header.MessageID, m_version.AnonymousUri, null, null, null);
            WsMessage response = new WsMessage(respHeader, resp, WsPrefix.Wsdp);

            // Create response serializer
            SetNestedDataResponseDataContractSerializer respDcs;
            respDcs = new SetNestedDataResponseDataContractSerializer("SetNestedDataResponse", "http://tempuri.org/");
            response.Serializer = respDcs;

            // Indicate that message is Mtom encoded
            response.BodyParts = new WsMtomBodyParts();
            return response;
        }
    }
}
