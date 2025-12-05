

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Hospital_management_system.Models;
using Hospital_management_system.Services;

namespace Hospital_management_system
{
    public partial class EmployeeForm : Form
    {
        private EmployeeManagement employeeService = new EmployeeManagement();
        private Employee selectedEmployee = null;
        private string currentSearchType = "ID";

        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Label lblSpecialization;


        public EmployeeForm()
        {



            InitializeComponent();
        
        }



        

    

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            try
            {
                // تحميل الأدوار
                cmRole.Items.Clear();
                cmRole.Items.AddRange(new string[] { "DOCTOR", "RECEPTIONIST" });
                cmRole.SelectedIndex = -1;
                // تحميل أنواع البحث
                cmbSearchTypEmp.Items.Clear();
                cmbSearchTypEmp.Items.AddRange(new string[] { "ID", "Name", "Phone", "Role" });
                cmbSearchTypEmp.SelectedIndex = 0;

                // تحميل قائمة الأدوار للبحث
                searchrole.Items.Clear();
                searchrole.Items.AddRange(new string[] { "ALL", "DOCTOR", "RECEPTIONIST" });
                searchrole.SelectedIndex = 0;

                // تحميل البيانات
                LoadAllEmployees();
                ClearFields();

                MessageBox.Show("شاشة إدارة الموظفين جاهزة", "مرحباً",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllEmployees()
        {
            try
            {
                // مسح الجدول
                dataGridView1.Rows.Clear();

                // جلب الأطباء
                var doctors = employeeService.getAllDoctor();
                foreach (var doctor in doctors)
                {
                    dataGridView1.Rows.Add(
                        doctor.DoctorId,
                        doctor.FullName,
                        doctor.Age,
                        doctor.Email,
                        doctor.Phone,
                        doctor.Salary.ToString("C2"),
                        "DOCTOR"
                    );
                }

                // جلب موظفي الاستقبال
                var receptionists = employeeService.getAllreseptionist();
                foreach (var receptionist in receptionists)
                {
                    dataGridView1.Rows.Add(
                        receptionist.ReseptionistId,
                        receptionist.FullName,
                        receptionist.Age,
                        receptionist.Email,
                        receptionist.Phone,
                        receptionist.Salary.ToString("C2"),
                        "RECEPTIONIST "
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل الموظفين: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
        private void ClearFields()
        {
            txtNameEmpl.Clear();
            numAgeEmpl.Value = 25;
            txtEmailEmpl.Clear();
            txtPhoneEmpl.Clear();
            txtSalaryEmpl.Clear();
            cmRole.SelectedIndex = -1;
            selectedEmployee = null;

            // تفريغ البحث
            txtsearchEmp.Clear();
            cmbSearchTypEmp.SelectedIndex = 0;
            searchrole.SelectedIndex = 0;
            searchrole.Visible = false;
            txtsearchEmp.Visible = true;
        }

        private bool ValidateEmployeeData()
        {
            if (string.IsNullOrWhiteSpace(txtNameEmpl.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم الموظف", "خطأ في التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameEmpl.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneEmpl.Text))
            {
                MessageBox.Show("الرجاء إدخال رقم الهاتف", "خطأ في التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneEmpl.Focus();
                return false;
            }

            if (txtPhoneEmpl.Text.Length != 10 || !txtPhoneEmpl.Text.All(char.IsDigit))
            {
                MessageBox.Show("الرجاء إدخال رقم هاتف صحيح (10 أرقام)", "خطأ في التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneEmpl.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmailEmpl.Text) || !txtEmailEmpl.Text.Contains("@"))
            {
                MessageBox.Show("الرجاء إدخال بريد إلكتروني صحيح", "خطأ في التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailEmpl.Focus();
                return false;
            }

            if (numAgeEmpl.Value < 22 || numAgeEmpl.Value > 65)
            {
                MessageBox.Show("الرجاء إدخال عمر صحيح (22-65)", "خطأ في التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numAgeEmpl.Focus();
                return false;
            }

            if (!decimal.TryParse(txtSalaryEmpl.Text, out decimal salary) || salary <= 0)
            {
                MessageBox.Show("الرجاء إدخال راتب صحيح (رقم موجب)", "خطأ في التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalaryEmpl.Focus();
                return false;
            }

            if (cmRole.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء اختيار الدور", "خطأ في التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmRole.Focus();
                return false;
            }

            return true;
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    txtNameEmpl.Text = row.Cells[1].Value?.ToString() ?? "";

                    if (row.Cells[2].Value != null && int.TryParse(row.Cells[2].Value.ToString(), out int age))
                        numAgeEmpl.Value = age;
                    else
                        numAgeEmpl.Value = 25;

                    txtEmailEmpl.Text = row.Cells[3].Value?.ToString() ?? "";
                    txtPhoneEmpl.Text = row.Cells[4].Value?.ToString() ?? "";
                    txtSalaryEmpl.Text = row.Cells[5].Value?.ToString() ?? "";

                    string role = row.Cells[6].Value?.ToString() ?? "";
                    if (role == "DOCTOR")
                        cmRole.SelectedItem = "DOCTOR";
                    else if (role == "RECEPTIONIST")
                        cmRole.SelectedItem = "RECEPTIONIST";

                    selectedEmployee = GetEmployeeFromRow(row);

                    dataGridView1.ClearSelection();
                    row.Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في اختيار الموظف: {ex.Message}");
            }
        }

        private Employee GetEmployeeFromRow(DataGridViewRow row)
        {
            try
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                string role = row.Cells[6].Value?.ToString() ?? "";

                if (role == "طبيب")
                {
                    var doctor = employeeService.GetdoctorById(id);
                    if (doctor != null)
                    {
                        doctor.Role = Role.DOCTOR;
                        return doctor;
                    }
                }
                else if (role == "موظف استقبال")
                {
                    var receptionist = employeeService.GetReceptionistById(id);
                    if (receptionist != null)
                    {
                        receptionist.Role = Role.RESEPTIONIST;
                        return receptionist;
                    }
                }
            }
            catch { }

            return null;
        }
       

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateEmployeeData())
                    return;

                Employee newEmployee;
                string role = cmRole.SelectedItem.ToString();

                if (role == "DOCTOR")
                {
                    newEmployee = new Doctor();
                    newEmployee.Role = Role.DOCTOR;


                }
                else
                {
                    newEmployee = new reseptionist();
                    newEmployee.Role = Role.RESEPTIONIST;
                }

                newEmployee.FullName = txtNameEmpl.Text.Trim();
                newEmployee.Age = (int)numAgeEmpl.Value;
                newEmployee.Phone = txtPhoneEmpl.Text.Trim();
                newEmployee.Email = txtEmailEmpl.Text.Trim();
                newEmployee.Salary = Convert.ToDecimal(txtSalaryEmpl.Text);

                bool success = employeeService.addemployee(newEmployee);

                if (success)
                {
                    string employeeType = (role == "DOCTOR") ? "طبيب" : "موظف استقبال";
                    MessageBox.Show($"تم إضافة {employeeType}: {newEmployee.FullName} بنجاح",
                        "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAllEmployees();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("فشل في إضافة الموظف. الرجاء المحاولة مرة أخرى",
                        "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في إضافة الموظف: {ex.Message}",
                    "خطأ في قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEmployee == null)
                {
                    MessageBox.Show("الرجاء اختيار موظف للتعديل",
                        "اختيار مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateEmployeeData())
                    return;

                selectedEmployee.FullName = txtNameEmpl.Text.Trim();
                selectedEmployee.Age = (int)numAgeEmpl.Value;
                selectedEmployee.Phone = txtPhoneEmpl.Text.Trim();
                selectedEmployee.Email = txtEmailEmpl.Text.Trim();
                selectedEmployee.Salary = Convert.ToDecimal(txtSalaryEmpl.Text);

                bool success = employeeService.updateEmployee(selectedEmployee);

                if (success)
                {
                    string employeeType = (selectedEmployee.Role == Role.DOCTOR) ? "طبيب" : "موظف استقبال";
                    MessageBox.Show($"تم تعديل بيانات {employeeType}: {selectedEmployee.FullName} بنجاح",
                        "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAllEmployees();
                    ClearFields();
                    selectedEmployee = null;
                }
                else
                {
                    MessageBox.Show("فشل في تعديل بيانات الموظف. الرجاء المحاولة مرة أخرى",
                        "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تعديل الموظف: {ex.Message}",
                    "خطأ في قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedEmployee == null)
                {
                    MessageBox.Show("الرجاء اختيار موظف للحذف",
                        "اختيار مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string employeeName = selectedEmployee.FullName;
                string employeeType = (selectedEmployee.Role == Role.DOCTOR) ? "طبيب" : "موظف استقبال";

                var result = MessageBox.Show(
                    $"هل أنت متأكد من حذف {employeeType}:\n{employeeName}؟",
                    "تأكيد الحذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = employeeService.deletemployee(
                        selectedEmployee.EmployeeId,
                        selectedEmployee.Role);

                    if (success)
                    {
                        MessageBox.Show($"تم حذف {employeeType}: {employeeName} بنجاح",
                            "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadAllEmployees();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("فشل في حذف الموظف. الرجاء المحاولة مرة أخرى",
                            "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في حذف الموظف: {ex.Message}",
                    "خطأ في قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllEmployees();
                ClearFields();

                MessageBox.Show("تم تحديث البيانات بنجاح",
                    "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحديث البيانات: {ex.Message}",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButtonEmp_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }



        /* private void cmbSearchTypEmp_SelectedIndexChanged(object sender, EventArgs e)
         {
             currentSearchType = cmbSearchTypEmp.SelectedItem.ToString();

             if (currentSearchType == "Role")
             {
                 txtsearchEmp.Visible = false;
                 searchrole.Visible = true;
                 searchrole.Focus();
             }
             else
             {
                 txtsearchEmp.Visible = true;
                 searchrole.Visible = false;
                 txtsearchEmp.Focus();
             }
         }
         */
        private void cmRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmRole.SelectedItem != null)
            {
                string selectedRole = cmRole.SelectedItem.ToString();

                // إظهار/إخفاء حقل التخصص بناءً على الدور
                bool isDoctor = (selectedRole == "DOCTOR");

                if (lblSpecialization != null && txtSpecialization != null)
                {
                    lblSpecialization.Visible = isDoctor;
                    txtSpecialization.Visible = isDoctor;

                    if (!isDoctor)
                        txtSpecialization.Text = "";
                }
            }
        }



        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = "";

                if (currentSearchType == "Role")
                {
                    searchValue = searchrole.SelectedItem.ToString();
                    if (searchValue == "ALL")
                    {
                        LoadAllEmployees();
                        return;
                    }
                }
                else
                {
                    searchValue = txtsearchEmp.Text.Trim();

                    if (string.IsNullOrEmpty(searchValue))
                    {
                        LoadAllEmployees();
                        return;
                    }
                }

                SearchEmployees(currentSearchType, searchValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في البحث: {ex.Message}",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchEmployees(string searchType, string searchValue)
        {
            try
            {
                dataGridView1.Rows.Clear();

                switch (searchType)
                {
                    case "ID":
                        SearchById(searchValue);
                        break;

                    case "Name":
                        SearchByName(searchValue);
                        break;

                    case "Phone":
                        SearchByPhone(searchValue);
                        break;

                    case "Role":
                        SearchByRole(searchValue);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في عملية البحث: {ex.Message}");
            }
        }

        private void SearchById(string idValue)
        {
            if (int.TryParse(idValue, out int id))
            {
                var doctor = employeeService.GetdoctorById(id);
                if (doctor != null)
                {
                    dataGridView1.Rows.Add(
                        doctor.DoctorId,
                        doctor.FullName,
                        doctor.Age,
                        doctor.Email,
                        doctor.Phone,
                        doctor.Salary,
                        "طبيب"
                    );
                }

                var receptionist = employeeService.GetReceptionistById(id);
                if (receptionist != null)
                {
                    dataGridView1.Rows.Add(
                        receptionist.ReseptionistId,
                        receptionist.FullName,
                        receptionist.Age,
                        receptionist.Email,
                        receptionist.Phone,
                        receptionist.Salary,
                        "موظف استقبال"
                    );
                }

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("لم يتم العثور على موظف بهذا الرقم", "نتيجة البحث",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SearchByName(string name)
        {
            // 🔥 التصحيح هنا - استخدم ToUpper() بدلاً من StringComparison
            string searchName = name.ToUpper();

            var doctors = employeeService.getAllDoctor()
                .Where(d => d.FullName.ToUpper().Contains(searchName))
                .ToList();

            foreach (var doctor in doctors)
            {
                dataGridView1.Rows.Add(
                    doctor.DoctorId,
                    doctor.FullName,
                    doctor.Age,
                    doctor.Email,
                    doctor.Phone,
                    doctor.Salary,
                    "طبيب"
                );
            }

            var receptionists = employeeService.getAllreseptionist()
                .Where(r => r.FullName.ToUpper().Contains(searchName))
                .ToList();

            foreach (var receptionist in receptionists)
            {
                dataGridView1.Rows.Add(
                    receptionist.ReseptionistId,
                    receptionist.FullName,
                    receptionist.Age,
                    receptionist.Email,
                    receptionist.Phone,
                    receptionist.Salary,
                    "موظف استقبال"
                );
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("لم يتم العثور على موظفين بهذا الاسم", "نتيجة البحث",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void SearchByPhone(string phone)
        {
            var doctors = employeeService.getAllDoctor()
                .Where(d => d.Phone.Contains(phone))
                .ToList();

            foreach (var doctor in doctors)
            {
                dataGridView1.Rows.Add(
                    doctor.DoctorId,
                    doctor.FullName,
                    doctor.Age,
                    doctor.Email,
                    doctor.Phone,
                    doctor.Salary,
                    "طبيب"
                );
            }

            var receptionists = employeeService.getAllreseptionist()
                .Where(r => r.Phone.Contains(phone))
                .ToList();

            foreach (var receptionist in receptionists)
            {
                dataGridView1.Rows.Add(
                    receptionist.ReseptionistId,
                    receptionist.FullName,
                    receptionist.Age,
                    receptionist.Email,
                    receptionist.Phone,
                    receptionist.Salary,
                    "موظف استقبال"
                );
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("لم يتم العثور على موظفين بهذا الرقم", "نتيجة البحث",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchByRole(string role)
        {
            if (role == "DOCTOR")
            {
                var doctors = employeeService.getAllDoctor();
                foreach (var doctor in doctors)
                {
                    dataGridView1.Rows.Add(
                        doctor.DoctorId,
                        doctor.FullName,
                        doctor.Age,
                        doctor.Email,
                        doctor.Phone,
                        doctor.Salary,
                        "طبيب"
                    );
                }
            }
            else if (role == "RECEPTIONIST")
            {
                var receptionists = employeeService.getAllreseptionist();
                foreach (var receptionist in receptionists)
                {
                    dataGridView1.Rows.Add(
                        receptionist.ReseptionistId,
                        receptionist.FullName,
                        receptionist.Age,
                        receptionist.Email,
                        receptionist.Phone,
                        receptionist.Salary,
                        "موظف استقبال"
                    );
                }
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show($"لم يتم العثور على موظفين بدور {role}", "نتيجة البحث",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtsearchEmp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchEmp_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        

       
        private void txtPhoneEmpl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalaryEmpl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtsearchEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentSearchType == "ID" && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    } }






















/*using Hospital_management_system.Models;
using Hospital_management_system.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class Employeemanagement : Form
    {
        public Employeemanagement()
        {
            InitializeComponent();
        }

        private EmployeeManagementServices employeeManagementServices = new EmployeeManagementServices();
        private Employee selectedemployee = null;

        //public lblSearchBy()
        //{
        //    InitializeComponent();
        //}

        private void Loademployee()
        {
            try
            {
                // ⚡️ مسح الصفوف فقط مع الحفاظ على الأعمدة
                dataGridView1.Rows.Clear();

                // ⚡️ جلب البيانات
                var doctors = employeeManagementServices.getAllDoctor();

                // ⚡️ إضافة البيانات مباشرة للجدول
                foreach (var doctor in doctors)
                {
                    dataGridView1.Rows.Add(
                        doctor.DoctorId,
                        doctor.FullName,
                        doctor.Age,
                        //doctor.gender,
                        doctor.Phone,
                        doctor.Salary,
                        doctor.Specialization
                    );
                }


                var reseptionists = employeeManagementServices.getAllDoctor();

                // ⚡️ إضافة البيانات مباشرة للجدول
                foreach (var reseption in reseptionists)
                {
                    dataGridView1.Rows.Add(
                        reseption.DoctorId,
                        reseption.FullName,
                        reseption.Age,
                        //doctor.gender,
                        reseption.Phone,
                        reseption.Salary,
                        reseption.Specialization
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // دالة تفريغ الحقول
        //private void ClearFields()
        //{
        //    txtNameEmpl.Clear();
        //    numAgeEmpl.Value = 0;
        //    gender.SelectedIndex = -1;
        //    txtPhoneEmpl.Clear();

        //    txtEmailEmpl.Clear();
        //    selectedemployee = null;

        //    تحديث حالة الأزرار بعد التفريغ

        //}


        private bool ValidateemployeeData()
        {
            if (string.IsNullOrWhiteSpace(txtNameEmpl.Text))
            {
                MessageBox.Show("Please enter patient name", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameEmpl.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneEmpl.Text))
            {
                MessageBox.Show("Please enter phone number", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneEmpl.Focus();
                return false;
            }

            if (numAgeEmpl.Value <= 0 || numAgeEmpl.Value > 120)
            {
                MessageBox.Show("Please enter valid age (1-120)", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numAgeEmpl.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmailEmpl.Text) || !txtEmailEmpl.Text.Contains("@"))
            {
                MessageBox.Show("please enert vilov email addres", "Error");
                txtEmailEmpl.Focus();
                return false;
            }
            if (!decimal.TryParse(txtSalaryEmpl.Text, out decimal salary) || salary <= 0)
            {
                MessageBox.Show(" please please enert vilov salary", "Error");
                txtSalaryEmpl.Focus();
                return false;
            }
            return true;
        }
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try

            {

                if (!ValidateemployeeData())
                    return;
                Employee newemployee;
                string role = cmRole.SelectedItem.ToString();
                if (role == Role.DOCTOR.ToString()) {
                    newemployee = new Doctor();
                    newemployee.Role =Role.DOCTOR;
                }
                   

                else {
                    newemployee = new reseptionist();
                    newemployee.Role = Role.RESEPTIONIST;
                }
                    


                newemployee.FullName = txtNameEmpl.Text.Trim();
                newemployee.Age = (int)numAgeEmpl.Value;
                //Gender = cmbGender.SelectedItem?.ToString() ?? "Male",
                newemployee.Phone = txtPhoneEmpl.Text.Trim();

                
                newemployee.Salary = Convert.ToInt32(txtSalaryEmpl.Text);
                newemployee.Email = txtEmailEmpl.Text.Trim();

                 bool success;

                
                    
                    success = employeeManagementServices.addemployee(newemployee);

                    if (success)
                    {
                        MessageBox.Show($"employee {newemployee.FullName} added successfully!",
                                       "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Loademployee();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add patient. Please try again.",
                                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding patient: {ex.Message}",
                               "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

     

        

        private void ClearFields()
        {
            txtNameEmpl.Text = "";
            numAgeEmpl.Value = 25;
            txtEmailEmpl.Text = "";
            txtPhoneEmpl.Text = "";
            txtSalaryEmpl.Text = "";
            txtNameEmpl.Focus();
        }

        

        private void backButtonEmp_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Loademployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // كود بسيط للحذف
            try
            {
                // ⚡️ احذف مباشرة من الصف المحدد
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    if (row.Cells["ID"].Value != null)
                    {
                        int employeeid = Convert.ToInt32(row.Cells["ID"].Value);
                        string employeeName = row.Cells["fullNameColumn"].Value?.ToString() ?? "Unknown";

                        var result = MessageBox.Show($"Are you sure you want to delete employee: {employeeName}?",
                                                   "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            Role role;
                            if (cmRole.SelectedItem.ToString() == Role.DOCTOR.ToString())
                                role = Role.DOCTOR;
                            else
                                role = Role.RESEPTIONIST;
                                bool success = employeeManagementServices.deletemployee(employeeid,role);

                            if (success)
                            {
                                MessageBox.Show($"Patient {employeeName} deleted successfully!",
                                               "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Loademployee ();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete patient. Please try again.",
                                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a patient row to delete",
                                  "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting patient: {ex.Message}",
                               "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnEdite_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            // كود بسيط للبحث
            MessageBox.Show("Search button clicked - Add your search logic here");
        }

        private void Employeemanagement_Load(object sender, EventArgs e)
        {

        }

      */
         
