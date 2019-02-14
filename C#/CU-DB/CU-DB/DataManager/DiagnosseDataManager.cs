using CU_DB.DataTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_DB.DataManager
{
    public class DiagnosseDataManager
    {
        //private string CleanString(string str)
        //{

        //    str = str.Replace(",", ".");

        //    return str;
        //}

        string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=CU;Integrated Security = true";

        // Transportieren
        public void InsertDataToDb(string filepath)
        {
            FileManager f = new FileManager();

            var records = f.ReadLogFile(filepath);

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                        "INSERT INTO dbo.Log (StressLevel," +
                        "ID," +
                        "SessionName," +
                        "[User]," +
                        "CitrixReceiverVersion," +
                        "State," +
                        "ConnectTime," +
                        "DisconnectTime," +
                        "IdleTime," +
                        "IdleTimeMin," +
                        "LogonTime," +
                        "Processes," +
                        "LatencyLast," +
                        "BandwidthLast," +
                        "RTT," +
                        "BandwidthAvg," +
                        "BandwidthLimit," +
                        "LatencyAvg," +
                        "ClientIP," +
                        "BranchName," +
                        "ClientName," +
                        "Computer," +
                        "DomainDNS," +
                        "InitialProgram," +
                        "CPU," +
                        "PageFaultsSec," +
                        "IOReadOperationsSec," +
                        "IOWriteOperationSec," +
                        "MemoryPrivateBytes," +
                        "MemoryWorkingSet," +
                        "ViewClientConnectionServerURL," +
                        "ViewClientDomain," +
                        "ViewClientProtocol," +
                        "ViewClientType," +
                        "ViewClientTunnel," +
                        "UserLogonServer," +
                        "GroupPolicyLoadTime," +
                        "ProfileLoadTime," +
                        "logonDurationOther," +
                        "DesktopLoadTime," +
                        "LogonDuration," +
                        "SessionCreateTime," +
                        "UserADDN," +
                        "UserADOU," +
                        "UserFullName," +
                        "AvgAppLoadTime," +
                        "GPUCPUUtilization," +
                        "GPUFrameBufferMemoryUtilization," +
                        "GPUencoderUtilization," +
                        "GPUdecoderUtilization," +
                        "XDSiteName," +
                        "XDSessionCreateTime," +
                        "XDLogonDuration," +
                        "XDPublishedResourceType," +
                        "XDAnonymous," +
                        "XDConnectedViaHostName," +
                        "XDConnectedViaIPAddress," +
                        "XDLaunchedViaHostName," +
                        "XDLaunchedViaIPAddress," +
                        "XDSessionReconnected," +
                        "XDSecureICASession," +
                        "Protocol," +
                        "XDBrokeringDuration," +
                        "XDBrokeringDate," +
                        "XDVMStartDuration," +
                        "XDClientSessionValidateDate," +
                        "XDServerSessionValidateDate," +
                        "XDEstablishmentDate," +
                        "XDHDXConnectionLoadTime," +
                        "XDAuthenticationDuration," +
                        "XDGroupPolicyLoadTime," +
                        "XDLogonScriptsLoadTime," +
                        "XDProfileLoadTime," +
                        "XDInteractiveSessionLoadTime," +
                        "XDUPN," +
                        "XDAppsInUse," +
                        "XDAppsInUseCount," +
                        "XDDisconnectReason," +
                        "XDDisconnectDate," +
                        "XDDeliveryGroup) " +


                        " VALUES (@StressLevel," +
                        "@ID," +
                        "@SessionName," +
                        "@User," +
                        "@CitrixReceiverVersion," +
                        "@State," +
                        "@ConnectTime," +
                        "@DisconnectTime," +
                        "@IdleTime," +
                        "@IdleTimeMin," +
                        "@LogonTime," +
                        "@Processes," +
                        "@LatencyLast," +
                        "@BandwidthLast," +
                        "@RTT," +
                        "@BandwidthAvg," +
                        "@BandwidthLimit," +
                        "@LatencyAvg," +
                        "@ClientIP," +
                        "@BranchName," +
                        "@ClientName," +
                        "@Computer," +
                        "@DomainDNS," +
                        "@InitialProgram," +
                        "@CPU," +
                        "@PageFaultsSec," +
                        "@IOReadOperationsSec," +
                        "@IOWriteOperationSec," +
                        "@MemoryPrivateBytes," +
                        "@MemoryWorkingSet," +
                        "@ViewClientConnectionServerURL," +
                        "@ViewClientDomain," +
                        "@ViewClientProtocol," +
                        "@ViewClientType," +
                        "@ViewClientTunnel," +
                        "@UserLogenServer," +
                        "@GroupPolicyLoadTime," +
                        "@ProfileLoadTime," +
                        "@logonDurationOther," +
                        "@DesktopLoadTime," +
                        "@LogonDuration," +
                        "@SessionCreateTime," +
                        "@UserADDN," +
                        "@UserADOU," +
                        "@UserFullName," +
                        "@AvgAppLoadTime," +
                        "@GPUCPUUtilization," +
                        "@GPUFrameBufferMemryUtilization," +
                        "@GPUencoderUtilization," +
                        "@GPUdecoderUtilization," +
                        "@XDSiteName," +
                        "@XDSessionCreateTime," +
                        "@XDLogonDuration," +
                        "@XDPublishedResourceType," +
                        "@XDAnonymous," +
                        "@XDConnectedViaHostName," +
                        "@XDConnectedViaIPAddress," +
                        "@XDLaunchedViaHostName," +
                        "@XDLaunchedViaIPAddress," +
                        "@XDSessionReconnected," +
                        "@XDSecureICASession," +
                        "@Protocol," +
                        "@XDBrokeringDuration," +
                        "@XDBrokeringDate," +
                        "@XDVMStartDuration," +
                        "@XDClientSessionValidateDate," +
                        "@XDServerSessionValidateDate," +
                        "@XDEstablishmentDate," +
                        "@XDHDXConnectionLoadTime," +
                        "@XDAuthenticationDuration," +
                        "@XDGroupPolicyLoadTime," +
                        "@XDLogonScriptsLoadTime," +
                        "@XDProfileLoadTime," +
                        "@XDInteractiveSessionLoadTime," +
                        "@XDUPN," +
                        "@XDAppsInUse," +
                        "@XDAppsInUseCount," +
                        "@XDDisconnectReason," +
                        "@XDDisconnectDate," +
                        "@XDDeliveryGroup)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@StressLevel", DbType.Decimal);
                cmd.Parameters.Add("@ID", DbType.Decimal);
                cmd.Parameters.Add("@SessionName", DbType.String);
                cmd.Parameters.Add("@User", DbType.String);
                cmd.Parameters.Add("@CitrixReceiverVersion", DbType.String);
                cmd.Parameters.Add("@State", DbType.String);
                cmd.Parameters.Add("@ConnectTime", DbType.DateTime);
                cmd.Parameters.Add("@DisconnectTime", DbType.DateTime);
                cmd.Parameters.Add("@IdleTime", SqlDbType.BigInt);
                cmd.Parameters.Add("@IdleTimeMin", SqlDbType.Decimal);
                cmd.Parameters.Add("@LogonTime", SqlDbType.DateTime);
                cmd.Parameters.Add("@Processes", DbType.Double);
                cmd.Parameters.Add("@LatencyLast", DbType.Double);
                cmd.Parameters.Add("@BandwidthLast", DbType.Double);
                cmd.Parameters.Add("@RTT", DbType.Double);
                cmd.Parameters.Add("@BandwidthAvg", DbType.Double);
                cmd.Parameters.Add("@BandwidthLimit", DbType.Double);
                cmd.Parameters.Add("@LatencyAvg", DbType.Double);
                cmd.Parameters.Add("@ClientIP", DbType.Double);
                cmd.Parameters.Add("@BranchName", DbType.String);
                cmd.Parameters.Add("@ClientName", DbType.String);
                cmd.Parameters.Add("@Computer", DbType.String);
                cmd.Parameters.Add("@DomainDNS", DbType.String);
                cmd.Parameters.Add("@InitialProgram", DbType.String);
                cmd.Parameters.Add("@CPU", DbType.String);
                cmd.Parameters.Add("@PageFaultsSec", DbType.Double);
                cmd.Parameters.Add("@IOReadOperationsSec", DbType.Double);
                cmd.Parameters.Add("@IOWriteOperationSec", DbType.Double);
                cmd.Parameters.Add("@MemoryPrivateBytes", DbType.Double);
                cmd.Parameters.Add("@MemoryWorkingSet", DbType.String);
                cmd.Parameters.Add("@ViewClientConnectionServerURL", DbType.String);
                cmd.Parameters.Add("@ViewClientDomain", DbType.String);
                cmd.Parameters.Add("@ViewClientProtocol", DbType.String);
                cmd.Parameters.Add("@ViewClientType", DbType.String);
                cmd.Parameters.Add("@ViewClientTunnel", DbType.String);
                cmd.Parameters.Add("@UserLogenServer", DbType.String);
                cmd.Parameters.Add("@GroupPolicyLoadTime", DbType.String);
                cmd.Parameters.Add("@ProfileLoadTime", DbType.Double);
                cmd.Parameters.Add("@logonDurationOther", DbType.Double);
                cmd.Parameters.Add("@DesktopLoadTime", DbType.Double);
                cmd.Parameters.Add("@LogonDuration", DbType.Double);
                cmd.Parameters.Add("@SessionCreateTime", DbType.DateTime);
                cmd.Parameters.Add("@UserADDN", DbType.String);
                cmd.Parameters.Add("@UserADOU", DbType.String);
                cmd.Parameters.Add("@UserFullName", DbType.String);
                cmd.Parameters.Add("@AvgAppLoadTime", DbType.Double);
                cmd.Parameters.Add("@GPUCPUUtilization", DbType.String);
                cmd.Parameters.Add("@GPUFrameBufferMemryUtilization", DbType.Double);
                cmd.Parameters.Add("@GPUencoderUtilization", DbType.Double);
                cmd.Parameters.Add("@GPUdecoderUtilization", DbType.Double);
                cmd.Parameters.Add("@XDSiteName", DbType.Double);
                cmd.Parameters.Add("@XDSessionCreateTime", DbType.Double);
                cmd.Parameters.Add("@XDLogonDuration", DbType.String);
                cmd.Parameters.Add("@XDPublishedResourceType", DbType.String);
                cmd.Parameters.Add("@XDAnonymous", DbType.String);
                cmd.Parameters.Add("@XDConnectedViaHostName", DbType.String);
                cmd.Parameters.Add("@XDConnectedViaIPAddress", DbType.String);
                cmd.Parameters.Add("@XDLaunchedViaHostName", DbType.String);
                cmd.Parameters.Add("@XDLaunchedViaIPAddress", DbType.String);
                cmd.Parameters.Add("@XDSessionReconnected", DbType.String);
                cmd.Parameters.Add("@XDSecureICASession", DbType.String);
                cmd.Parameters.Add("@Protocol", DbType.String);
                cmd.Parameters.Add("@XDBrokeringDuration", DbType.String);
                cmd.Parameters.Add("@XDBrokeringDate", DbType.String);
                cmd.Parameters.Add("@XDVMStartDuration", DbType.String);
                cmd.Parameters.Add("@XDClientSessionValidateDate", DbType.String);
                cmd.Parameters.Add("@XDServerSessionValidateDate", DbType.String);
                cmd.Parameters.Add("@XDEstablishmentDate", DbType.String);
                cmd.Parameters.Add("@XDHDXConnectionLoadTime", DbType.String);
                cmd.Parameters.Add("@XDAuthenticationDuration", DbType.String);
                cmd.Parameters.Add("@XDGroupPolicyLoadTime", DbType.String);
                cmd.Parameters.Add("@XDLogonScriptsLoadTime", DbType.String);
                cmd.Parameters.Add("@XDProfileLoadTime", DbType.String);
                cmd.Parameters.Add("@XDInteractiveSessionLoadTime", DbType.String);
                cmd.Parameters.Add("@XDUPN", DbType.String);
                cmd.Parameters.Add("@XDAppsInUse", DbType.String);
                cmd.Parameters.Add("@XDAppsInUseCount", DbType.String);
                cmd.Parameters.Add("@XDDisconnectReason", DbType.String);
                cmd.Parameters.Add("@XDDisconnectDate", DbType.String);
                cmd.Parameters.Add("@XDDeliveryGroup", DbType.String);








                foreach (var item in records)
                {
                   


                    cmd.Parameters[0].Value = item.StressLevel.HasValue ? item.StressLevel.Value : (object)DBNull.Value;
                    cmd.Parameters[1].Value = item.ID.HasValue ? item.ID.Value : (object)DBNull.Value;
                    cmd.Parameters[2].Value = item.SessionName;
                    cmd.Parameters[3].Value = item.User;
                    cmd.Parameters[4].Value = item.CitrixReceiverVersion;
                    cmd.Parameters[5].Value = item.State;
                    cmd.Parameters[6].Value = item.ConnectTime.HasValue ? item.ConnectTime.Value : (object)DBNull.Value;
                    cmd.Parameters[7].Value = item.DisconnectTime.HasValue ? item.DisconnectTime.Value : (object)DBNull.Value;
                    cmd.Parameters[8].Value = item.IdleTime.HasValue ? item.IdleTime.Value : (object)DBNull.Value;
                    cmd.Parameters[9].Value = item.IdleTimeMin.HasValue ? item.IdleTimeMin.Value : (object)DBNull.Value;
                    cmd.Parameters[10].Value = item.LogonTime.HasValue ? item.LogonTime.Value : (object)DBNull.Value;
                    cmd.Parameters[11].Value = item.Processes.HasValue ? item.Processes.Value : (object)DBNull.Value;
                    cmd.Parameters[12].Value = item.LatencyLast.HasValue ? item.LatencyLast.Value : (object)DBNull.Value;
                    cmd.Parameters[13].Value = item.BandwidthLast.HasValue ? item.BandwidthLast.Value : (object)DBNull.Value;
                    cmd.Parameters[14].Value = item.RTT.HasValue ? item.RTT.Value : (object)DBNull.Value;
                    cmd.Parameters[15].Value = item.BandwidthAvg.HasValue ? item.BandwidthAvg.Value : (object)DBNull.Value;
                    cmd.Parameters[16].Value = item.BandwidthLimit.HasValue ? item.BandwidthLimit.Value : (object)DBNull.Value;
                    cmd.Parameters[17].Value = item.LatencyAvg.HasValue ? item.LatencyAvg.Value : (object)DBNull.Value;
                    cmd.Parameters[18].Value = item.ClientIP.HasValue ? item.ClientIP.Value : (object)DBNull.Value;
                    cmd.Parameters[19].Value = item.BranchName;
                    cmd.Parameters[20].Value = item.ClientName;
                    cmd.Parameters[21].Value = item.Computer;
                    cmd.Parameters[22].Value = item.DomainDNS;
                    cmd.Parameters[23].Value = item.InitialProgram;
                    cmd.Parameters[24].Value = item.CPU;
                    cmd.Parameters[25].Value = item.PageFaultsSec.HasValue ? item.PageFaultsSec.Value : (object)DBNull.Value;
                    cmd.Parameters[26].Value = item.IOReadOperationsSec.HasValue ? item.IOReadOperationsSec.Value : (object)DBNull.Value;
                    cmd.Parameters[27].Value = item.IOWriteOperationSec.HasValue ? item.IOWriteOperationSec.Value : (object)DBNull.Value;
                    cmd.Parameters[28].Value = item.MemoryPrivateBytes.HasValue ? item.MemoryPrivateBytes.Value : (object)DBNull.Value;
                    cmd.Parameters[29].Value = item.MemoryWorkingSet;
                    cmd.Parameters[30].Value = item.ViewClientConnectionServerURL;
                    cmd.Parameters[31].Value = item.ViewClientDomain;
                    cmd.Parameters[32].Value = item.ViewClientProtocol;
                    cmd.Parameters[33].Value = item.ViewClientType;
                    cmd.Parameters[34].Value = item.ViewClientTunnel;
                    cmd.Parameters[35].Value = item.UserLogenServer;
                    cmd.Parameters[36].Value = item.GroupPolicyLoadTime;
                    cmd.Parameters[37].Value = item.ProfileLoadTime.HasValue ? item.ProfileLoadTime.Value : (object)DBNull.Value;
                    cmd.Parameters[38].Value = item.logonDurationOther.HasValue ? item.logonDurationOther.Value : (object)DBNull.Value;
                    cmd.Parameters[39].Value = item.DesktopLoadTime.HasValue ? item.DesktopLoadTime.Value : (object)DBNull.Value;
                    cmd.Parameters[40].Value = item.XDLogonDuration;
                    cmd.Parameters[41].Value = item.SessionCreateTime.HasValue ? item.SessionCreateTime.Value : (object)DBNull.Value;
                    cmd.Parameters[42].Value = item.UserADDN;
                    cmd.Parameters[43].Value = item.UserADOU;
                    cmd.Parameters[44].Value = item.UserFullName;
                    cmd.Parameters[45].Value = item.AvgAppLoadTime.HasValue ? item.AvgAppLoadTime.Value : (object)DBNull.Value;
                    cmd.Parameters[46].Value = item.GPUCPUUtilization;
                    cmd.Parameters[47].Value = item.GPUFrameBufferMemryUtilization.HasValue ? item.GPUFrameBufferMemryUtilization.Value : (object)DBNull.Value;
                    cmd.Parameters[48].Value = item.GPUencoderUtilization.HasValue ? item.GPUencoderUtilization.Value : (object)DBNull.Value;
                    cmd.Parameters[49].Value = item.GPUdecoderUtilization.HasValue ? item.GPUdecoderUtilization.Value : (object)DBNull.Value;
                    cmd.Parameters[50].Value = item.XDSiteName.HasValue ? item.XDSiteName.Value : (object)DBNull.Value;
                    cmd.Parameters[51].Value = item.XDSessionCreateTime.HasValue ? item.XDSessionCreateTime.Value : (object)DBNull.Value;
                    cmd.Parameters[52].Value = item.XDLogonDuration;
                    cmd.Parameters[53].Value = item.XDPublishedResourceType;
                    cmd.Parameters[54].Value = item.XDAnonymous;
                    cmd.Parameters[55].Value = item.XDConnectedViaHostName;
                    cmd.Parameters[56].Value = item.XDConnectedViaIPAddress;
                    cmd.Parameters[57].Value = item.XDLaunchedViaHostName;
                    cmd.Parameters[58].Value = item.XDLaunchedViaIPAddress;
                    cmd.Parameters[59].Value = item.XDSessionReconnected;
                    cmd.Parameters[60].Value = item.XDSecureICASession;
                    cmd.Parameters[61].Value = item.Protocol;
                    cmd.Parameters[62].Value = item.XDBrokeringDuration;
                    cmd.Parameters[63].Value = item.XDBrokeringDate;
                    cmd.Parameters[64].Value = item.XDVMStartDuration;
                    cmd.Parameters[65].Value = item.XDClientSessionValidateDate;
                    cmd.Parameters[66].Value = item.XDServerSessionValidateDate;
                    cmd.Parameters[67].Value = item.XDEstablishmentDate;
                    cmd.Parameters[68].Value = item.XDHDXConnectionLoadTime;
                    cmd.Parameters[69].Value = item.XDAuthenticationDuration;
                    cmd.Parameters[70].Value = item.XDGroupPolicyLoadTime;
                    cmd.Parameters[71].Value = item.XDLogonScriptsLoadTime;
                    cmd.Parameters[72].Value = item.XDProfileLoadTime;
                    cmd.Parameters[73].Value = item.XDInteractiveSessionLoadTime;
                    cmd.Parameters[74].Value = item.XDUPN;
                    cmd.Parameters[75].Value = item.XDAppsInUse;
                    cmd.Parameters[76].Value = item.XDAppsInUseCount;
                    cmd.Parameters[77].Value = item.XDDisconnectReason;
                    cmd.Parameters[78].Value = item.XDDisconnectDate;
                    cmd.Parameters[79].Value = item.XDDeliveryGroup;






                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

    }


}

        

    



