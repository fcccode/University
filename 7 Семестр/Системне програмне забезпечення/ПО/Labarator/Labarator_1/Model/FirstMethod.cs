using Labarator_1.Auxiliary;
using Labarator_1.Auxiliary.Interfaces;

namespace Labarator_1.Model
{
    public class FirstMethod :BindingProperty, IIdentifyModel
    {
        private CompareStateModel _compareModel;
        public CompareStateModel CompareModel
        { get { return _compareModel; }
            set
            {
                _compareModel = value;
                OnPropertyChanged(nameof(CompareModel));
            }
        }

        public bool FindIdentify(string lexem)
        {
            return true;
        }

        public bool InitializeTable(byte[] file)
        {
            return true;
        }

        public bool ResetPreviewScan()
        {
            return true;
        }
    }
}
