namespace PilasyColas
{
    public partial class Form1 : Form
    {

        private const int MaxSize = 10;

        // Estructuras de datos
        private int[] pila = new int[MaxSize];
        private int[] cola = new int[MaxSize];

        // Índices para la pila y la cola
        private int topePila = -1; // Indica la posición actual de la pila
        private int frenteCola = 0; // Indica el inicio de la cola
        private int finalCola = 0; // Indica el final de la cola
        private int tamañoCola = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (topePila < MaxSize - 1)
            {
                topePila++;
                pila[topePila] = int.Parse(txtPila.Text);
                MostrarPila();
                txtPila.Clear();
            }
            else
            {
                MessageBox.Show("La pila está llena.");
            }
        }
        private void MostrarPila()
        {
            lstPila.Items.Clear(); // Limpia el contenido actual del ListBox
            for (int i = topePila; i >= 0; i--) // Recorre la pila desde el tope hacia abajo
            {
                lstPila.Items.Add(pila[i]); // Añade cada elemento al ListBox
            }
        }
        private void btnPop_Click(object sender, EventArgs e)
        {
            if (topePila >= 0)
            {
                MessageBox.Show($"Elemento eliminado: {pila[topePila]}");
                topePila--;
                MostrarPila();
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }
        private void btnPeekPila_Click(object sender, EventArgs e)
        {
            if (topePila >= 0)
            {
                MessageBox.Show($"Elemento en la cima: {pila[topePila]}");
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }
        private void MostrarPila()
        {
            lstPila.Items.Clear();
            for (int i = topePila; i >= 0; i--)
            {
                lstPila.Items.Add(pila[i]);
            }
        }
        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (tamañoCola < MaxSize)
            {
                cola[finalCola] = int.Parse(txtCola.Text);
                finalCola = (finalCola + 1) % MaxSize;
                tamañoCola++;
                MostrarCola();
                txtCola.Clear();
            }
            else
            {
                MessageBox.Show("La cola está llena.");
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (tamañoCola > 0)
            {
                MessageBox.Show($"Elemento eliminado: {cola[frenteCola]}");
                frenteCola = (frenteCola + 1) % MaxSize;
                tamañoCola--;
                MostrarCola();
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }
        }

        private void btnPeekCola_Click(object sender, EventArgs e)
        {
            if (tamañoCola > 0)
            {
                MessageBox.Show($"Elemento al frente: {cola[frenteCola]}");
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }
        }

        private void MostrarCola()
        {
            lstCola.Items.Clear();
            for (int i = 0; i < tamañoCola; i++)
            {
                int index = (frenteCola + i) % MaxSize;
                lstCola.Items.Add(cola[index]);
            }
        }
    }
}




