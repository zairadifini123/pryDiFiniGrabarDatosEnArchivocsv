using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryDiFiniGrabarDatosEnArchivoTxt
{
    internal class clsArchivoClientes
    {
        public string NombreArchivo = "Clientes.csv";

        public void Grabar(string Cod, string Clie, string Deu, string Lim)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.Write(Cod);
            AD.Write(";");
            AD.Write(Clie);
            AD.Write(";");
            AD.Write(Deu);
            AD.Write(";");
            AD.WriteLine(Lim);
            AD.Close();
            AD.Dispose();
        }

        public void Listar(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose(); 
        }

        public Int32 CantidadClientes()
        {
            string DatosLeidos;
            Int32 c = 0;
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                c++;
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return c;
        }

        public Decimal DeudaClientes()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return Total;
        }

        public Decimal PromedioDeuda()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;
            Int32 c = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                c++;
                VecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return Total / c;
        }

        public void ListarDeudores(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                if (Convert.ToInt32(VecDatos[2])>0)
                {
                    Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
                }
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();
        }

        public Int32 CantidadDeudores()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Int32 c = 0;
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(VecDatos[2]) > 0)
                {
                    c++;
                }
                DatosLeidos = AD.ReadLine();
                
            }

            AD.Close();
            AD.Dispose();

            return c;
        }
    }
}
