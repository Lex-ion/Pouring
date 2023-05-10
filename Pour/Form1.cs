namespace Pour
{
    public partial class Form1 : Form
    {
        public int Id { get; set; }
        public List<Form1>forms = new List<Form1>();

        public Form1(int id)
        {
            InitializeComponent();
            Id = id;
            
            if (Id == 0)
            {forms.Add(this);
                timer1.Enabled = true;
                progressBar1.Value = 100;
               for (int i = 1; i < 4; i++)
               {
                   Form1 f = new Form1(i);
                   f.Show();
                    f.Text = i.ToString();
                   forms.Add(f);
               }
               
           }
            
            this.Text = id.ToString();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.Text = this.Left + " " + this.Bottom;
           
            foreach (Form1 currentForm in forms)
            {
                foreach (Form1 comForm in forms)
                {
                    if (currentForm!=comForm)
                    {
                        
                    

                    if (Math.Abs(currentForm.Bottom - comForm.Bottom) > 450)
                    {
                        
                        if (Math.Abs(currentForm.Bottom - comForm.Bottom) < 525)
                        {
                            if (Math.Abs(currentForm.Left - comForm.Left) < 525)
                            { 
                            if (currentForm.Bottom < comForm.Bottom)
                                {
                                    if (currentForm.GetValue() > 00 && comForm.GetValue() < 100)
                                        {
                                            comForm.AddValue(1);
                                            currentForm.RemoveValue(1);
                                        }
                                }
                            }
                        }

                    }else
                    {
                        if (Math.Abs(currentForm.Left - comForm.Left) < 525&& Math.Abs(currentForm.Left - comForm.Left) > 450)
                        {
                                if (Math.Abs(currentForm.Bottom - comForm.Bottom) < 50)
                                {
                                    if (currentForm.GetValue() > comForm.GetValue())
                                    {
                                        currentForm.RemoveValue(1);
                                        comForm.AddValue(1);
                                    }
                                    if (currentForm.GetValue() < comForm.GetValue())
                                    {
                                        currentForm.AddValue(1);
                                        comForm.RemoveValue(1);
                                    }
                                }
                            

                        }
                    }






                    }
                }
            }
        }

        public void AddValue(int value)
        {
            progressBar1.Value += value;
        }
        public void RemoveValue(int value)
        {
            progressBar1.Value -= value;
        }
        public int GetValue()
        {
            return progressBar1.Value;
        }

    }
}