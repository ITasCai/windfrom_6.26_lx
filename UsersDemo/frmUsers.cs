using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UsersDemo
{
    public partial class frmUsers : Form
    {

        //定义连接对象
        SqlConnection sqlcon = null;
        //定义连接字符串
        string strcon = "Data Source=HP201-1;Initial Catalog=users;Integrated Security=True";

        //定义一个数据集
        DataSet ds = null;
        //定义一个适配器
        SqlDataAdapter da = null;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            //调用用户类别绑定方法
            getDataSet();

            getDataSetAll();
        }

        //用户类别绑定
        private void getDataSet() {
            //创建一个数据集
            ds = new DataSet();
            //1.实例化连接对象
            sqlcon = new SqlConnection(strcon);
            //2.创建查询sql语句
            string sql = "select*from class";
            //3.创建适配器
            da = new SqlDataAdapter(sql, sqlcon);
            //4.填充数据集
            da.Fill(ds, "class");
            //向用户类别第一行添加数据 “全部”
            DataRow row = ds.Tables["class"].NewRow();
            row[0] = -1;
            row[1] = "全部";
            ds.Tables["class"].Rows.InsertAt(row,0);
            //绑定用户类别
            //指定数据源
            cmbusersclass.DataSource = ds.Tables["class"];
            //初始值
            cmbusersclass.ValueMember = "classno";
            //显示值
            cmbusersclass.DisplayMember = "classname";

        }

        private DataSet getDataSetAll() {
            //定义数据集
            ds = new DataSet();
            //实例化连接对象
            sqlcon = new SqlConnection(strcon);
            //连接字符串
            StringBuilder strsql = new StringBuilder("SELECT userid,username,usersex,userage,romark,classname FROM class,Users WHERE class.classno=Users.classno");
            if (Convert.ToInt32(cmbusersclass.SelectedValue)!=-1)
            {
                ////根据用户所选的用户类别的值查询用户信息表相关的内容
                //strsql.AppendFormat(" and Users.classno={0}",Convert.ToInt32(cmbusersclass.SelectedValue));

                //strsql.Append(" order by userid");
                try
                {
                    //打开连接
                    sqlcon.Open();
                    //定义适配器
                    da=new SqlDataAdapter(strsql.ToString(),sqlcon);
                    //填充表
                    da.Fill(ds,"users");

                    //绑定数据源
                    dgvuser.DataSource = ds.Tables["users"].DefaultView;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
            }
            return ds;
        }


        //绑定添加用户类别
        private void GetDataSetUserclass()
        {

            //创建一个数据集
            ds = new DataSet();
            //1.实例化连接对象
            sqlcon = new SqlConnection(strcon);
            //2.创建查询Sql语句
            string sql = "select*from class";
            //3.利用上面创建的数据库连接对象和sql语句创建DataAdapter对象
            da = new SqlDataAdapter(sql, sqlcon);
            //4.填充数据集
            da.Fill(ds, "class");
            //向用户类别第一行添加数据“全部”
            DataRow row = ds.Tables["class"].NewRow();
            row[0] = -1;
            row[1] = "全部";
            ds.Tables["class"].Rows.InsertAt(row, 0);

            //绑定用户类别
            //指定数据源
            this.cmblb.DataSource = ds.Tables["class"];
            //实际值
            this.cmblb.ValueMember = "classno";
            //显示值
            this.cmblb.DisplayMember = "classname";
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            string strsql = string.Format("INSERT INTO dbo.Users( username , usersex  , userage,  romark, classno )VALUES  ('{0}','{1}','{2}','{3}','{4}' )", txtname.Text.Trim(), cmbsex.Text, txtage.Text, txtbz, Convert.ToInt32(cmblb.SelectedValue));

            if (ExecuteSql(strsql))
            {
                MessageBox.Show("添加成功");
                getDataSetAll();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        //绑定添加用户类别
        private void btnusersclass_Click(object sender, EventArgs e)
        {
            getDataSetAll();
        }
        //增删改方法
        private bool ExecuteSql(string strsql) {
            //实例化
            sqlcon = new SqlConnection(strcon);
            //返回影响的行数
            int res = 0;
         
            try
            {
                //打开连接
                sqlcon.Open();
                //定义连接
                SqlCommand com = new SqlCommand(strsql, sqlcon);
                res = com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally {
                sqlcon.Close();
            }

            return res > 0 ? true : false;
        }
    }
}
