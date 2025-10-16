using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Service.Models;
using Service.Services;
using System.Collections.ObjectModel;

namespace MovilApp.ViewModels.Admin
{
    partial class AdminCapacitacionesViewModel : ObservableObject
    {
        GenericService<Capacitacion> _capacitacionService = new GenericService<Capacitacion>();

        [ObservableProperty]
        private ObservableCollection<Capacitacion> capacitaciones;

        [NotifyCanExecuteChangedFor(nameof(EditCommand))]
        [NotifyCanExecuteChangedFor(nameof(DeleteCommand))]
        private Capacitacion capacitacionCurrent

        [ObservableProperty];
        private bool isRefreshing;

        [ObservableProperty]
        private string filterText;

        public IRelayCommand AddCommand { get; }
        public IRelayCommand EditCommand { get; }
        public IRelayCommand DeleteCommand { get; }
        public IRelayCommand RefreshCommand { get; }
        public AdminCapacitacionesViewModel()
        {
            _ = LoadCapacitaciones();
            AddCommand = new AsyncRelayCommand(AddCapacitacion);
            EditCommand = new AsyncRelayCommand(EditCapacitacion,CanEditCapacitacion);
            DeleteCommand = new AsyncRelayCommand(DeleteCapacitacion,CanDeleteCapacitacion);
            RefreshCommand = new AsyncRelayCommand(LoadCapacitaciones);
        }

        private bool CanDeleteCapacitacion()
        {
            return capacitacionCurrent !=null;
        }

        private Task DeleteCapacitacion()
        {
            throw new NotImplementedException();
        }

        private bool CanEditCapacitacion()
        {
            return capacitacionCurrent != null;
        }

        private Task EditCapacitacion()
        {
            throw new NotImplementedException();
        }

        private Task AddCapacitacion()
        {
            throw new NotImplementedException();
        }

        private async Task LoadCapacitaciones()
        {
            IsRefreshing = true;
            var capacitaciones = await _capacitacionService.GetAllAsync();
            Capacitaciones = capacitaciones != null ? new ObservableCollection<Capacitacion>(capacitaciones) : new ObservableCollection<Capacitacion>();
            IsRefreshing = false;
        }

    }
}
