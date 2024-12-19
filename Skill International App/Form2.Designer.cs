using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Skill_International_App
{
    partial class Form2
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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            groupBox4 = new GroupBox();
            textBox10 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox3 = new GroupBox();
            textBox6 = new TextBox();
            label11 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            linkLabel2 = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 32);
            label1.Name = "label1";
            label1.Size = new Size(228, 32);
            label1.TabIndex = 0;
            label1.Text = "Skills International";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(9, 10);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(45, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logout";
            linkLabel1.Click += BackTo_login;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(9, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 586);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(326, 557);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 15;
            button5.Text = "Delete";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += deleteButton_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(239, 557);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 14;
            button4.Text = "Clear";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += Clear_Button;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(91, 557);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Update";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += update_Registration;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(6, 557);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Register";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += submit_Registration;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox10);
            groupBox4.Controls.Add(textBox8);
            groupBox4.Controls.Add(textBox9);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label14);
            groupBox4.Location = new Point(7, 399);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(397, 153);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parent Details";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(105, 31);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(288, 23);
            textBox10.TabIndex = 10;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(107, 106);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(99, 23);
            textBox8.TabIndex = 7;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(105, 64);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(175, 23);
            textBox9.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 112);
            label12.Name = "label12";
            label12.Size = new Size(96, 15);
            label12.TabIndex = 3;
            label12.Text = "Contact Number";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(30, 67);
            label13.Name = "label13";
            label13.Size = new Size(27, 15);
            label13.TabIndex = 1;
            label13.Text = "NIC";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(26, 31);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 0;
            label14.Text = "Parent Name";
            label14.Click += label14_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(6, 232);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(397, 153);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact Details";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(291, 116);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(99, 23);
            textBox6.TabIndex = 9;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(211, 120);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 8;
            label11.Text = "Home Phone";
            label11.Click += label11_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(106, 113);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(99, 23);
            textBox5.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 83);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(288, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(103, 33);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(288, 44);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 117);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 3;
            label7.Text = "Mobile Phone";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 86);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 1;
            label9.Text = "Email";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 31);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 0;
            label10.Text = "Address";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(6, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 155);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(177, 126);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(107, 127);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(103, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(288, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(288, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 129);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 3;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 95);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 2;
            label5.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 64);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 1;
            label4.Text = "Last Name";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 30);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 0;
            label3.Text = "First Name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 32);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Reg No";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(100, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += Selected_RegNo;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(391, 656);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(26, 15);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Exit";
            linkLabel2.Click += exitButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 676);
            Controls.Add(linkLabel2);
            Controls.Add(groupBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Student Registration - Skills International";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            Load += Register_Form_Load;
        }

        private string connectionString = "Data Source=DESKTOP-IM43SM1;Initial Catalog=Student;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        private void BackTo_login(object sender, EventArgs e)
        {

            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide(); 
        }

        private void Register_Form_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            FetchREgNoToComboBox();

        }

        private void FetchREgNoToComboBox()
        {
            try
            {
               
                comboBox1.Items.Clear();
                

                string query = "SELECT regNo FROM Registration";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr["regNo"]);
                    }

                    dr.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Selected_RegNo(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null && int.TryParse(comboBox1.SelectedItem.ToString(), out int selectedRegNo))
            {
                
                FetchStudentDetails(selectedRegNo);
            }
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


        private void FetchStudentDetails(int regNo)
        {
            try
            {
                string query = "SELECT * FROM Registration WHERE regNo = @regNo";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                   
                    cmd.Parameters.AddWithValue("@regNo", regNo);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                       
                        textBox1.Text = dr["firstName"].ToString();
                        textBox2.Text = dr["lastName"].ToString();
                        dateTimePicker1.Value = (DateTime)dr["dateOfBirth"];
                        string gender = dr["gender"].ToString();
                        radioButton1.Checked = gender == "Male";
                        radioButton2.Checked = gender == "Female";
                        textBox4.Text = dr["address"].ToString();
                        textBox3.Text = dr["email"].ToString();
                        textBox5.Text = dr["mobilePhone"].ToString();
                        textBox6.Text = dr["homePhone"].ToString();
                        textBox10.Text = dr["parentName"].ToString();
                        textBox9.Text = dr["nic"].ToString();
                        textBox8.Text = dr["contactNo"].ToString();
                    }

                    dr.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_Button(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            FetchREgNoToComboBox();
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "";

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

            dateTimePicker1.Value = DateTime.Now;

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            comboBox1.Focus();
        }

        private void ClearFormFields()
        {
            comboBox1.SelectedIndex = -1; 
            comboBox1.Text = "";      
           
            textBox1.Clear();
            textBox2.Clear(); 
            textBox3.Clear(); 
            textBox4.Clear(); 
            textBox5.Clear(); 
            textBox6.Clear(); 
            textBox8.Clear(); 
            textBox9.Clear();
            textBox10.Clear(); 

            dateTimePicker1.Value = DateTime.Now; 

            radioButton1.Checked = false; 
            radioButton2.Checked = false; 

            comboBox1.Focus();
        }

        private bool IsValidEmail(string email)
        {
           
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
           
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }


        private bool ValidateFormData(int reg, 
            string firstName, 
            string lastName,
            DateTime dob, 
            string gender, 
            string address, 
            string email,
            string mobile,
            string home, 
            string parent, 
            string nic, 
            string parentCont)
        {

           

            if (reg <= 0)
            {
                MessageBox.Show("Please enter a valid Registration Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dob == null)
            {
                MessageBox.Show("Date of Birth is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Gender is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Mobile Phone is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(home))
            {
                MessageBox.Show("Home Phone is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(parent))
            {
                MessageBox.Show("Parent Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(nic))
            {
                MessageBox.Show("NIC is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(parentCont))
            {
                MessageBox.Show("Parent Contact Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           
            return true;
        }



        private void submit_Registration(object sender, EventArgs e)
        {
            
            int reg = int.Parse(comboBox1.Text.Trim());
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            DateTime dob = dateTimePicker1.Value;
            string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text; 
            string address = textBox4.Text.Trim();
            string email = textBox3.Text.Trim();
            string mobile = textBox5.Text.Trim();
            string home = textBox6.Text.Trim();
            string parent = textBox10.Text.Trim();
            string nic = textBox9.Text.Trim();
            string parentCont = textBox8.Text.Trim();

            
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mobile) ||
                string.IsNullOrEmpty(parentCont) || string.IsNullOrEmpty(nic))
            {
                ValidateFormData(
                  reg,
                  firstName,
                  lastName,
                  dob,
                  gender,
                  address,
                  email,
                  mobile,
                  home,
                  parent,
                  nic,
                  parentCont
                  );
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                bool validate = ValidateFormData(
                  reg,
                  firstName,
                  lastName,
                  dob,
                  gender,
                  address,
                  email,
                  mobile,
                  home,
                  parent,
                  nic,
                  parentCont
                  );

                if (validate == true)
                {
                    string query = "INSERT INTO Registration (regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                               "VALUES (@reg, @firstName, @lastName, @dob, @gender, @address, @email, @mobile, @home, @parent, @nic, @parentCont)";


                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {

                        cmd.Parameters.AddWithValue("@reg", reg);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@mobile", mobile);
                        cmd.Parameters.AddWithValue("@home", home);
                        cmd.Parameters.AddWithValue("@parent", parent);
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@parentCont", parentCont);


                        int rowsAffected = cmd.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields();
                            FetchREgNoToComboBox();

                        }
                        else
                        {
                            MessageBox.Show("Failed to register student. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                   
                
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStudentDetails(int regNo, string firstName, string lastName, DateTime dob, string gender, string address, string email, string mobile, string home, string parent, string nic, string parentCont)
        {
            try
            {
                
                string query = "UPDATE Registration SET firstName = @firstName, lastName = @lastName, dateOfBirth = @dob, gender = @gender, " +
                               "address = @address, email = @email, mobilePhone = @mobile, homePhone = @home, parentName = @parent, " +
                               "nic = @nic, contactNo = @parentCont WHERE regNo = @regNo";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                   
                    cmd.Parameters.AddWithValue("@regNo", regNo);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@home", home);
                    cmd.Parameters.AddWithValue("@parent", parent);
                    cmd.Parameters.AddWithValue("@nic", nic);
                    cmd.Parameters.AddWithValue("@parentCont", parentCont);

                  
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormFields();
                      
                    }
                    else
                    {
                        MessageBox.Show("No changes made. Please check the data and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
        }

        private void update_Registration(object sender, EventArgs e)
        {
            int reg = int.Parse(comboBox1.Text.Trim());
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            DateTime dob = dateTimePicker1.Value;
            string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string address = textBox4.Text.Trim();
            string email = textBox3.Text.Trim();
            string mobile = textBox5.Text.Trim();
            string home = textBox6.Text.Trim();
            string parent = textBox10.Text.Trim();
            string nic = textBox9.Text.Trim();
            string parentCont = textBox8.Text.Trim();

            if (!ValidateFormData(reg, firstName, lastName, dob, gender, address, email, mobile, home, parent, nic, parentCont))
            {
                return; 
            }

            UpdateStudentDetails(reg, firstName, lastName, dob, gender, address, email, mobile, home, parent, nic, parentCont);
        }

        private void DeleteStudentByRegNo(int regNo)
        {
            try
            {

                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete the student with Registration No: {regNo}?",
                                                            "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                   
                    string query = "DELETE FROM Registration WHERE regNo = @regNo";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                       
                        cmd.Parameters.AddWithValue("@regNo", regNo);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FetchREgNoToComboBox(); 
                            ClearFormFields();       
                        }
                        else
                        {
                            MessageBox.Show("No record found with the selected Registration No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Registration Number to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            int selectedRegNo = int.Parse(comboBox1.SelectedItem.ToString());

            DeleteStudentByRegNo(selectedRegNo);
        }





        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private Label label7;
        private Label label9;
        private Label label10;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label11;
        private TextBox textBox4;
        private GroupBox groupBox4;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox10;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private LinkLabel linkLabel2;

      
    }
}