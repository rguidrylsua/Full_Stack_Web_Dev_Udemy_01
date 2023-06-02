using System;
using System.Windows.Forms;
using Section15_Udemy.Encapsulation;
using Section15_Udemy.Static_Using;
using Section15_Udemy.Inheritance;
using Section15_Udemy.Interface;
using Section15_Udemy.Polymorphism;
using Section15_Udemy.Abstract;
using Section15_Udemy.Partial_ve_Sealed_Class;

namespace Section15_Udemy
{
    public partial class SelectionScreen : Form
    {
        public SelectionScreen()
        {
            InitializeComponent();
        }

        private void btnEncapsulation_Click(object sender, EventArgs e)
        {
            EncapsulationForm encapsulationForm = new EncapsulationForm();
            encapsulationForm.ShowDialog();
        }

        private void btnStaticUsing_Click(object sender, EventArgs e)
        {
            StaticUsing staticUsingForm = new StaticUsing();
            staticUsingForm.ShowDialog();
        }

        private void btnInheritance_Click(object sender, EventArgs e)
        {
            InheritanceForm inheritanceForm = new InheritanceForm();
            inheritanceForm.ShowDialog();
        }

        private void btnInterface_Click(object sender, EventArgs e)
        {
            InterfaceForm interfaceForm = new InterfaceForm();
            interfaceForm.ShowDialog();
        }

        private void btnPolymorphism_Click(object sender, EventArgs e)
        {
            PolymorphismForm polymorphismForm = new PolymorphismForm();
            polymorphismForm.ShowDialog();
        }

        private void btnAbstract_Click(object sender, EventArgs e)
        {
            AbstractForm abstractForm = new AbstractForm();
            abstractForm.ShowDialog();
        }

        private void btnPartialSealedClass_Click(object sender, EventArgs e)
        {
            PartialveSealedForm partialveSealedForm = new PartialveSealedForm();
            partialveSealedForm.ShowDialog();
        }
    }
}
