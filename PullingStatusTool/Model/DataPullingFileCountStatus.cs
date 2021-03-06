﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PullingStatusTool
{
    class DataPullingFileCountStatus
    {
        public DataPullingFileCountStatus()
        {
        
        }

        public DataPullingFileCountStatus(string Vendor,string Datatype,string Subgroup,string fileCount,string Status,string ServerIP,string PSW,string finishTime)
        {

            this.vendor = Vendor;
            this.dataType = Datatype;
            this.subgroup = Subgroup;
            this.status = Status;
            this.filecount = fileCount;
            this.serverIP = ServerIP;
            this.passWord = PSW;
            this.finiTime = finishTime;
        }
        string finiTime;

        public string c_finishTime
        {
            get { return finiTime; }
            set { finiTime = value; }
        }
        string vendor;

        public string c_vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }
        string dataType;

        public string c_dataType
        {
            get { return dataType; }
            set { dataType = value; }
        }
        string subgroup;

        public string c_subgroup
        {
            get { return subgroup; }
            set { subgroup = value; }
        }
        string filecount;

        public string c_filecount
        {
            get { return filecount; }
            set { filecount = value; }
        }
        string status;

        public string c_status
        {
            get { return status; }
            set { status = value; }
        }
        string serverIP;

        public string c_serverIP
        {
            get { return serverIP; }
            set { serverIP = value; }
        }
        string fileCount;

        public string FileCount
        {
            get { return fileCount; }
            set { fileCount = value; }
        }
        string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

    }
}
