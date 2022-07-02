namespace WebscriptCCL

{
    public partial class Form1 : Form
    {
        bool bUname = false;
        bool bManName = false;
        bool bDept = false;
        bool bApps = false;
        bool bLocation = false;
        byte locationID = 0;
        byte deptID = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void txt_username_TextChanged_1(object sender, EventArgs e)
        {
            bUname = true;
        }
        private void txt_manager_TextChanged(object sender, EventArgs e)
        {
            bManName = true;
        }
        private void rad_COS_CheckedChanged(object sender, EventArgs e)
        {
            bLocation = true;
            locationID = 1;
        }

        private void rad_SAN_CheckedChanged(object sender, EventArgs e)
        {
            bLocation = true;
            locationID = 2;
        }

        private void rad_GNB_CheckedChanged(object sender, EventArgs e)
        {
            bLocation = true;
            locationID = 2;
        }

        private void dropDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDept = true;

            //Use index of drop down for integer ID of Department:
            //Debugging example: JanitorialIndex: 2
            deptID = (byte)dropDept.SelectedIndex;

        }

        private void chk_apps_SelectedIndexChanged(object sender, EventArgs e)
        {
            bApps = true;
            if(bUname && bManName && bLocation && bDept && bApps)
            {
                button1.BackColor = Color.Green;

            }
           // chk_apps.SelectedItems
           //or 
           // chk_apps.SelectedIndices
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uName = txt_username.Text;
            string mName = txt_manager.Text;

            //Write a function that passes in: uName, mName, locationID, deptID, apps

            //Use Selenium for C# or msHTML if you HAVE to

            //You need to be logged in and on a copy of the URL being opened for this to work.
            System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://portal.prod.cu.edu/psp/epprod/UCCS3/HRMS/c/SA_LEARNER_SERVICES.SSS_STUDENT_CENTER.GBL?pslnkid=SSS_STUDENT_CENTER1");
        }
    }
}