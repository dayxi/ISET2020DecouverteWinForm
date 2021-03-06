﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ISET_2020_Découverte_WinForm
{
    public partial class EcranBDBasique : Form
    {
        string sChConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=perso.mdb";

        public EcranBDBasique()
        {
            InitializeComponent();
        }

        private void btnLecture_Click(object sender, EventArgs e)
        {
            OleDbConnection oConn = new OleDbConnection(sChConn); //initialise la connexion à la base de donnée
            oConn.Open(); // ouvre la connexion

            OleDbCommand oComm = new OleDbCommand("SELECT PRE,NOM FROM CLIENT ORDER BY NOM", oConn); 
            //procedure demandant de selectionner le prenom et le nom des membres par ordre de nom via la connexion établie

            OleDbDataReader dr = oComm.ExecuteReader(); 
            //lecture des données obtenues dans un flux via la procédure et enregistrement dans la variable dr

            while (dr.Read()) //tant que l'on peut lire des données dans le flux

                lbConsole.Items.Add(dr[0].ToString() + " " + dr["NOM"].ToString()); //Ajout de chaque client dans la box avec 2 écritures différentes

            dr.Close(); //termine la requete
            oConn.Close(); //ferme la connexion
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            OleDbConnection oConn = new OleDbConnection(sChConn); //initialise la connexion
            oConn.Open(); // ouvre la connexion
            OleDbCommand oComm = new OleDbCommand("SELECT COUNT(NOM) FROM CLIENT", oConn); //initialise la requete de comptage et l'associe a la connexion
            int nb = (int) oComm.ExecuteScalar(); //Obtient l'info demandée et la place dans une variable
            lbConsole.Items.Add("Il y a " + nb.ToString() + " enregistrements");

            oConn.Close();
        }

        private void btnInsertion_Click(object sender, EventArgs e)
        {
            OleDbConnection oConn = new OleDbConnection(sChConn);
            oConn.Open();
            OleDbCommand oComm = new OleDbCommand("INSERT INTO CLIENT(NOM,PRE) VALUES('" + tbNom.Text + "','" + tbPrenom.Text + "')", oConn);
            int nb = oComm.ExecuteNonQuery();// renvoi combien d'enregistrement sont concerné par la commande

            if(nb == 1)
            lbConsole.Items.Add("Insertion effectuée");
            else
            lbConsole.Items.Add("Raté");

            oConn.Close();
        }
    }
}
