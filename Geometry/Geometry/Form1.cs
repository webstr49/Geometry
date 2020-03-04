using Geometry.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    public partial class Form1 : Form
    {
        ShapeBase selectedShape;

        public Form1()
        {
            InitializeComponent();

            var geometryShapesTypes = Assembly.GetAssembly(typeof(ShapeBase)).GetTypes().Where(t => t.IsSubclassOf(typeof(ShapeBase))).ToArray();
            cbGeometryShapes.Items.AddRange(geometryShapesTypes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = selectedShape.CalcArea().ToString();
            if (result == InformationString.ConditionOfResults)
            {
                MessageBox.Show(InformationString.IncorrectValue, InformationString.TitleOfMessagge,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tbResult.Text = result;
            }
            
        }

        private void cbGeometryShapes_SelectedIndexChanged(object sender, EventArgs e)
        {

            pnlParameters.Controls.Clear();

            selectedShape = (ShapeBase)((Type)cbGeometryShapes.SelectedItem).GetConstructors().First().Invoke(new object[] { });

            pictureBox1.ImageLocation = selectedShape.ImagePath;

            for (int i = 0; i < selectedShape.Parameters.Count; i++)
            {
                var currentParameter = selectedShape.Parameters.ElementAt(i);

                Label label = new Label() { Top = i * 30, AutoSize = true, Text = currentParameter.Key };
                pnlParameters.Controls.Add(label);

                var numericUpDown = new NumericUpDown() { Top = i * 30, Left = 20, Name = currentParameter.Key, Value = currentParameter.Value };
                numericUpDown.ValueChanged += delegate { selectedShape.Parameters[numericUpDown.Name] = numericUpDown.Value; };
                pnlParameters.Controls.Add(numericUpDown);
            }
        }
    }
}
