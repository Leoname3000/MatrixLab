
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

            if (borderCheckBox.Checked && currentMatrix == currentMatrix.GetEndpoint())
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
                currentMatrix = currentMatrix.GetEndpoint();
            Redraw();
        }

        private void plusBorderButton_Click(object sender, EventArgs e)
        {
            if (currentMatrix == null) return;
            if (currentMatrix == currentMatrix.GetEndpoint())
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
            if (currentMatrix == currentMatrix.GetEndpoint())
                borderCheckBox.Checked = false;
        }

        private void transposeButton_Click(object sender, EventArgs e)
        {
            if (currentMatrix == null) return;
            currentMatrix.ChangeMatrix(new TransposeDecorator(currentMatrix.GetMatrix()));
            Redraw();
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            if (currentMatrix == null) return;
            IMatrix matrix = currentMatrix.GetMatrix();
            Random random = new Random();

            int row1 = random.Next(0, matrix.Rows);
            int row2; do { row2 = random.Next(0, matrix.Rows); } while (row1 == row2);

            int col1 = random.Next(0, matrix.Columns);
            int col2; do { col2 = random.Next(0, matrix.Columns); } while (col1 == col2);

            currentMatrix.ChangeMatrix(new ColumnSwapperDecorator(col1, col2, new RowSwapperDecorator(matrix, row1, row2)));
            Redraw();
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            if (currentMatrix == null) return;
            currentMatrix.ChangeMatrix(currentMatrix.GetMatrix().GetEndpoint());
            Redraw();
        }
    }
}