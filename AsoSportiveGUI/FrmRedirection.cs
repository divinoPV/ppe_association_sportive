using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsoSportiveBLL;
using AsoSportiveBO;

namespace AsoSportiveGUI
{
    public partial class FrmRedirection : Form
    {
        public FrmRedirection()
        {
            InitializeComponent();

            // affiche les données de l'utilisateur connecté
            idLabel.Text = Convert.ToString(GestionUtilisateurs.IdUtilisateurLog);
            loginLabel.Text = GestionUtilisateurs.LoginUtilisateurLog;
            roleLabel.Text = Convert.ToString(GestionUtilisateurs.RoleUtilisateurLog);
        }
    }
}
