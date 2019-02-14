using CU_DB.DataTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_DB.DataManager
{
    public class FileManager
    {


        string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=CU;Integrated Security = true";

        public void InsertFromFolder(string directoryPath)

        {
            FileNameManager fileNameDataManager = new FileNameManager();
            foreach (string file in Directory.EnumerateFiles(directoryPath, "*.csv"))
            {
                var fileName = Path.GetFileName(file);
                //Überprüfen, ob die Datei bereits eingetragen ist 
                int countFile = fileNameDataManager.CheckFileName(fileName);
                //string contents = File.ReadAllText(file);
                if (countFile < 1)
                {
                    DiagnosseDataManager diagnossDataManager = new DiagnosseDataManager();
                    diagnossDataManager.InsertDataToDb(file);
                    //var dt = GetDataTableFromCsv(file);
                    //InsertDataIntoSql(dt);

                    fileNameDataManager.InsertFileName(fileName);
                    Console.WriteLine("the File" + fileName + "is imported in DB ");
                }
                else
                {
                    Console.WriteLine("the File" + fileName + "has already imported in DB ");
                }

            }
        }

        //lesen

        public List<Diagnosse> ReadLogFile(string filepath)
        {

            StreamReader sr = new StreamReader(filepath);



            string line = sr.ReadLine();
            line = sr.ReadLine();

            // string[] value = line.Split(',');


            List<Diagnosse> listDiagnoss = new List<Diagnosse>();

            while (!sr.EndOfStream)
            {
                //string delimiter = "][";
                //var columns = stringtosplit.split(new[] { delimiter }, stringsplitoptions.none);
                string[] seperator = { "\",\"" };
                var columns = sr.ReadLine().Split(seperator, StringSplitOptions.None);
                //object
                var diagnoss = new Diagnosse();


                var strfirst = columns[0].Replace("\"", string.Empty);
                diagnoss.StressLevel = String.IsNullOrEmpty(strfirst) ? (double?)null : double.Parse(strfirst);
                diagnoss.ID = String.IsNullOrEmpty(columns[1]) ? (double?)null : double.Parse(columns[1]);
                diagnoss.SessionName = columns[2];
                diagnoss.User = columns[3];
                diagnoss.CitrixReceiverVersion = columns[4];
                diagnoss.State = columns[5];
                diagnoss.ConnectTime = String.IsNullOrEmpty(columns[6]) ? (DateTime?)null : DateTime.Parse(columns[6]);
                diagnoss.DisconnectTime = String.IsNullOrEmpty(columns[7]) ? (DateTime?)null : DateTime.Parse(columns[7]);
                //if( String.IsNullOrEmpty(columns[7])== true)
                //{
                //    diagnoss.DisconnectTime = DateTime.Now;
                //}
                //else
                //{
                //    diagnoss.DisconnectTime = DateTime.Parse(columns[7]);
                //}
               

                if (String.IsNullOrEmpty(columns[8]) || columns[8] == "0,00")
                {
                   diagnoss.IdleTime = (long?)null;
                }
                else
                {
                    diagnoss.IdleTime = TimeSpan.Parse(columns[8]).Ticks;
                }


                diagnoss.IdleTimeMin = String.IsNullOrEmpty(columns[9]) ? (double?)null : double.Parse(columns[9]);
                diagnoss.LogonTime = String.IsNullOrEmpty(columns[10]) ? (DateTime?)null : DateTime.Parse(columns[10]);
                //if( String.IsNullOrEmpty(columns[10])== true)
                //{
                //    diagnoss.DisconnectTime = 0;
                //}
                //else
                //{
                //    diagnoss.DisconnectTime = double.Parse( columns[10]); 
                //}
                diagnoss.Processes = String.IsNullOrEmpty(columns[11]) ? (double?)null : float.Parse(columns[11]);
                diagnoss.LatencyLast = String.IsNullOrEmpty(columns[12]) ? (double?)null : float.Parse(columns[12]);
                diagnoss.BandwidthLast = String.IsNullOrEmpty(columns[13]) ? (double?)null : float.Parse(columns[13]);
                diagnoss.RTT = String.IsNullOrEmpty(columns[14]) ? (double?)null : float.Parse(columns[14]);
                diagnoss.BandwidthAvg = String.IsNullOrEmpty(columns[15]) ? (double?)null : float.Parse(columns[15]);
                diagnoss.BandwidthLimit = String.IsNullOrEmpty(columns[16]) ? (double?)null : float.Parse(columns[16]);
                diagnoss.LatencyAvg = String.IsNullOrEmpty(columns[17]) ? (double?)null : float.Parse(columns[17]);
                diagnoss.ClientIP = String.IsNullOrEmpty(columns[18]) ? (double?)null : float.Parse(columns[18]);
                diagnoss.BranchName = columns[19];
                diagnoss.ClientName = columns[20];
                diagnoss.Computer = columns[21];
                diagnoss.DomainDNS = columns[22];
                diagnoss.InitialProgram = columns[23];
                diagnoss.CPU = columns[24];
                diagnoss.PageFaultsSec = String.IsNullOrEmpty(columns[25]) ? (double?)null : float.Parse(columns[25]);
                diagnoss.IOReadOperationsSec = String.IsNullOrEmpty(columns[26]) ? (double?)null : float.Parse(columns[26]);
                diagnoss.IOWriteOperationSec = String.IsNullOrEmpty(columns[27]) ? (double?)null : float.Parse(columns[27]);
                diagnoss.MemoryPrivateBytes = String.IsNullOrEmpty(columns[28]) ? (double?)null : float.Parse(columns[28]);
                diagnoss.MemoryWorkingSet = columns[29];
                diagnoss.ViewClientConnectionServerURL = columns[30];
                diagnoss.ViewClientDomain = columns[31];
                diagnoss.ViewClientProtocol = columns[32];
                diagnoss.ViewClientType = columns[33];
                diagnoss.ViewClientTunnel = columns[34];
                diagnoss.UserLogenServer = columns[35];
                diagnoss.GroupPolicyLoadTime = columns[36];
                diagnoss.ProfileLoadTime = String.IsNullOrEmpty(columns[37]) ? (double?)null : float.Parse(columns[38]);
                diagnoss.logonDurationOther = String.IsNullOrEmpty(columns[39]) ? (double?)null : float.Parse(columns[38]);
                diagnoss.DesktopLoadTime = String.IsNullOrEmpty(columns[39]) ? (double?)null : float.Parse(columns[39]);
                diagnoss.LogonDuration = String.IsNullOrEmpty(columns[40]) ? (double?)null : float.Parse(columns[40]);
                diagnoss.SessionCreateTime = String.IsNullOrEmpty(columns[41]) ? (DateTime?)null : DateTime.Parse(columns[41]);
                diagnoss.UserADDN = columns[42];
                diagnoss.UserADOU = columns[43];
                diagnoss.UserFullName = columns[44];
                diagnoss.AvgAppLoadTime = String.IsNullOrEmpty(columns[45]) ? (double?)null : float.Parse(columns[45]);
                diagnoss.GPUCPUUtilization = columns[46];
                diagnoss.GPUFrameBufferMemryUtilization = String.IsNullOrEmpty(columns[47]) ? (double?)null : float.Parse(columns[47]);
                diagnoss.GPUencoderUtilization = String.IsNullOrEmpty(columns[48]) ? (double?)null : float.Parse(columns[48]);
                diagnoss.GPUdecoderUtilization = String.IsNullOrEmpty(columns[49]) ? (double?)null : float.Parse(columns[49]);
                diagnoss.XDSiteName = String.IsNullOrEmpty(columns[50]) ? (double?)null : float.Parse(columns[50]);
                diagnoss.XDSessionCreateTime = String.IsNullOrEmpty(columns[51]) ? (double?)null : float.Parse(columns[51]);
                diagnoss.XDLogonDuration = columns[52];
                diagnoss.XDPublishedResourceType = columns[53];
                diagnoss.XDAnonymous = columns[54];
                diagnoss.XDConnectedViaHostName = columns[55];
                diagnoss.XDConnectedViaIPAddress = columns[56];
                diagnoss.XDLaunchedViaHostName = columns[57];
                diagnoss.XDLaunchedViaIPAddress = columns[58];
                diagnoss.XDSessionReconnected = columns[59];
                diagnoss.XDSecureICASession = columns[60];
                diagnoss.Protocol = columns[61];
                diagnoss.XDBrokeringDuration = columns[62];
                diagnoss.XDBrokeringDate = columns[63];
                diagnoss.XDVMStartDuration = columns[64];
                diagnoss.XDClientSessionValidateDate = columns[65];
                diagnoss.XDServerSessionValidateDate = columns[66];
                diagnoss.XDEstablishmentDate = columns[67];
                diagnoss.XDHDXConnectionLoadTime = columns[68];
                diagnoss.XDAuthenticationDuration = columns[69];
                diagnoss.XDGroupPolicyLoadTime = columns[70];
                diagnoss.XDLogonScriptsLoadTime = columns[71];
                diagnoss.XDProfileLoadTime = columns[72];
                diagnoss.XDInteractiveSessionLoadTime = columns[73];
                diagnoss.XDUPN = columns[74];
                diagnoss.XDAppsInUse = columns[75];
                diagnoss.XDAppsInUseCount = columns[76];
                diagnoss.XDDisconnectReason = columns[77];
                diagnoss.XDDisconnectDate = columns[78];
                diagnoss.XDDeliveryGroup = columns[79].Replace("\"", string.Empty);
                //har zeil ro be onvane object negah midare


                listDiagnoss.Add(diagnoss);

            }
            return listDiagnoss;
        }


    }
}