namespace Parte_2_Uso_De_Matriz_De_3x3
{
    public partial class Form1 : Form
    {
        //Declara la matriz global
        string[,] matriz = new string[3, 3];
        //Variables para movernos dentro de las posiciones de la matriz
        public int fila1, colum1, fila2, colum2, fila3, colum3, countergen, i;

        public static bool IsNumeric(string valor)
        {
            //Determinar si el parametro valor puede convertirse a numero entero.
            int result;
            return int.TryParse(valor, out result);
        }
        public Form1()
        {
            InitializeComponent();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se validan los datos 
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacion solo numero
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            //Posiciones de la columna de la matriz
            colum1 = 0;
            colum2 = 0;
            colum3 = 0;

            //Se verifican el combobox1
            if(cbtipoinfo.SelectedIndex == 0)
            {
                if(txtInfo.Text =="")
                    txtInfo.BackColor = Color.Bisque;
                   else
                {
                    if (fila1 < 3)
                    {
                        //Agregamos el dato en la posicion[fila1,column1]
                        matriz[fila1, colum1] = txtInfo.Text;
                        //Pasamos a la siguiente fila de la matriz 
                        fila1 += 1;
                        MessageBox.Show("Nombre ingresado exitosamente", "", MessageBoxButtons.OK);
                        txtInfo.Clear(); //Limpiamos el textboxt1
                    }
                    else
                        MessageBox.Show("No se pueden agregar mas nombres", "Alerta",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        else
            {
                if (cbtipoinfo.SelectedIndex == 1)
                    if (txtInfo.Text == "")
                        txtInfo.BackColor = Color.Bisque;
                else
                        if (fila2 < 3)
                    {
                        //Agregamos el dato en la posicion (fila2,colum2) de la matriz
                        matriz[fila2, colum2] = txtInfo.Text;
                        //Pasamos a la siguiente fila de la matriz
                        fila2 += 1;
                        MessageBox.Show("Apellido ingresado exitosamente");
                            txtInfo.Clear();
                    }
                    else 
                    
                        MessageBox.Show("No se pueden agregar mas apellidos");
                    
                    else
                    
                
            }
        }
    }
}
