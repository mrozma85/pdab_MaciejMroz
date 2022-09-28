using Firma.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Firma.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Fields
        //Poprzez MainWindowViewModel będziemy sterować kolekcją linków, które będą znajdowały się po lewej stronie okna, oraz kolekcją zakładek, które będą znajdowały się po prawej stronie okna
        //To jest kolekcja linków po lewej stronie
        private ReadOnlyCollection<CommandViewModel> _Commands; //Każdy link po lewej stronie jest CommandViewModelem
        //Poniższe oznacza zbiór zakładek po prawej stronie
        private ObservableCollection<WorkspaceViewModel> _Workspaces;
        #endregion
        #region ToolbarCommands
        private BaseCommand _CreateTowarCommand;
        private BaseCommand _CreateKontrahenciCommand;
        private BaseCommand _CreatePlatnosciCommand;
        private BaseCommand _CreateKadraCommand;
        private BaseCommand _CreateZlecenieCommand;
        private BaseCommand _CreateDodajPracownikaCommand;
        //To jest komenda która zostanie podpięta pod przycisk w pasku narzędzi i ta komenda wywoła funkcję Create
        public ICommand CreateTowarCommand
        {
            get
            {
                if(_CreateTowarCommand==null)
                {
                    _CreateTowarCommand = new BaseCommand(() => Create(new NowyTowarViewModel()));
                }
                return _CreateTowarCommand;
            }
        }

        public ICommand CreateKontrahenciCommand
        {
            get
            {
                if (_CreateKontrahenciCommand == null)
                {
                    _CreateKontrahenciCommand = new BaseCommand(() => Create(new KontrahenciViewModel()));
                }
                return _CreateKontrahenciCommand;
            }
        }

        public ICommand CreatePlatnosciCommand
        {
            get
            {
                if (_CreatePlatnosciCommand == null)
                {
                    _CreatePlatnosciCommand = new BaseCommand(() => Create(new PlatnosciViewModel()));
                }
                return _CreatePlatnosciCommand;
            }
        }
        public ICommand CreateKadraCommand
        {
            get
            {
                if (_CreateKadraCommand == null)
                {
                    _CreateKadraCommand = new BaseCommand(() => Create(new KadryViewModel()));
                }
                return _CreateKadraCommand;
            }
        }
        public ICommand CreateZlecenieCommand
        {
            get
            {
                if (_CreateZlecenieCommand == null)
                {
                    _CreateZlecenieCommand = new BaseCommand(() => Create(new ZlecenieSerwisoweViewModel()));
                }
                return _CreateZlecenieCommand;
            }
        }
        public ICommand CreateDodajPracownikaCommand
        {
            get
            {
                if (_CreateDodajPracownikaCommand == null)
                {
                    _CreateDodajPracownikaCommand = new BaseCommand(() => Create(new NowyPracownikViewModel()));
                }
                return _CreateDodajPracownikaCommand;
            }
        }
        #endregion
        #region Commands
        public ReadOnlyCollection<CommandViewModel> Commands
        {
            get
            {
                //Sprawdzamy czy lista linków jest pusta
                if (_Commands==null)
                {
                    //Jeżeli lista linków z lewej strony jest pusta to tworzymy tę listę przy pomocy funkcji CreateCommands();
                    List<CommandViewModel> cmds = this.CreateCommands();
                    //Tworzymy ReadOnlyCollection na bazie listy komend, która została utworzona wyżej
                    _Commands = new ReadOnlyCollection<CommandViewModel>(cmds);
                }
                return _Commands;
            }
        }

        private List<CommandViewModel> CreateCommands()
        {
            //W tej metodzie decydujemy jakie linki będą po lewej stronie
            return new List<CommandViewModel>
            {
                //new CommandViewModel("Dodaj towar",new BaseCommand(()=>this.CreateTowar())), //Tworzymy link z lewej strony, który nazywa się Dodaj towar i wywołuje funkcję CreateTowar(), która jest niżej
                 new CommandViewModel("Magazyn",new BaseCommand(()=>this.Create(new NowyTowarViewModel()))),
                 new CommandViewModel("Raport",new BaseCommand(()=>this.Create(new RaportPrzyjecTowarowViewModel()))),
                 new CommandViewModel("Nowy towar",new BaseCommand(()=>this.Create(new NowyTowarZwykleViewModel()))),
                 new CommandViewModel("Kontrahenci",new BaseCommand(()=>this.Create(new KontrahenciViewModel()))),
                 new CommandViewModel("Nowy kontrahent",new BaseCommand(()=>this.Create(new NowyKontrahent1ViewModel()))),
                 new CommandViewModel("Płatności",new BaseCommand(()=>this.Create(new PlatnosciViewModel()))),
                 new CommandViewModel("Zarządzanie kadrą",new BaseCommand(()=>this.Create(new KadryViewModel()))),
                 new CommandViewModel("Zlecenie serwisowe",new BaseCommand(()=>this.Create(new ZlecenieSerwisoweViewModel()))),
                 new CommandViewModel("Wyswietl Towary",new BaseCommand(()=>this.Create(new WszystkieTowaryViewModel()))),
                 new CommandViewModel("Wszyscy Pracownicy",new BaseCommand(()=>this.Create(new WszyscyPracownicyViewModel()))),
                 new CommandViewModel("Dodaj pracownika",new BaseCommand(()=>this.Create(new NowyPracownikViewModel()))),
                 new CommandViewModel("Wyswietl Kontrahentow",new BaseCommand(()=>this.Create(new WszyscyKontrahenciViewModel()))),
                 new CommandViewModel("Wszystkie Adresy",new BaseCommand(()=>this.Create(new WszystkieAdresyViewModel()))),
                 new CommandViewModel("Nowy adres",new BaseCommand(()=>this.Create(new NowyAdresViewModel()))),
                 new CommandViewModel("Wszystkie faktury",new BaseCommand(()=>this.Create(new WszystkieFakturyViewModel()))),
                 new CommandViewModel("Formy platnosci",new BaseCommand(()=>this.Create(new WszystkieFormyPlatnosciViewModel()))),
                 new CommandViewModel("Nowa forma platnosci",new BaseCommand(()=>this.Create(new NowaFormaPlatnosciViewModel()))),
                 new CommandViewModel("Jednostki Miary Towaru",new BaseCommand(()=>this.Create(new WszystkieJednostkiMiaryTowaryViewModel()))),
                 new CommandViewModel("Pozycje Przyjec Zewnetrznych",new BaseCommand(()=>this.Create(new WszystkiePozycjePrzyjecZewnetrznychTowaruViewModel()))),
                 new CommandViewModel("Pozycje Wydan Zewnetrznych",new BaseCommand(()=>this.Create(new WszystkiePozycjeWydanZewnetrznychTowaruViewModel()))),
                 new CommandViewModel("Przyjecia Zewnetrzne",new BaseCommand(()=>this.Create(new WszystkiePrzyjeciaZewnetrzneTowaruViewModel()))),
                 new CommandViewModel("Stawki Vat",new BaseCommand(()=>this.Create(new WszystkieStawkiVatZakupuViewModel()))),
                 new CommandViewModel("Nowa Stawka Vat",new BaseCommand(()=>this.Create(new NowaStawkaVatZakupuViewModel()))),
                 new CommandViewModel("Wydanie Zewnetrzne",new BaseCommand(()=>this.Create(new WszystkieWydaniaZewnetrzneTowaruViewModel()))),
                 new CommandViewModel("Zmiany Cen",new BaseCommand(()=>this.Create(new WszystkieZmianyCenTowarowViewModel()))),
                 new CommandViewModel("Rodzaje kontrahentow",new BaseCommand(()=>this.Create(new WszystkieRodzajeKontrahentaViewModel()))),
            };
        }
        #endregion
        #region Workspaces
        public ObservableCollection<WorkspaceViewModel> Workspaces
        {
            get
            {
                if(_Workspaces==null)
                {
                    _Workspaces = new ObservableCollection<WorkspaceViewModel>();
                    _Workspaces.CollectionChanged += this.OnWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        private void OnWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null && e.NewItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += this.OnWorkspaceRequestClose;
            if (e.OldItems != null && e.OldItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.OldItems)
                    workspace.RequestClose -= this.OnWorkspaceRequestClose;
        }
        private void OnWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkspaceViewModel workspace = sender as WorkspaceViewModel;
            //workspace.Dispos();
            this.Workspaces.Remove(workspace);
        }
        #endregion
        #region PrivateHelpers
        //Zamiast tysiąca funkcji jedna Create
        private void Create(WorkspaceViewModel workspace)
        {
            this.Workspaces.Add(workspace);
            this.SetActiveWorkspace(workspace);
        }
        ////Funkcje CreateCokolwiek() (np CreateTowar()) za każdym razem tworzą nową zakładkę
        //private void CreateTowar()
        //{
        //    //Tworzymy nową zakładkę do dodawania towaru (ViewModelu)
        //    NowyTowarViewModel workspace = new NowyTowarViewModel();
        //    //Tę zakładkę dodajemy do kolekcji zakładek
        //    this.Workspaces.Add(workspace);
        //    //Ustawiamy aktywność tej zakładki
        //    this.SetActiveWorkspace(workspace);
        //}
        //private void CreateFaktura()
        //{          
        //    NowaFakturaViewModel workspace = new NowaFakturaViewModel();
        //    this.Workspaces.Add(workspace);
        //    this.SetActiveWorkspace(workspace);
        //}
        //Funkcje ShowAllCokolwiek() (np ShowAllTowar()) najpierw sprawdzają czy zakładki ze wszystkimi towarami już nie ma na liście zakładek i jeżeli jest to ponownie ją uaktywniają, a jeżeli nie ma to ją dodają
        /*private void ShowAllTowar()
        {
            //W kolekcji wszystkich zakładek o nazwie Workspaces szukam takiej zakładki, która jest wszystkimi towarami 
            WszystkieTowaryViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is WszystkieTowaryViewModel) as WszystkieTowaryViewModel;
            //Jeżeli takiej zakładki nie ma....
            if(workspace==null)
            {
                //...to tworzę nową zakładkę i dodaję do kolekcji wyświetlanych zakładek
                workspace = new WszystkieTowaryViewModel();
                this.Workspaces.Add(workspace);
            }
            //Uaktywniam zakładkę którą znalazłem lub dodałem
            this.SetActiveWorkspace(workspace);
        }
        private void ShowAllFaktura()
        {
            WszystkieFakturyViewModel workspace =
                this.Workspaces.FirstOrDefault(vm => vm is WszystkieFakturyViewModel) as WszystkieFakturyViewModel;
            if (workspace == null)
            {
                workspace = new WszystkieFakturyViewModel();
                this.Workspaces.Add(workspace);
            }
            this.SetActiveWorkspace(workspace);
        }
        */
        private void SetActiveWorkspace(WorkspaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null) collectionView.MoveCurrentTo(workspace);
        }
        #endregion
    }
}
