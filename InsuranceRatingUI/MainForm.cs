using InsuranceRating;

namespace InsuranceRatingUI
{
    public partial class MainForm : Form
    {
        RatingEngine _engine;

        public MainForm(RatingEngine engine)
        {
            InitializeComponent();

            _engine = engine;
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            if (txtPolicy.Text != "")
            {
                var logger = new FileLogger();
                StringPolicySource policySource = new StringPolicySource();
                policySource.PolicyString = txtPolicy.Text;

                var engine = new RatingEngine(logger,
                policySource,
                new JsonPolicySerializer(),
                new RaterFactory(logger));

                _engine = engine;
            }
            else
            {
                var logger = new FileLogger();

                var engine = new RatingEngine(logger,
                    new FilePolicySource(),
                    new JsonPolicySerializer(),
                    new RaterFactory(logger));

                _engine = engine;
            }

            try
            {
                _engine.Rate();
                lblValue.Text = _engine.Rating.ToString();
            }
            catch (Exception ex)
            {
                lblValue.Text = "Invalid JSON!";
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Ova aplikacija je alat za ocjenjivanje osiguranja koja vam omogućuje unos podataka o polici u JSON formatu. \n" +
            "Možete unijeti JSON podatke o polici izravno u tekstualno polje ili ih uvesti iz datoteke. \n" +
            "Nakon što su podaci o polici uneseni, kliknite na gumb 'Ocijeni' kako biste izračunali ocjenu osiguranja. \n" +
            "Izračunata ocjena će biti prikazana na ekranu. Koristite gumb 'Uvoz' za učitavanje JSON datoteke \n" +
            "ili gumb 'Pomoć' za pregled ovog opisa.\n",
            "Pomoć za aplikaciju",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Select a JSON file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string jsonFilePath = openFileDialog.FileName;
                        string jsonContent = File.ReadAllText(jsonFilePath);

                        var logger = new FileLogger();
                        StringPolicySource policySource = new StringPolicySource();
                        policySource.PolicyString = jsonContent;

                        var engine = new RatingEngine(logger,
                        policySource,
                        new JsonPolicySerializer(),
                        new RaterFactory(logger));

                        _engine = engine;

                        _engine.Rate();
                        lblValue.Text = _engine.Rating.ToString();
                    }
                    catch (Exception ex)
                    {
                        lblValue.Text = "Invalid JSON!";
                    }
                }
            }

        }
    }
}
