namespace PostulanteS3
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {   // Obtener los valores de los TextBox
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string documento = txtDocumento.Text;

            // Obtener el valor seleccionado del ComboBox
            string tipoSeleccionado = cboTipo.SelectedItem?.ToString() ?? "No seleccionado";

            // Crear el mensaje para mostrar en el cuadro de diálogo
            string mensaje = $"Nombre: {nombre}\nApellido: {apellido}\nDocumento: {documento}\nTipo: {tipoSeleccionado}";

            // Mostrar el mensaje en un cuadro de diálogo
            MessageBox.Show(mensaje, "Datos Ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();

            // Limpiar el ComboBox,  restablecerlo a su valor por defecto
            cboTipo.SelectedIndex = -1;  // Esto deselecciona cualquier elemento en el ComboBox


        }
    }
}
