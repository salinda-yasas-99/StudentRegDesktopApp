using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Skill_International_App
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(125, 177);
            label1.Name = "label1";
            label1.Size = new Size(228, 32);
            label1.TabIndex = 3;
            label1.Text = "Skills International";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(125, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 142);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "LogIn";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 67);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.Click += label3_Click_2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(147, 99);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 5;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += logInBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(8, 104);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Clear";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Form_Clear;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 60);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Username";
            label2.Click += label2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(12, 415);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Exit";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Login - Skills International";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private string connectionString = "Data Source=DESKTOP-IM43SM1;Initial Catalog=Student;Integrated Security=True;Connect " +
            "Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        private void Login_Load(object sender, EventArgs e)
        {
            cn= new SqlConnection(connectionString);
            cn.Open();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            string username_Value = textBox1.Text;
            string password_Value = textBox2.Text;

            if (username_Value != string.Empty || password_Value != string.Empty)
            {

                cmd = new SqlCommand("select * from Logins where username=@username and password=@password", cn);
                cmd.Parameters.AddWithValue("@username", username_Value);
                cmd.Parameters.AddWithValue("@password", password_Value);
                
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Form2 register = new Form2();
                    register.Show();
                    

                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Invalid Login credentials, please check Username and\r\nPassword and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Form_Clear(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?",
                                                        "Exit Confirmation",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;



       
    }

    
}
