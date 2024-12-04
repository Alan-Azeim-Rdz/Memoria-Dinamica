namespace Memoria_Dinamica
{
    public partial class Form1 : Form
    {
        private int[] vector;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSizeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el tamaño del vector
                int size = int.Parse(TexBoxSizeVector.Text);

                if (size <= 0)
                {
                    MessageBox.Show("El tamaño debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                vector = new int[size];
                LblSizeVector.Text = size.ToString();
                MessageBox.Show($"Vector de tamaño {size} generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un número válido para el tamaño.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddData_Click(object sender, EventArgs e)
        {
            if (vector == null)
            {
                MessageBox.Show("Primero genere el vector.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Leer los valores introducidos
                string[] values = TexBoxAdd.Text.Split(',');

                if (values.Length != vector.Length)
                {
                    MessageBox.Show($"Debe ingresar exactamente {vector.Length} valores separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llenar el vector con los valores
                for (int i = 0; i < values.Length; i++)
                {
                    vector[i] = int.Parse(values[i].Trim());
                }

                // Mostrar los valores en el ListBox
                LstViewDataofVector.Items.Clear();
                foreach (int value in vector)
                {
                   LstViewDataofVector.Items.Add(Convert.ToString(value));
                }

                MessageBox.Show("Valores cargados y mostrados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Asegúrese de ingresar solo números enteros separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
