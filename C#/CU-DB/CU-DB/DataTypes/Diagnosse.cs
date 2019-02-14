using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_DB.DataTypes
{
    public class Diagnosse
    {
        public double? StressLevel { get; set; }
        public double? ID { get; set; }
        public string SessionName { get; set; }
        public string User { get; set; }
        public string CitrixReceiverVersion { get; set; }
        public string State { get; set; }
        public DateTime? ConnectTime { get; set; }
        public DateTime? DisconnectTime { get; set; }
        public long? IdleTime { get; set; }
        public double? IdleTimeMin { get; set; }
        public DateTime? LogonTime { get; set; }
        public double? Processes { get; set; }
        public double? LatencyLast { get; set; }
        public double? BandwidthLast { get; set; }
        public double? RTT { get; set; }
        public double? BandwidthAvg { get; set; }
        public double? BandwidthLimit { get; set; }
        public double? LatencyAvg { get; set; }
        public double? ClientIP { get; set; }
        public string BranchName { get; set; }
        public string ClientName { get; set; }
        public string Computer { get; set; }
        public string DomainDNS { get; set; }
        public string InitialProgram { get; set; }
        public string CPU { get; set; }
        public double? PageFaultsSec { get; set; }
        public double? IOReadOperationsSec { get; set; }
        public double? IOWriteOperationSec { get; set; }
        public double? MemoryPrivateBytes { get; set; }
        public string MemoryWorkingSet { get; set; }
        public string ViewClientConnectionServerURL { get; set; }
        public string ViewClientDomain { get; set; }
        public string ViewClientProtocol { get; set; }
        public string ViewClientType { get; set; }
        public string ViewClientTunnel { get; set; }
        public string UserLogenServer { get; set; }
        public string GroupPolicyLoadTime { get; set; }
        public double? ProfileLoadTime { get; set; }
        public double? logonDurationOther { get; set; }
        public double? DesktopLoadTime { get; set; }
        public double? LogonDuration { get; set; }
        public DateTime? SessionCreateTime { get; set; }
        public string UserADDN { get; set; }
        public string UserADOU { get; set; }
        public string UserFullName { get; set; }
        public double? AvgAppLoadTime { get; set; }
        
        public string GPUCPUUtilization { get; set; }
        public double? GPUFrameBufferMemryUtilization { get; set; }
        public double? GPUencoderUtilization { get; set; }
        public double? GPUdecoderUtilization { get; set; }
        public double? XDSiteName { get; set; }
        public double? XDSessionCreateTime { get; set; }
        public string XDLogonDuration { get; set; }
        public string XDPublishedResourceType { get; set; }
        public string XDAnonymous { get; set; }
        public string XDConnectedViaHostName { get; set; }
        public string XDConnectedViaIPAddress { get; set; }
        public string XDLaunchedViaHostName { get; set; }
        public string XDLaunchedViaIPAddress { get; set; }
        public string XDSessionReconnected { get; set; }
        public string XDSecureICASession { get; set; }
        public string Protocol { get; set; }
        public string XDBrokeringDuration { get; set; }
        public string XDBrokeringDate { get; set; }
        public string XDVMStartDuration { get; set; }
        public string XDClientSessionValidateDate { get; set; }
        public string XDServerSessionValidateDate { get; set; }
        public string XDEstablishmentDate { get; set; }
        public string XDHDXConnectionLoadTime { get; set; }
        public string XDAuthenticationDuration { get; set; }
        public string XDGroupPolicyLoadTime { get; set; }
        public string XDLogonScriptsLoadTime { get; set; }
        public string XDProfileLoadTime { get; set; }
        public string XDInteractiveSessionLoadTime { get; set; }
        public string XDUPN { get; set; }
        public string XDAppsInUse { get; set; }
        public string XDAppsInUseCount { get; set; }
        public string XDDisconnectReason { get; set; }
        public string XDDisconnectDate { get; set; }
        public string XDDeliveryGroup { get; set; }



    }
}
