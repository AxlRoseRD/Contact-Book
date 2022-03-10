using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Presentation_Layer.Formularios;

namespace Presentation_Layer
{
    public partial class MainMenu : Form
    {
        //campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public MainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            panelIzquierdo.Controls.Add(leftBorderBtn);

            //fomr
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color AZUL_PASTEL = Color.FromArgb(149, 184, 246);
            public static Color CELESTE_PASTEL = Color.FromArgb(173, 213, 250);           
            public static Color AMARILLO_PASTEL = Color.FromArgb(249, 217, 154);
            public static Color ROSA_PASTEL = Color.FromArgb(249, 165, 154);
            public static Color NARANJA_PASTEL = Color.FromArgb(250, 95, 73);
            public static Color MARRON_PASTEL = Color.FromArgb(160, 96, 56);
            public static Color MORADO = Color.FromArgb(138, 83, 201);
        }

        //metodos
        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if(senderBtn != null)
            {
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(26, 139, 200);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //iconbuton
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                //label
                labelTitleChildForm.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(192,119,76);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchContact());
            ActivateButton(sender, RGBColors.AMARILLO_PASTEL);
        }

        private void btnnuevocontacto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.ROSA_PASTEL);
            OpenChildForm(new CreateContact());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Black;
            labelTitleChildForm.Text = "Menu Principal";
            labelTitleChildForm.ForeColor = Color.Black;
        }

        private void OpenChildForm(Form childrenForm) 
        {
            if(currentChildForm != null) 
            {
                currentChildForm.Close();
            }
            currentChildForm = childrenForm;
            childrenForm.TopLevel = false;
            childrenForm.FormBorderStyle = FormBorderStyle.None;
            childrenForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childrenForm);
            panelChildForm.Tag = childrenForm;
            childrenForm.BringToFront();
            childrenForm.Show();
            labelTitleChildForm.Text = childrenForm.Text;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
