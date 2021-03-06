﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using DevExpress.Utils;

namespace PullingStatusTool
{
    public partial class Frm_PullingStatusService : DevExpress.XtraEditors.XtraForm
    {
        public Frm_PullingStatusService()
        {
            InitializeComponent();
        }
     
        private void Frm_PullingStatusService_Load(object sender, EventArgs e)
        {
            DB_Helper db_helper = new DB_Helper();
            drp_DailyDate.Text = DateTime.Now.ToShortDateString();
            txt_year.Text = DateTime.Now.Year.ToString();
            string weekly = ExcelApplication.getIRCalendarWeek(DateTime.Now);//根据当前日期查询Target IR Calendar 出来的mohth_weekofmonth
            txt_month.Text = weekly.Split('_')[0];
            txt_Week.Text = weekly.Split('_')[1];

       

        }
        List<ReportExpect> ListReportExpect = new List<ReportExpect>();
        private List<ReportExpect> getReportExpect(bool isMonday)
        {
            string dayofweek = Convert.ToDateTime(drp_DailyDate.Text).DayOfWeek.ToString();
            DB_Helper db_helper = new DB_Helper();
            string dayOfweek = Convert.ToDateTime(drp_DailyDate.Text).DayOfWeek.ToString();
          
            DataPullingFileCountStatus fileStatus = new DataPullingFileCountStatus();

            db_helper.getReportExpectData("192.168.10.68", "T3ci94043");
            ListReportExpect = isMonday ? db_helper.getReportExpect().Where(t => t.c_dayofweek.Contains("VIP")).ToList() : db_helper.getReportExpect().Where(t => t.c_dayofweek.Contains(dayofweek)).ToList();
            
            string vendor = "";
            string subgroup = "";
            string fileCountsUpload = "";
            string datatype="";
            string fileCountsFormatted="";
            string fileExceot = "";
            foreach (ReportExpect file in ListReportExpect)
            {
                vendor = file.c_vendor.Trim().ToLower();
                subgroup = file.c_subgroup.ToLower().Trim();
                datatype = file.c_datatype.ToLower().Trim();
                var temp = ListFileStatus.Where(
                                                t => t.c_vendor.Trim().ToLower() == vendor &&
                                                t.c_dataType.ToLower().Trim() == datatype && 
                                                t.c_subgroup.Trim().ToLower() == subgroup 
                                                
                                                );


                fileCountsUpload = temp.Where(t=>t.c_status.Trim()=="Uploaded").ToList().Count > 0 ?  temp.Where(t=>t.c_status.Trim()=="Uploaded").ToList()[0].c_filecount : "0";
                fileCountsFormatted=temp.Where(t=>t.c_status.Trim()=="Formatted").ToList().Count > 0 ?  temp.Where(t=>t.c_status.Trim()=="Formatted").ToList()[0].c_filecount : "0";
                file.c_serverIP= temp.Count() > 0 ?temp.ToList()[0].c_serverIP:"";
                file.c_status = temp.Count() > 0 ? temp.ToList()[0].c_status : "";
                fileExceot = file.c_filexpectuploaded.Split('/')[file.c_filexpectuploaded.Split('/').Count()-1];
                file.c_filexpectuploaded = fileCountsUpload + "/" + fileExceot;
                file.c_filexpectformatted = fileCountsFormatted == "0" ? fileCountsUpload:fileCountsFormatted  ;
                //file.c_filexpectformatted = fileCountsFormatted;
                file.c_filexpectformatted += "/" + fileExceot;
                file.c_finishuploaded = file.c_filexpectuploaded.Split('/')[0] == file.c_filexpectuploaded.Split('/')[1] ? "Y" : "N";
                file.c_finishformatted = file.c_filexpectformatted.Split('/')[0] == file.c_filexpectformatted.Split('/')[1] ? "Y" : "N";
                file.c_finishtime = file.c_finishformatted == "Y" ? temp.ToList()[0].c_finishTime : "";
                
            }

            return ListReportExpect.OrderBy(t => t.c_vendor).ThenBy(t => t.c_datatype).ThenBy(t => t.c_subgroup).ToList();
        
        }
        List<DataPullingFileCountStatus> ListFileStatus = new List<DataPullingFileCountStatus>();
        private void getDS(bool isMonday)

        {

            DB_Helper db_helper = new DB_Helper();
            string dailydate = "";
            string resdate = "";//R7文件的日期
            dailydate = cbx_daily.Checked ? String.Format("%{0:yyyy-MM-dd}%", Convert.ToDateTime(drp_DailyDate.Text).AddDays(-1)) : "";//在daily上不打钩就传""去查询
            string weeklyPeriod = String.Format("%{0}-{1} WK {2}%", txt_year.Text.Trim(), txt_month.Text.Trim(),txt_Week.Text.Trim());
            resdate = dailydate == "" ? "" : String.Format("%{0:yyyy-MM-dd}-%", Convert.ToDateTime(dailydate.Replace("%", "")).AddDays(-7).ToString("yyyy-MM-dd"));//如果查daily的，也要讲7天前的日期传过去作为查询R7文件的条件
            weeklyPeriod = cbx_weekly.Checked ? weeklyPeriod : "";
            if (ckbx_68.Checked)
            {
                db_helper.getPullingFileCountStatus("192.168.10.68", "T3ci94043", dailydate, weeklyPeriod, resdate, cbx_Attrib.Checked, isMonday);
            }
            if (ckbx_70.Checked)
            {
                db_helper.getPullingFileCountStatus("192.168.28.70", "T3ci94043", dailydate, weeklyPeriod, resdate, cbx_Attrib.Checked, isMonday);
            }
            if (ckbx_71.Checked)
            {
                db_helper.getPullingFileCountStatus("192.168.10.71", "t3ci94043", dailydate, weeklyPeriod, resdate, cbx_Attrib.Checked, isMonday);
            }
            if (ckbx_72.Checked)
            {
                db_helper.getPullingFileCountStatus("192.168.10.72", "T3ci94043", dailydate, weeklyPeriod, resdate, cbx_Attrib.Checked, isMonday);
            }
            if (ckbx_77.Checked)
            {
                db_helper.getPullingFileCountStatus("192.168.10.77", "T3ci94043", dailydate, weeklyPeriod, resdate, cbx_Attrib.Checked, isMonday);
            }
            if (ckbx_78.Checked)
            {
                db_helper.getPullingFileCountStatus("192.168.10.78", "T3ci94043", dailydate, weeklyPeriod, resdate, cbx_Attrib.Checked, isMonday);
            }



            ListFileStatus = db_helper.getPullingFileCount();
            GC_PullingFileStatus.DataSource = getReportExpect(isMonday);
         
        }




        private void btn_refresh_Click(object sender, EventArgs e)
        {
  
            if (txt_month.Text != "" && txt_year.Text != "" && txt_Week.Text != "")
            {
                if (cbx_daily.Checked || cbx_weekly.Checked)
                {
                    getDS(false);//获得所有的vendor的status，不仅仅是礼拜一的VIP
                }
                else
                {

                    MessageBox.Show("At least serch for daily or weekly!");
                }
            }
            else
            {
                MessageBox.Show("Fill the period!");
            }

   
        }

        private void cbx_weekly_CheckedChanged(object sender, EventArgs e)
        {
       
                txt_Week.Enabled = cbx_weekly.Checked;
                txt_month.Enabled = cbx_weekly.Checked;
                txt_year.Enabled = cbx_weekly.Checked;
            
      
        }

        private void cbx_daily_CheckedChanged(object sender, EventArgs e)
        {
            drp_DailyDate.Enabled = cbx_daily.Checked;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ExcelApplication excelApp = new ExcelApplication(ListFileStatus);
            excelApp.fillFileCountStatus();
           // MessageBox.Show(gridView1.RowCount.ToString());
        }

        private void rToolStripMenuItem_TCGUI_Click(object sender, EventArgs e)
        {
            Frm_DataPullingStatus frm_TCGUI = new Frm_DataPullingStatus();
            frm_TCGUI.Show();

        }

        private void cbx_Attrib_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Attrib.Checked)
            {
                cbx_daily.Checked=true;
                cbx_weekly.Checked=true;
            }
        }

        private void fileCoutExpectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_FileCountExpect frm = new Frm_FileCountExpect();
            frm.Show();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //   DevExpress.Utils.AppearanceDefault appYellow = new DevExpress.Utils.AppearanceDefault
            //    (Color.Black, Color.Yellow, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            //if (e.Column.FieldName == "c_filexpectuploaded")
            //{
            //    string strTemp = gridView1.GetRowCellValue(e.RowHandle, "c_filexpectuploaded").ToString().Trim();
            //    if (strTemp.Split('/')[0] != strTemp.Split('/')[1])
            //    {
            //        DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appYellow);
                
            //    }
 
            //}

            //if (e.Column.FieldName == "c_filexpectformatted")
            //{
            //    string strTemp = gridView1.GetRowCellValue(e.RowHandle, "c_filexpectformatted").ToString().Trim();
            //    if (strTemp.Split('/')[0] != strTemp.Split('/')[1])
            //    {
            //        DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appYellow);

            //    }

            //}
        }

        private void rePullToolStripMenuItem1_Click(object sender, EventArgs e)//Repull monitor 
        {
            Frm_RepullMonitor Fr_Repull = new Frm_RepullMonitor();
            Fr_Repull.Show();
        }

        private void sLAMonitorToolStripMenuItem_Click(object sender, EventArgs e)//SLA monitor
        {

            Frm_PullingPerformance Fr_Performance = new Frm_PullingPerformance();
            Fr_Performance.Show();
        }

        private void Btn_MondayStatus_Click(object sender, EventArgs e)
        {

            if (txt_month.Text != "" && txt_year.Text != "" && txt_Week.Text != "")
            {
                if (cbx_daily.Checked || cbx_weekly.Checked)
                {
                    getDS(true);//获得礼拜一的VIP vendor的Status
                }
                else
                {

                    MessageBox.Show("At least serch for a weekly!");
                }
            }
            else
            {
                MessageBox.Show("Fill the period!");
            }
        }

        private void repullSLAChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SLAChart frm_Chart = new Frm_SLAChart();
            frm_Chart.Show();
        }



    }
}