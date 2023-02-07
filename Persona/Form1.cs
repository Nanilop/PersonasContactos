using PERSONAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPater.Text = "";
            txtMater.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
            Fecha.Value=DateTime.Now;
            labRFC.Visible = false;
            labRFC.Text="XXXX000000";
            adverEmail.Visible = false;
            adverFecha.Visible = false;
            adverNombre.Visible = false;
            adverPater.Visible = false;
            adverMat.Visible = false;
            adverTele.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Contacto c=new Contacto(txtTel.Text,txtEmail.Text,txtNombre.Text,txtPater.Text,txtMater.Text,Fecha.Value);
            labRFC.Text=c.RFC();
            labRFC.Visible=true;
            
        }

        private void txtMater_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtMater.Text) | String.IsNullOrWhiteSpace(txtMater.Text))
            {
                adverMat.Visible = true;
            }
            else
            {
                adverMat.Visible = false;
                if (textos(txtMater.Text))
                {
                    adverMat.Visible = false;
                }
                else { adverMat.Visible = true; }
            }
            FechaChanged();
            if (adverEmail.Visible == false & adverFecha.Visible == false & adverNombre.Visible == false & adverMat.Visible == false & adverPater.Visible == false & adverTele.Visible == false)
            {
                
                if (String.IsNullOrEmpty(txtEmail.Text)| String.IsNullOrWhiteSpace(txtEmail.Text)|
                    String.IsNullOrEmpty(txtTel.Text) | String.IsNullOrWhiteSpace(txtTel.Text)|
                    String.IsNullOrEmpty(txtNombre.Text) | String.IsNullOrWhiteSpace(txtNombre.Text)|
                    String.IsNullOrEmpty(txtMater.Text) | String.IsNullOrWhiteSpace(txtMater.Text)|
                    String.IsNullOrEmpty(txtPater.Text) | String.IsNullOrWhiteSpace(txtPater.Text)
                    ) {
                    btnCalcular.Enabled = false; }
                else {
                    btnCalcular.Enabled = true;
                }
            }
            else { btnCalcular.Enabled = false; }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text) | String.IsNullOrWhiteSpace(txtNombre.Text)) {
                adverNombre.Visible = true;
            }
            else
            {
                adverNombre.Visible = false;
                string n = txtNombre.Text.Replace(" ", "");
                int cant = 0;
                if (textos(n))
                {
                    adverNombre.Visible = false;
                    for (int i = 0; i < txtNombre.Text.Length; i++)
                    {
                        if (txtNombre.Text.Substring(i, 1) == " ")
                        {
                            cant += 1;
                        }
                    }
                    if (cant > 2)
                    {
                        adverNombre.Visible = true;
                    }
                    else
                    {
                        adverNombre.Visible = false;
                    }
                }
                else
                {
                    adverNombre.Visible = true;
                }
            }
            FechaChanged();
            if (adverEmail.Visible == false & adverFecha.Visible == false & adverNombre.Visible == false & adverMat.Visible == false & adverPater.Visible == false & adverTele.Visible == false)
            {
                
                if (String.IsNullOrEmpty(txtEmail.Text) | String.IsNullOrWhiteSpace(txtEmail.Text) |
                    String.IsNullOrEmpty(txtTel.Text) | String.IsNullOrWhiteSpace(txtTel.Text) |
                    String.IsNullOrEmpty(txtNombre.Text) | String.IsNullOrWhiteSpace(txtNombre.Text) |
                    String.IsNullOrEmpty(txtMater.Text) | String.IsNullOrWhiteSpace(txtMater.Text) |
                    String.IsNullOrEmpty(txtPater.Text) | String.IsNullOrWhiteSpace(txtPater.Text)
                    )
                {
                    btnCalcular.Enabled = false;
                }
                else
                {
                    btnCalcular.Enabled = true;
                }
            }
            else { btnCalcular.Enabled = false; }
        }
        private bool textos(string a) {
            for (int i=0;i<a.Length;i++) {
                if (Convert.ToChar(a.Substring(i, 1)) <= 90 & Convert.ToChar(a.Substring(i, 1)) >= 65)
                {

                }
                else if (Convert.ToChar(a.Substring(i, 1)) <= 122 & Convert.ToChar(a.Substring(i, 1)) >= 97)
                {

                }
                else if (a.Substring(i, 1) =="á"| a.Substring(i, 1) == "é" | a.Substring(i, 1) == "í" | a.Substring(i, 1) == "ó" |
                    a.Substring(i, 1) == "ú" | a.Substring(i, 1) == "ü" | a.Substring(i, 1) == "Á" | a.Substring(i, 1) == "É" |
                    a.Substring(i, 1) == "Í" | a.Substring(i, 1) == "Ó" | a.Substring(i, 1) == "Ü" | a.Substring(i, 1) == "Ú" 
                    | a.Substring(i, 1) == "ñ" | a.Substring(i, 1) == "Ñ")
                {

                }
                else { return false; }
            }
            return true;
        }

        private void txtPater_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPater.Text) | String.IsNullOrWhiteSpace(txtPater.Text))
            {
                adverPater.Visible = true;
            }
            else
            {
                adverPater.Visible = false;
                if (textos(txtPater.Text))
                {

                    adverPater.Visible = false;
                }
                else { adverPater.Visible = true; }
            }
            FechaChanged();
            if (adverEmail.Visible == false & adverFecha.Visible == false & adverNombre.Visible == false & adverMat.Visible == false & adverPater.Visible == false & adverTele.Visible == false)
            {
             
                if (String.IsNullOrEmpty(txtEmail.Text) | String.IsNullOrWhiteSpace(txtEmail.Text) |
                    String.IsNullOrEmpty(txtTel.Text) | String.IsNullOrWhiteSpace(txtTel.Text) |
                    String.IsNullOrEmpty(txtNombre.Text) | String.IsNullOrWhiteSpace(txtNombre.Text) |
                    String.IsNullOrEmpty(txtMater.Text) | String.IsNullOrWhiteSpace(txtMater.Text) |
                    String.IsNullOrEmpty(txtPater.Text) | String.IsNullOrWhiteSpace(txtPater.Text) 
                    )
                {
                    btnCalcular.Enabled = false;
                }
                else
                {
                    btnCalcular.Enabled = true;
                }
            }
            else { btnCalcular.Enabled = false; }
        }
        private void FechaChanged()
        {
            DateTime difer = Fecha.Value;
            if (difer.AddYears(18).CompareTo(DateTime.Now) > 0)
            {
                adverFecha.Visible = true;
            }
            else { adverFecha.Visible = false; }
        }
            private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime difer = Fecha.Value;
            if (difer.AddYears(18).CompareTo(DateTime.Now) >0)
            {
                adverFecha.Visible = true;
            }
            else { adverFecha.Visible = false; }
            if (adverEmail.Visible == false & adverFecha.Visible == false & adverNombre.Visible == false & adverMat.Visible == false & adverPater.Visible == false & adverTele.Visible == false)
            {
                
                if (String.IsNullOrEmpty(txtEmail.Text) | String.IsNullOrWhiteSpace(txtEmail.Text) |
                    String.IsNullOrEmpty(txtTel.Text) | String.IsNullOrWhiteSpace(txtTel.Text) |
                    String.IsNullOrEmpty(txtNombre.Text) | String.IsNullOrWhiteSpace(txtNombre.Text) |
                    String.IsNullOrEmpty(txtMater.Text) | String.IsNullOrWhiteSpace(txtMater.Text) |
                    String.IsNullOrEmpty(txtPater.Text) | String.IsNullOrWhiteSpace(txtPater.Text) 
                    )
                {
                    btnCalcular.Enabled = false;
                }
                else
                {
                    btnCalcular.Enabled = true;
                }
            }
            else { btnCalcular.Enabled = false; }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            adverEmail.Visible = false;
            if (String.IsNullOrEmpty(txtEmail.Text)) {
                adverEmail.Visible = true;
            }

            else {
                if (IsValidEmail(txtEmail.Text)) { }
                else
                {
                    adverEmail.Visible = true;
                }
                 }
            FechaChanged();
            if (adverEmail.Visible == false & adverFecha.Visible == false & adverNombre.Visible == false & adverMat.Visible == false & adverPater.Visible == false & adverTele.Visible == false)
            {
                
                if (String.IsNullOrEmpty(txtEmail.Text) | String.IsNullOrWhiteSpace(txtEmail.Text) |
                    String.IsNullOrEmpty(txtTel.Text) | String.IsNullOrWhiteSpace(txtTel.Text) |
                    String.IsNullOrEmpty(txtNombre.Text) | String.IsNullOrWhiteSpace(txtNombre.Text) |
                    String.IsNullOrEmpty(txtMater.Text) | String.IsNullOrWhiteSpace(txtMater.Text) |
                    String.IsNullOrEmpty(txtPater.Text) | String.IsNullOrWhiteSpace(txtPater.Text) 
                    )
                {
                    btnCalcular.Enabled = false;
                }
                else
                {
                    btnCalcular.Enabled = true;
                }
            }
            else { btnCalcular.Enabled = false; }
        }
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            txtTel.Text.Replace(" ","");
            adverTele.Visible = false;
            if (txtTel.Text.Length == 10) {
                if (txtTel.Text.StartsWith("7")| txtTel.Text.StartsWith("8")| txtTel.Text.StartsWith("9")) { 
                    for (int i = 0; i < txtTel.Text.Length; i++) {
                        if (Convert.ToChar(txtTel.Text.Substring(i, 1)) <= 57 & Convert.ToChar(txtTel.Text.Substring(i, 1)) >= 48)
                        {

                        }
                        else {
                            adverTele.Visible = true;
                        }
                    }
                }
                else {
                    adverTele.Visible = true;
                }
            }
            else { adverTele.Visible = true; }
            FechaChanged();
            if (adverEmail.Visible == false & adverFecha.Visible == false & adverNombre.Visible == false & adverMat.Visible == false & adverPater.Visible == false & adverTele.Visible == false)
            {
                
                if (String.IsNullOrEmpty(txtEmail.Text) | String.IsNullOrWhiteSpace(txtEmail.Text) |
                    String.IsNullOrEmpty(txtTel.Text) | String.IsNullOrWhiteSpace(txtTel.Text) |
                    String.IsNullOrEmpty(txtNombre.Text) | String.IsNullOrWhiteSpace(txtNombre.Text) |
                    String.IsNullOrEmpty(txtMater.Text) | String.IsNullOrWhiteSpace(txtMater.Text) |
                    String.IsNullOrEmpty(txtPater.Text) | String.IsNullOrWhiteSpace(txtPater.Text) 
                    )
                {
                    btnCalcular.Enabled = false;
                }
                else
                {
                    btnCalcular.Enabled = true;
                }
            }
            else { btnCalcular.Enabled = false; }
        }

        //un numero de telefono valido son 10 digitos y el primero es 7 8 o 9
    }

}
