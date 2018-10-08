
using Labarator_1.Model;

namespace Labarator_1.Auxiliary.Interfaces
{
    public interface IIdentifyModel
    {
        CompareStateModel CompareModel { get; set; }
        bool InitializeTable(byte[] file);
        bool FindIdentify(string lexem);
        bool ResetPreviewScan();
    }
}
