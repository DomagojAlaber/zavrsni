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
            if(txtPolicy.Text != "")
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
            catch(Exception ex) 
            {
                lblValue.Text = "Invalid JSON!";
            }
        }
    }
}
