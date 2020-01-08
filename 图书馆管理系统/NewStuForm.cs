using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Web;
using System.IO;
using System.Threading.Tasks;


namespace 图书馆管理系统
{
    public partial class NewStuForm : Form
    {
        public NewStuForm()
        {
            InitializeComponent();
        }
        Camera camera;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("请您添写所有的必填项!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox2.Text != textBox3.Text)
                MessageBox.Show("密码前后输入不一致!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string selecString1 = "insert into 学生个人信息表() values('" + textBox1.Text + "','" +textBox8.Text+"','"+ textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "','" + textBox7.Text + "',0)";
                SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selecString1, conn);
                    int stu = cmd.ExecuteNonQuery();
                    if (stu > 0) MessageBox.Show("注册学生用户成功!","恭喜");
                }
                catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                finally { conn.Close(); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NewStuForm_Load(object sender, EventArgs e)
        {
            
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region 打开视频设备按钮的事件
        /// <summary>
        /// 打开视频设备按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Capture_Click(object sender, EventArgs e)
        {
            this.btn_Capture.Enabled = false;    //打开视频设备后，禁用“打开视频设备”按钮
            this.btn_close.Enabled = true;    //打开视频设备后，启用“关闭视频设备”按钮
            this.btn_cpt.Enabled = true;      //打开视频设备后，启用“拍照”按钮

            camera = new Camera(this.pic_camera.Handle, this.pic_camera.Width, this.pic_camera.Height); //实例化Camera对象，传入要显示区域(PictureBox)的句柄及宽高
            camera.StartWebCam();   //打开视频设备
        }
        #endregion

        #region 关闭视频设备的事件
        /// <summary>
        /// 关闭视频设备的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            //videoSourcePlayer.SignalToStop();
            //videoSourcePlayer.WaitForStop();
            this.btn_Capture.Enabled = true; //点击关闭视频设备后，启用“打开视频设备”按钮
            this.btn_close.Enabled = false;   //点击关闭视频设备后，禁用“关闭视频设备”按钮
            this.btn_cpt.Enabled = false; //点击关闭视频设备后，禁用“拍照”按钮

            camera.CloseWebcam();   //关闭视频设备
        }
        #endregion

        #region 拍照按钮的事件
        /// <summary>
        /// 拍照按钮的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cpt_Click(object sender, EventArgs e)
        {
            string str = "E:\\Pro\\DB-C#\\图书馆管理系统\\图书馆管理系统\\bin\\PerosonImg\\"+textBox1.Text+".png";
            camera.GrabImage(this.pic_camera.Handle, str); //拍照功能、前一个参数是显示图像的PictureBox句柄，后一个参数是要保存图片的路径。
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
