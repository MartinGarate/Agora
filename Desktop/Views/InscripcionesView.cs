using Desktop.ExtensionMethod;
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
        List<Inscripcion>? _inscripciones = new();
        List<Usuario>? _usuarios = new();

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
            _usuarios = await _usuarioService.GetAllAsync();
            _usuarios = _usuarios?.Where(u => _inscripciones != null && !_inscripciones.Any(i => i.UsuarioId == u.Id)).ToList();
            dataGridViewUsuarios.DataSource = _usuarios;
            //ocultamos las columnas Id, DeleteDate, Is deleted
            dataGridViewUsuarios.HideColumns("Id", "DeleteDate", "IsDeleted");

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

        private async void ComboCapacitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCapacitaciones.SelectedValue is Capacitacion selectedCapacitacion)
            {
                _inscripciones = await _inscripcionService.GetInscriptosAsync(selectedCapacitacion.Id);
                GridInscripciones.DataSource = _inscripciones;
                GridInscripciones.HideColumns("Id", "UsuarioId", "TipoInscripcionId", "CapacitacionId", "UsuarioCobroId", "IsDeleted", "Capacitacion");
                await GetGrillaUsuarios();
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            _usuarios = _usuarios?
    .Where(u => u.Nombre.Contains(
            textBoxBuscar.Text, StringComparison.OrdinalIgnoreCase) ||
        u.Apellido.Contains(
            textBoxBuscar.Text, StringComparison.OrdinalIgnoreCase))
    .ToList();
            dataGridViewUsuarios.DataSource = _usuarios;
        }

        private async void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBuscar.Text))
            {
                await GetGrillaUsuarios();
            }
        }

        private void textBoxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonBuscar.PerformClick();
                e.Handled = true; // Evita el sonido de "ding" al presionar Enter
            }
        }
    }
}
