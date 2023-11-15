
using Logic;
using System.Data;

namespace GUI
{
    public partial class Form1 : Form
    {
        ADrawableMatrix? currentMatrix;
        ConsoleDrawer consoleDrawer;
        GraphicDrawer graphicDrawer;

        public Form1()
        {
            InitializeComponent();
            currentMatrix = null;
            consoleDrawer = new ConsoleDrawer('#');
            graphicDrawer = new GraphicDrawer(panel, new Pen(Color.Black, 3));
        }

        public void UpdateMatrix(IMatrix matrix)
        {
            MatrixFiller.Fill(matrix, 20, 10);

            if (currentMatrix == null)
                currentMatrix = new DrawableMatrix(matrix, 2);
            else
                currentMatrix.ChangeMatrix(matrix);

            if (borderCheckBox.Checked && currentMatrix == currentMatrix.GetMatrix())
                currentMatrix = new BorderDecorator(currentMatrix);
        }

        public void Redraw()
        {
            if (currentMatrix == null) return;
            Console.Clear();
            graphicDrawer.Undraw();
            currentMatrix.Draw(consoleDrawer);
            currentMatrix.Draw(graphicDrawer);
        }

        private void generateSimpleButton_Click(object sender, EventArgs e)
        {
            IMatrix matrix = new SimpleMatrix(7, 5);
            UpdateMatrix(matrix);
            Redraw();
        }

        private void generateScatterButton_Click(object sender, EventArgs e)
        {
            IMatrix matrix = new ScatterMatrix(5, 7);
            UpdateMatrix(matrix);
            Redraw();
        }

        private void borderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (currentMatrix == null) return;
            if (borderCheckBox.Checked)
                currentMatrix = new BorderDecorator(currentMatrix);
            else
                currentMatrix = currentMatrix.GetMatrix();
            Redraw();
        }

        private void plusBorderButton_Click(object sender, EventArgs e)
        {
            if (currentMatrix == null) return;
            if (currentMatrix == currentMatrix.GetMatrix())
            {
                borderCheckBox.Checked = true;
                return;
            }
            currentMatrix = new BorderDecorator(currentMatrix);
            Redraw();
        }

        private void minusBorderButton_Click(object sender, EventArgs e)
        {
            if (currentMatrix == null || !borderCheckBox.Checked) return;
            currentMatrix = currentMatrix.GetChild();
            Redraw();
            if (currentMatrix == currentMatrix.GetMatrix())
                borderCheckBox.Checked = false;
        }
    }
}