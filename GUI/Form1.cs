
using Logic;
using System.Data;

namespace GUI
{
    public partial class Form1 : Form
    {
        IMatrix? currentMatrix;
        ConsoleDrawer consoleDrawer;
        GraphicDrawer graphicDrawer;

        public Form1()
        {
            InitializeComponent();
            currentMatrix = null;
            consoleDrawer = new ConsoleDrawer('#');
            graphicDrawer = new GraphicDrawer(panel, new Pen(Color.Black, 3));
        }

        public void Clear()
        {
            Console.Clear();
            graphicDrawer.Undraw();
        }

        public ADrawableMatrix GetDrawableMatrix(IMatrix matrix)
        {
            ADrawableMatrix drawableMatrix = new DrawableMatrix(matrix, 2);
            if (borderCheckBox.Checked)
            {
                drawableMatrix = new BorderDecorator(drawableMatrix);
            }
            return drawableMatrix;
        }

        public void Redraw(IMatrix? matrix = null)
        {
            if (matrix != null)
            {
                MatrixFiller.Fill(matrix, 20, 10);
                currentMatrix = matrix;
            }
            if (currentMatrix == null) return;
            Clear();
            var drawableMatrix = GetDrawableMatrix(currentMatrix);
            drawableMatrix.Draw(consoleDrawer);
            drawableMatrix.Draw(graphicDrawer);
        }

        private void generateSimpleButton_Click(object sender, EventArgs e)
        {
            Redraw(new SimpleMatrix(5, 5));
        }

        private void generateScatterButton_Click(object sender, EventArgs e)
        {
            Redraw(new ScatterMatrix(5, 5));
        }

        private void borderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Redraw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}