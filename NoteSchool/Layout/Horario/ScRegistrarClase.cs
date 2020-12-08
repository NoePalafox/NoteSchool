﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteSchool.DataBase;

namespace NoteSchool.Layout.Horario {
    public partial class ScRegistrarClase : Form {

        //Constructor.
        public ScRegistrarClase() {
            InitializeComponent();
            
        }

        //Variables
        String dia;

        //Objetos.
        DataBase.Horario hr = new DataBase.Horario();
        ScHorario scHorario = new ScHorario();
        
        //setDia
        public String setDia(String text) {
            dia = text;
            return dia;
        }

        //Boton para registrar la clase.
        private void butRegistrarClase_Click(object sender, EventArgs e) {

            hr.crearClase(this, lDia.Text, tbMateria, tbHora, tbLink);
            
        }

        //Darle al lDia el valor del dia especifiacdo.
        private void ScRegistrarClase_Load(object sender, EventArgs e) {
            lDia.Text = dia;
        }
    
    }
}
