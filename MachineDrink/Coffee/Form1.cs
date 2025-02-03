namespace Coffee
{
    public partial class Form1 : Form
    {
        VendingMachine machine;

        public Form1()
        {
            InitializeComponent();
            machine = new VendingMachine(3000, 2000, 1000, 500);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // ตั้งค่าเริ่มต้นสำหรับ NumericUpDown ทุกตัว
            numBlackCoffee.Value = 0;
            numMocca.Value = 0;
            numLatta.Value = 0;
            numChocolate.Value = 0;

            // ตั้งค่าเริ่มต้นของ Label
            UpdateStock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = (int)numBlackCoffee.Value;
            int cups = machine.CanMakeBlackCoffee(amount);
            if (cups > 0)
            {
                machine.buyBlackCoffee(cups);
               
                UpdateStock();
            }
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblChocolateStock_Click(object sender, EventArgs e)
        {

        }

        private void btnMocca_Click(object sender, EventArgs e)
        {
            int amount = (int)numMocca.Value;
            int cups = machine.CanMakeMocca(amount);
            if (cups > 0)
            {
                machine.buyMocca(cups);
                
                UpdateStock();
            }
           

        }

        private void btnLatta_Click(object sender, EventArgs e)
        {
            int amount = (int)numLatta.Value;
            int cups = machine.CanMakeLatta(amount);
            if (cups > 0)
            {
                machine.buyLatta(cups);
                
                UpdateStock();
            }
          


        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            int amount = (int)numChocolate.Value;
            int cups = machine.CanMakeChocolate(amount);
            if (cups > 0)
            {
                machine.buyChocolate(cups);
                
                UpdateStock();
            }
          


        }

        private void btnIncreaseStock_Click(object sender, EventArgs e)
        {
            // เพิ่มสต็อกของเครื่องดื่มทุกชนิด 100g
            machine.increaseStock(100, 100, 100, 100);
            UpdateStock();  // อัปเดตการแสดงผล
        }

        private void UpdateStock()
        {
            // แสดงสต็อกวัตถุดิบ
            lblBlackCoffeeStock.Text = "Black Coffee: " + machine.Coffee.ToString();
            lblMoccaStock.Text = "Mocca: " + machine.Water.ToString();
            lblLattaStock.Text = "Latta: " + machine.Milk.ToString();
            lblChocolateStock.Text = "Chocolate: " + machine.Chocolate.ToString();

            // คำนวณจำนวนแก้วที่สามารถทำได้
            int blackCoffeeCups = machine.CanMakeBlackCoffee(999);
            int moccaCups = machine.CanMakeMocca(999);
            int lattaCups = machine.CanMakeLatta(999);
            int chocolateCups = machine.CanMakeChocolate(999);

            lblBlackCoffeeStock.Text += $" (Max Cups: {blackCoffeeCups})";
            lblMoccaStock.Text += $" (Max Cups: {moccaCups})";
            lblLattaStock.Text += $" (Max Cups: {lattaCups})";
            lblChocolateStock.Text += $" (Max Cups: {chocolateCups})";

            // แสดงผลใน TextBox สำหรับวัตถุดิบ
            txtWater.Text = machine.Water.ToString();  // แสดงสต็อกน้ำ
            txtCoffee.Text = machine.Coffee.ToString();  // แสดงสต็อกกาแฟ
            txtMilk.Text = machine.Milk.ToString();  // แสดงสต็อกนม
            txtChocolate.Text = machine.Chocolate.ToString();  // แสดงสต็อกช็อคโกแลต

        }

        private void numMocca_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numLatta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCoffee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChocolate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
        public class VendingMachine
        {
            public int Water { get; set; }  // น้ำ
            public int Coffee { get; set; }  // กาแฟ
            public int Milk { get; set; }  // นม
            public int Chocolate { get; set; }  // ช็อคโกแลต

            public VendingMachine(int water, int coffee, int milk, int chocolate)
            {
                Water = water;
                Coffee = coffee;
                Milk = milk;
                Chocolate = chocolate;
            }

            // ฟังก์ชันคำนวณจำนวนแก้วที่ทำได้และตรวจสอบว่าวัตถุดิบเพียงพอหรือไม่
            public int CanMakeBlackCoffee(int amount)
            {
                int maxCups = Math.Min(Water / 300, Coffee / 20);
                return (maxCups >= amount) ? amount : maxCups;
            }

            public int CanMakeMocca(int amount)
            {
                int maxCups = Math.Min(Math.Min(Water / 300, Coffee / 20), Chocolate / 10);
                return (maxCups >= amount) ? amount : maxCups;
            }

            public int CanMakeLatta(int amount)
            {
                int maxCups = Math.Min(Math.Min(Water / 300, Coffee / 20), Milk / 10);
                return (maxCups >= amount) ? amount : maxCups;
            }

            public int CanMakeChocolate(int amount)
            {
                int maxCups = Math.Min(Water / 300, Chocolate / 20);
                return (maxCups >= amount) ? amount : maxCups;
            }

            // ฟังก์ชันสำหรับการซื้อกาแฟดำ
            public bool buyBlackCoffee(int amount)
            {
                int cups = CanMakeBlackCoffee(amount);
                if (cups > 0)
                {
                    Water -= cups * 300;
                    Coffee -= cups * 20;
                    return true;
                }
                else
                {
                    MessageBox.Show("Not enough stock for Black Coffee!");
                    return false;
                }
            }

            // ฟังก์ชันสำหรับการซื้อมอคค่า
            public bool buyMocca(int amount)
            {
                int cups = CanMakeMocca(amount);
                if (cups > 0)
                {
                    Water -= cups * 300;
                    Coffee -= cups * 20;
                    Chocolate -= cups * 10;
                    return true;
                }
                else
                {
                    MessageBox.Show("Not enough stock for Mocca!");
                    return false;
                }
            }

            // ฟังก์ชันสำหรับการซื้อลาเต้
            public bool buyLatta(int amount)
            {
                int cups = CanMakeLatta(amount);
                if (cups > 0)
                {
                    Water -= cups * 300;
                    Coffee -= cups * 20;
                    Milk -= cups * 10;
                    return true;
                }
                else
                {
                    MessageBox.Show("Not enough stock for Latta!");
                    return false;
                }
            }

            // ฟังก์ชันสำหรับการซื้อช็อคโกแลต
            public bool buyChocolate(int amount)
            {
                int cups = CanMakeChocolate(amount);
                if (cups > 0)
                {
                    Water -= cups * 300;
                    Chocolate -= cups * 20;
                    return true;
                }
                else
                {
                    MessageBox.Show("Not enough stock for Chocolate!");
                    return false;
                }
            }

            // ฟังก์ชันเพิ่มสต็อก
            public void increaseStock(int water, int coffee, int milk, int chocolate)
            {
                Water += water;
                Coffee += coffee;
                Milk += milk;
                Chocolate += chocolate;
            }
        }

        

       
 
















