namespace WF.Teste1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new EstoqueContext())
            {
                comboBox1.DataSource = db.Categorias.ToList();
                comboBox1.DisplayMember = "Nome";
                comboBox1.ValueMember = "IdCategoria";

                hopeComboBox1.DataSource = db.Categorias.ToList();
                hopeComboBox1.DisplayMember = "Nome";
                hopeComboBox1.ValueMember = "IdCategoria";

                dataGridView1.DataSource = db.Categorias.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new EstoqueContext())
            {
                var cat = new Categoria();
                cat.Nome = "Teste";
                cat.Ativo = true;
                db.Categorias.Add(cat);
                db.SaveChanges();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Certifique-se de que uma célula válida tenha sido clicada
            {
                DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[0]; // Acesse a primeira célula da linha selecionada
                string cellValue = selectedCell.Value.ToString(); // Obtenha o valor da célula
                MessageBox.Show("Valor da primeira célula: " + cellValue);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[0]; // Acesse a primeira célula da linha selecionada
            string cellValue = selectedCell.State.ToString(); // Obtenha o valor da célula
            MessageBox.Show("Estado da primeira célula: " + cellValue);
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Defina as cores de fundo para as linhas pares e ímpares
                Color backgroundColor = e.RowIndex % 2 == 0 ? Color.LightBlue : Color.White;

                using (Brush brush = new SolidBrush(backgroundColor))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }
            }
        }
    }
}