using Service.Interfaces;
using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class InscripcionesView : Form
    {
        GenericService<Capacitacion> _capacitacionService = new();
        GenericService<Usuario> _usuarioService = new();
        InscripcionService _inscripcionService = new();

        public InscripcionesView()
        {
            InitializeComponent();
            _ = GetAllData();
        }

        private async Task GetAllData()
        {
           await GetComboCapacitaciones();
            await GetGrillaUsuarios();
        }

        private async Task GetGrillaUsuarios()
        {
            //cargamos las capacitaciones en el combo

            var usuarios = await _usuarioService.GetAllAsync();
           dataGridViewUsuarios.DataSource = usuarios;

        }

        private async Task GetComboCapacitaciones()
        {
            //cargamos las capacitaciones en el combo

            var capacitaciones = await _capacitacionService.GetAllAsync();
            ComboCapacitaciones.DataSource = capacitaciones?.Where(c => c.InscripcionAbierta).ToList();
            ComboCapacitaciones.DisplayMember = "Nombre";
            ComboCapacitaciones.ValueMember = "Id";
            //cargamos las inscripciones de la capacitacion seleccionada

        }

        private void ComboCapacitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
