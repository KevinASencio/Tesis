using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;
using Controllers;

namespace GUI.Clases
{
    public class AgregarFacBanco
    {
        FacturasNeg fac = new FacturasNeg();

        OpenFileDialog openFileDialog = new OpenFileDialog();

        public void algo() {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Selecciona un archivo Excel";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
           {
               string filePath = openFileDialog.FileName;

               // Abre el archivo Excel
               FileInfo fileInfo = new FileInfo(filePath);
               using (ExcelPackage package = new ExcelPackage(fileInfo))
               {
                   // Selecciona la primera hoja de trabajo
                   ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                   // Lee la columna 'idfactura'
                   int rowCount = worksheet.Dimension.Rows;
                   for (int row = 1; row <= rowCount; row++)
                   {
                       var cellValue = worksheet.Cells[row, 1].Text; // Asumiendo que 'idfactura' está en la primera columna
                        fac.IngresarFacBanco(cellValue);
                       Console.WriteLine(cellValue);
                   }
               }
           }
            
        }
           // Muestra el diálogo y obtiene el resultado
          

        /*   

           using OfficeOpenXml;
   using System;
   using System.IO;
   using System.Windows.Forms;

   class Program
   {
       [STAThread]
       static void Main(string[] args)
       {
           // Configura el OpenFileDialog
           
       }
   }


         */

    }
}
