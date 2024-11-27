namespace project.win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to my program", "Message");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Close ", "Are you sure.. you really want to close...",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            /// input   รับค่าจาก textbox ชื่อ txtRedius (เเปลงชนิดข้อมูลเป็น Do)
            double Radius = 0;
            //Redius = Convert.ToSingle(txtRadius.Text);
            if (double.TryParse(txtRadius.Text, out Radius) == false)

            {
                MessageBox.Show("Entering incorrect information may result in errors.", " Hey,watchout Error... ");
                txtRadius.Focus(); // ไม่มี Cursar ที่ textBox
                txtRadius.SelectAll();
                return;
            }

            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI  ให้ค่า  Pi
            //Math.Pow(x,y)

            //output  นำไปเเสดงผลที่ lblResult
            lblResult.Text = CircleArea.ToString("0.00");

            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            double Height = 0;
            double Widht = 0;
            if (double.TryParse(txtHeight.Text, out Height) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เฮ้ย Error!!");
                return;
            }

            if (double.TryParse(txtWidth.Text, out Widht) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เฮ้ย Error!!");
                return;
            }
            // คำนวณพื้นที่สามเหลี่ยม
            double triangleArea = 0.5 * Height * Widht;
            lblResult.Text = triangleArea.ToString("0.00");
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double HexagonWidth = 0;
            if (double.TryParse(txtHexagonWidth.Text, out HexagonWidth) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เฮ้ย Error!!");
                return;
            }
            double hexagonArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(HexagonWidth, 2);
            lblResult.Text = hexagonArea.ToString("0.00");
        }
    }
}
