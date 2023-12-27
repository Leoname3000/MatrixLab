using Logic;
using GUI;

namespace CMD
{
    public partial class Form1 : Form
    {
        IMatrix matrix;
        GraphicDrawer graphicDrawer;

        public Form1()
        {
            InitializeComponent();
            graphicDrawer = new GraphicDrawer(panel, new Pen(Color.Black, 3));

            matrix = new SimpleMatrix(7, 5);
            var cmdInit = new CmdInit(matrix);
            cmdInit.Execute();
            cmdInit.Register();
            Redraw();
        }

        public void Redraw()
        {
            graphicDrawer.Undraw();
            var drawableMatrix = new DrawableMatrix(matrix, 2);
            drawableMatrix.Draw(graphicDrawer);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int row = random.Next(matrix.Rows);
            int col = random.Next(matrix.Columns);
            //(row, col) = (1, 1);
            double item = matrix.GetItem(row, col) + 100;

            var cmdPutItem = new CmdPutItem(matrix, row, col, item);
            cmdPutItem.Execute();
            cmdPutItem.Register();
            Redraw();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            CM.Instance.Undo();
            Redraw();
        }
    }
}
