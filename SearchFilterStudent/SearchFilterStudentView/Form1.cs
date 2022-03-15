using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SearchFilterStudentView
{
    public partial class Form1 : Form
    {
        private StudentModel studentList;
        public Form1()
        {
            studentList = new StudentModel();
            InitializeComponent();

            //Initialize the Form with all the data without filter.
            StudentListDataGridView.DataSource = studentList.SearchStudent("", "").Tables[0];
        }
        /// <summary>
        /// This function is called when the search button is clicked.
        /// This function gets the text from the input searchTextBox and pass it to the function evaluation
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e)
        {
            string texto = searchTextBox.Text;
            evaluationSearch(texto);
        }
        /// <summary>
        /// This function evaluates the input text to check if the information is about name/surname/school's name
        /// or is a date of birth (with/without comparison symbols).
        /// NotDate: meaning the text is about name/surname/school's name
        /// Date: meaning the text is date of birth without comparison symbols
        /// Comparison Symbols(>=,<=,>,<) : meaning the text is date of birth with comparison symbols
        /// and "": give all the values in the student table
        /// 
        /// <param name="texto">
        /// texto:Text which the user has put in searchTextBox.
        /// </param>
        /// </summary>
        private void evaluationSearch(string texto)
        {
            string[] filteredSymbols = {"<", ">"};
            string results="NotDate";
            Regex extractDateRegex = new Regex("[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}");
            if (texto == "")
            {
                results = "";
            }
            else if (texto.Contains("/"))
            {
                results = "Date";
                for (int i = 0; i < filteredSymbols.Length; i++)
                {
                    if (texto.Contains(filteredSymbols[i]))
                    {
                        results = filteredSymbols[i];
                        //MessageBox.Show(cleanString);
                        if (texto.Contains('='))
                        {
                            results += "="; 
                        }
                        string[]cleanString = extractDateRegex.Matches(texto)
                            .Cast<Match>()
                            .Select(m => m.Value)
                            .ToArray();
                        texto = cleanString[0];

                    }
                }
            }

            StudentListDataGridView.DataSource = studentList.SearchStudent(texto, results).Tables[0];
         
        }
    }
}
