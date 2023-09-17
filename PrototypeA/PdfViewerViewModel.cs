using System.Reflection;
using System.ComponentModel;

namespace PrototypeA
{
    class PdfViewerViewModel : INotifyPropertyChanged
    {
        private Stream? Bio_pdfDocumentStream;
        private Stream? Chem_pdfDocumentStream;
        private Stream? Math_pdfDocumentStream;
        private Stream? Phy_pdfDocumentStream;
        public event PropertyChangedEventHandler? PropertyChanged;

        public Stream BioPdfDocumentStream
        {
            get
            {
                return Bio_pdfDocumentStream1;
            }
            set
            {
                Bio_pdfDocumentStream1 = value;
                OnPropertyChanged("BioPdfDocumentStream");
            }
        }
        public Stream ChemPdfDocumentStream
        {
            get
            {
                return Chem_pdfDocumentStream;
            }
            set
            {
                Chem_pdfDocumentStream = value;
                OnPropertyChanged("ChemPdfDocumentStream");
            }
        }
        public Stream MathPdfDocumentStream
        {
            get
            {
                return Math_pdfDocumentStream;
            }
            set
            {
                Bio_pdfDocumentStream1 = value;
                OnPropertyChanged("MathPdfDocumentStream");
            }
        }
        public Stream PhyPdfDocumentStream
        {
            get
            {
                return Phy_pdfDocumentStream;
            }
            set
            {
                Chem_pdfDocumentStream = value;
                OnPropertyChanged("PhyPdfDocumentStream");
            }
        }

        public Stream Bio_pdfDocumentStream1 { get => Bio_pdfDocumentStream; set => Bio_pdfDocumentStream = value; }

        public PdfViewerViewModel()
        {
            //Accessing the PDF document that is added as embedded resource as stream.
            Bio_pdfDocumentStream1 = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("PrototypeA.Assets.Bio.pdf");
            Chem_pdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("PrototypeA.Assets.Chem.pdf");
            Math_pdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("PrototypeA.Assets.Math.pdf");
            Phy_pdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("PrototypeA.Assets.Phy.pdf");
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
