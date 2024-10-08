using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaZe.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Runtime.ConstrainedExecution;
using System.Windows.Controls;
using AcademiaZe.DataAccess;

namespace AcademiaZe.ViewModel;
public class LogradouroViewModel : ViewModelBase
{
    // implementa a interface INotifyPropertyChanged
    public ObservableCollection<Logradouro> Logradouros { get; set; }
    private Logradouro _selectedLogradouro;
    public Logradouro SelectedLogradouro
    {
        get { return _selectedLogradouro; }
        set
        {
            _selectedLogradouro = value;
            OnPropertyChanged("SelectedLogradouro");
        }
    }
    private LogradouroRepository _repository;
    public LogradouroViewModel()
    {
        Logradouros = new ObservableCollection<Logradouro>();
        _repository = new LogradouroRepository();
        GetAll();
    }
    public void GetAll()
    {
        // busca no banco de dados e carrega em Logradouros
        Logradouros.Clear();
        _repository.GetAll().ForEach(data => Logradouros.Add(data));
    }
}
