using Prism.Mvvm;

namespace Cardan.PlanChecker25.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private string _title = "My PlanChecker";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainViewModel()
        {

        }
    }
}
