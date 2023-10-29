using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLL;


namespace CNPM_ver3.Timeline
{
    public partial class Timeline : Form
    {
        DayOfWeek firstDayOfWeek = DayOfWeek.Monday;

        ProjectBLL pb = new ProjectBLL();


        DateTime startDate;


        List<MyItemsTask> tasks = new List<MyItemsTask>();



        public Timeline(String PJ_ID)
        {
            InitializeComponent();

            //MyItemsTask myItemsTask = new MyItemsTask("Code layout", string2Date("10/23/2023"), string2Date("10/29/2023"), 0);
            //MyItemsTask myItemsTask1 = new MyItemsTask("Code layout 1", string2Date("10/27/2023"), string2Date("10/31/2023"), 2);
            //MyItemsTask myItemsTask2 = new MyItemsTask("Check task valid", string2Date("10/17/2023"), string2Date("10/21/2023"), 1);
            //MyItemsTask myItemsTask3 = new MyItemsTask("Code layout 3", string2Date("10/20/2023"), string2Date("10/25/2023"), 0);
            //MyItemsTask myItemsTask4 = new MyItemsTask("Code layout 4", string2Date("10/20/2023"), string2Date("11/3/2023"), 0);
            //MyItemsTask myItemsTask5 = new MyItemsTask("Code layout 5", string2Date("11/3/2023"), string2Date("11/7/2023"), 0);
            //tasks.Add(myItemsTask);
            //tasks.Add(myItemsTask1);
            //tasks.Add(myItemsTask2);
            //tasks.Add(myItemsTask3);
            //tasks.Add(myItemsTask4);
            //tasks.Add(myItemsTask5);
            getJobOfProject(PJ_ID);

            
        }

        private void Timeline_Load(object sender, EventArgs e)
        {
            dgv_timeline.EnableHeadersVisualStyles = false;

            weekStartDatePicker.Value = DateTime.Today;
            SetupWeekView();
        }


        private void getStartDate(DateTime currDate)
        {
            startDate = currDate;

            while (startDate.DayOfWeek != firstDayOfWeek)
            {
                startDate = startDate.AddDays(-1);
            }
        }


        private void getJobOfProject(string PJ_ID)
        {
            DataTable data =  pb.getJobOfProject(PJ_ID);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];

                String taskName = row["J_NAME"].ToString();
                DateTime startTime = DateTime.Parse(row["J_START"].ToString());
                DateTime endTime = DateTime.Parse(row["J_DEADLINE"].ToString());
                int hl = Int32.Parse(row["J_HL"].ToString());

                MyItemsTask myItemsTask = new MyItemsTask(taskName, startTime, endTime, hl);
                tasks.Add(myItemsTask);

            }
        }


        // no use now
        private DateTime string2Date(string value)
        {
            try
            {
                return DateTime.ParseExact(value, "MM/d/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception) { }
            return DateTime.Today;
        }



        private void SetupWeekView()
        {
            dgv_timeline.Columns.Clear();
            dgv_timeline.Rows.Clear();

            // Task column
            dgv_timeline.Columns.Add("Task", "Task");


            getStartDate(weekStartDatePicker.Value);


            for (int i = 0; i < 7; i++)
            {
                dgv_timeline.Columns.Add(startDate.AddDays(i).ToShortDateString(), startDate.AddDays(i).ToString("ddd") + startDate.AddDays(i).ToShortDateString());
            }

            if (dgv_timeline.Columns.Contains(weekStartDatePicker.Value.ToShortDateString()))
            {
                dgv_timeline.Columns[weekStartDatePicker.Value.ToShortDateString()].HeaderCell.Style.BackColor = Color.BlueViolet;
            }

            if (dgv_timeline.Columns.Contains(DateTime.Now.ToShortDateString()))
            {
                dgv_timeline.Columns[DateTime.Now.ToShortDateString()].HeaderCell.Style.BackColor = Color.Yellow;
            }


            highLight(startDate);
        }

        public int GetIntervalDay(DateTime start, DateTime end)
        {
            TimeSpan span = end.Subtract(start);
            return span.Days;
        }


        public int CheckInCurrentWeek(DateTime ddd)
        {


            if (GetIntervalDay(ddd, startDate) <= 0 && GetIntervalDay(ddd, startDate.AddDays(6)) >= 0)
                // ddd in current week
                return 0;

            if (GetIntervalDay(ddd, startDate) >= 0)
                // ddd in previous week
                return -1;

            // ddd in next week
            return 1;

        }


        private void highLight(DateTime startWeekTime)
        {

            DateTime endWeekTime = startWeekTime.AddDays(6);
            int i = 0;


            // Add task for illusrtation
            for (int j = 0; j < tasks.Count; j++)
            {

                DateTime start = tasks[j].beginTime;
                DateTime end = tasks[j].endTime;

                // begin after current week
                if (CheckInCurrentWeek(start) == 1) continue;
                // end before current week
                if (CheckInCurrentWeek(end) == -1) continue;



                dgv_timeline.Rows.Add();
                dgv_timeline.Rows[i].Cells["Task"].Value = tasks[j].taskName;



                if (CheckInCurrentWeek(start) == 0)
                {

                    for (int k = 0; k < tasks[j].GetDayInterval(); k++)
                    {

                        string sd = start.ToShortDateString();

                        if (dgv_timeline.Columns.Contains(sd))
                        {
                            switch (tasks[j].higlight)
                            {
                                case 0:
                                    dgv_timeline.Rows[i].Cells[sd].Style.BackColor = Color.Green;
                                    break;
                                case 1:
                                    dgv_timeline.Rows[i].Cells[sd].Style.BackColor = Color.DarkOrange;
                                    break;
                                case 2:
                                    dgv_timeline.Rows[i].Cells[sd].Style.BackColor = Color.Red;
                                    break;
                                case 3:
                                    dgv_timeline.Rows[i].Cells[sd].Style.BackColor = Color.Gray;
                                    break;
                            }
                        }
                        start = start.AddDays(1);
                    }
                }



                if (CheckInCurrentWeek(start) == -1 && CheckInCurrentWeek(end) == 0)
                {
                    DateTime startPoint = startWeekTime;

                    for (int k = 0; k < tasks[j].GetLaterTimeInterval(startWeekTime); k++)
                    {
                        string sd = startPoint.ToShortDateString();
                        if (dgv_timeline.Columns.Contains(sd))
                        {
                            switch (tasks[j].higlight)
                            {
                                case 0:
                                    dgv_timeline.Rows[i].Cells[sd].Style.BackColor = Color.Green;
                                    break;
                                case 1:
                                    dgv_timeline.Rows[i].Cells[sd].Style.BackColor = Color.DarkOrange;
                                    break;
                                case 2:
                                    dgv_timeline.Rows[i].Cells[sd].Style.BackColor = Color.Red;
                                    break;
                                case 3:
                                    dgv_timeline.Rows[i].Cells[sd].Style.BackColor = Color.Gray;
                                    break;
                            }
                        }
                        startPoint = startPoint.AddDays(1);
                    }
                }


                if (CheckInCurrentWeek(start) == -1 && CheckInCurrentWeek(end) == 1)
                {
                    DateTime startPoint = startWeekTime;
                    for (int k = 0; k < 7; k++)
                    {
                        string sd = startPoint.ToShortDateString();
                        if (dgv_timeline.Columns.Contains(sd))
                        {
                            switch (tasks[j].higlight)
                            {
                                case 0:
                                    dgv_timeline.Rows[i].Cells[sd].Style.BackColor = Color.Green;
                                    break;
                                case 1:
                                    dgv_timeline.Rows[i].Cells[sd].Style.BackColor = Color.DarkOrange;
                                    break;
                                case 2:
                                    dgv_timeline.Rows[i].Cells[sd].Style.BackColor = Color.Red;
                                    break;
                                case 3:
                                    dgv_timeline.Rows[i].Cells[sd].Style.BackColor = Color.Gray;
                                    break;
                            }
                        }
                        startPoint = startPoint.AddDays(1);
                    }
                }

                i = i + 1;

            }
        }


        // ValueChange

        private void dtpk_timeline_changed(object sender, EventArgs e)
        {
            SetupWeekView();
        }

        // Next week
        private void button_Click(object sender, EventArgs e)
        {
            weekStartDatePicker.Value = weekStartDatePicker.Value.AddDays(7);
        }

        // Previous week
        private void button_1_Click(object sender, EventArgs e)
        {
            weekStartDatePicker.Value = weekStartDatePicker.Value.AddDays(-7);
        }


        private void button_today_Click(object sender, EventArgs e)
        {
            weekStartDatePicker.Value = DateTime.Today;

        }

        
    }
}
