
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Hello world!");
            var borderCheckBox = new CheckBox();
            var buttonSimpleMatrix = new Button();
            var buttonScatterMatrix = new Button();
            Controls.Add(borderCheckBox);
            Controls.Add(buttonSimpleMatrix);
            Controls.Add(buttonScatterMatrix);
        }
    }
}