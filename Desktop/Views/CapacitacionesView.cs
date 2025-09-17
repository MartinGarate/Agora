using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Models;
using Service.Services;

namespace Desktop.Views
{
    public partial class CapacitacionesView : Form
    {
        GenericService<Capacitacion> _capacitacionService = new GenericService<Capacitacion>();
        Capacitacion _currentCapacitacion; // Capacitacion que esta seleccionada (con la que vamos a operar)
        List<Capacitacion> _capacitaciones; // Lista de capacitaciones obtenidas de la API

        public CapacitacionesView()
        {
            InitializeComponent();
            _ = GetAllData();
            textBoxFiltrarAuto.ContextMenuStrip = contextMenuStripLimpiar; // Asignar el menú contextual al TextBox
            checkBox_VerEliminados.CheckedChanged += DisplayHideControlsRestoreButton;
        }

        private void DisplayHideControlsRestoreButton(object? sender, EventArgs e)
        {

            buttonRestaurar.Visible = checkBox_VerEliminados.Checked;
            textBoxFiltrarAuto.Enabled = !checkBox_VerEliminados.Checked;
            ButtonBuscarAuto.Enabled = !checkBox_VerEliminados.Checked;
            ButtonEditarAuto.Enabled = !checkBox_VerEliminados.Checked;
            ButtonEliminarAuto.Enabled = !checkBox_VerEliminados.Checked;
            ButtonAgregarAuto.Enabled = !checkBox_VerEliminados.Checked;
        }

        private void ConfigurarDataGridView()
        {
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["IsDeleted"].Visible = false;
            dataGridView.Columns["DeleteTime"].Visible = false;


        }

        private async Task GetAllData()
        {
            if (checkBox_VerEliminados.Checked)
            {
                _capacitaciones = await _capacitacionService.GetAllDeletedsAsync();
            }
            else
                _capacitaciones = await _capacitacionService.GetAllAsync();
            dataGridView.DataSource = _capacitaciones;
            ConfigurarDataGridView();
        }

        private async void ButtonEliminarAuto_Click(object sender, EventArgs e)
        {
            //checkeamos que haya autos seleccionados
            if (dataGridView.RowCount > 0 && dataGridView.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)dataGridView.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que quieres borrar {entitySelected.Nombre}?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {

                    if (await _capacitacionService.DeleteAsync(entitySelected.Id))
                    {
                        MessageBox.Show($"{entitySelected.Nombre} ha sido borrado correctamente", "Borrado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.RowCount > 0 && dataGridView.SelectedRows.Count > 0)
            {
                //Capacitacion autoSeleccionado = (Autos)dataGridViewAutos.SelectedRows[0].DataBoundItem;
                //pictureBoxAuto.ImageLocation = autoSeleccionado.imagen;
            }
        }

        private void ButtonBuscarAuto_Click(object sender, EventArgs e)
        {
            // Filtramos por ponente o nombre
            string filtro = textBoxFiltrarAuto.Text.Trim().ToUpper();
            dataGridView.DataSource = _capacitaciones
                .Where(c =>
                    (!string.IsNullOrEmpty(c.Nombre) && c.Nombre.ToUpper().Contains(filtro)) ||
                    (!string.IsNullOrEmpty(c.Ponente) && c.Ponente.ToUpper().Contains(filtro))
                )
                .ToList();
        }

        private void LimpiarCampos()
        {
            //limpiamos todo
            TxtNombre.Clear();
            TxtDetalle.Clear();
            dateTimeFechaHora.Value = DateTime.Now;
            TxtPonente.Clear();
            checkBoxInscripcion.Checked = false;
            numericUpDownCupo.Value = 0;

        }

        public void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void textBoxFiltrarAuto_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBoxFiltrarAuto.Text))
            //{
            //    ButtonBuscarAuto.PerformClick();
            //}
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageLista;
            LimpiarCampos();
        }

        private void ButtonEditarAuto_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount > 0 && dataGridView.SelectedRows.Count > 0)
            {
                _currentCapacitacion = (Capacitacion)dataGridView.SelectedRows[0].DataBoundItem;
                TxtNombre.Text = _currentCapacitacion.Nombre;
                TxtDetalle.Text = _currentCapacitacion.Detalle;
                dateTimeFechaHora.Value = _currentCapacitacion.FechaHora;
                TxtPonente.Text = _currentCapacitacion.Ponente;
                checkBoxInscripcion.Checked = _currentCapacitacion.InscripcionAbierta;
                numericUpDownCupo.Value = _currentCapacitacion.Cupo;
                tabControl.SelectedTab = tabPageAgregar_Editar;
            }
            else
            {
                MessageBox.Show("No hay capacitación seleccionada para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if (dataGridViewAutos.RowCount > 0 && dataGridViewAutos.SelectedRows.Count > 0)
            //{
            //    autoModificado = (Autos)dataGridViewAutos.SelectedRows[0].DataBoundItem;
            //    textBoxImagenAuto.Text = autoModificado.imagen;
            //    textBoxMarcaAuto.Text = autoModificado.marca;
            //    numericAnioAuto.Value = autoModificado.anio;
            //    textBoxModeloAuto.Text = autoModificado.modelo;
            //    numericPrecioAuto.Value = (decimal)autoModificado.precio;
            //    checkBoxUsado.Checked = autoModificado.usado;
            //    tabControl.SelectTab("tabPageAgregar_Editar");
            //}
            //else
            //{
            //    MessageBox.Show("No hay auto seleccionado para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private async void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Capacitacion capacitacionAGuardar = new Capacitacion
            {
                Id = _currentCapacitacion?.Id ?? 0,
                Nombre = TxtNombre.Text,
                Detalle = TxtDetalle.Text,
                FechaHora = dateTimeFechaHora.Value,
                Ponente = TxtPonente.Text,
                InscripcionAbierta = checkBoxInscripcion.Checked,
                Cupo = (int)numericUpDownCupo.Value

            };

            bool response = false;
            if (_currentCapacitacion != null)
            {
                response = await _capacitacionService.UpdateAsync(capacitacionAGuardar);
            }
            else
            {
                var nuevaCapacitacion = await _capacitacionService.AddAsync(capacitacionAGuardar);
                response = nuevaCapacitacion != null;
            }
            if (response)
            {
                _currentCapacitacion = null;
                MessageBox.Show($"La capacitación {capacitacionAGuardar.Nombre} se guardó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await GetAllData();
                tabControl.SelectedTab=tabPageLista;
            }
            else
            {
                MessageBox.Show("Error al guardar la capacitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();

        }

        private void textBoxImagenAuto_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(textBoxImagenAuto.Text))
            //{
            //    pictureBoxImagenAuto.ImageLocation = textBoxImagenAuto.Text;
            //}
        }

        private void ButtonAgregarAuto_Click(object sender, EventArgs e)
        {

            tabControl.SelectedTab = tabPageAgregar_Editar;
            LimpiarCampos();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void checkBox_VerEliminados_CheckedChanged(object sender, EventArgs e)
        {
                await GetAllData(); 

        }

        private async void buttonRestaurar_Click(object sender, EventArgs e)
        {
            if(checkBox_VerEliminados.Checked == false)
            {
                MessageBox.Show("Debe de estar seleccionado 'Ver eliminados' para restaurar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridView.RowCount > 0 && dataGridView.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)dataGridView.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que quieres restaurar {entitySelected.Nombre}?", "Restaurar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    // Lógica para restaurar la capacitación
                    MessageBox.Show($"{entitySelected.Nombre} ha sido restaurado correctamente", "Restaurado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await _capacitacionService.RestoreAsync(entitySelected.Id);
                    GetAllData();
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

