using MetroFramework.Forms;
using Projekt_C.Persistence;
using Projekt_C.Core.Domain;
using Projekt_C.Core.Utilities;
using System;
using System.Windows.Forms;

namespace Projekt_C
{
    public delegate void FeedUpdateHandler();

    public partial class UIChangeFeed : MetroForm
    {
        public event FeedUpdateHandler FeedUpdated;

        public UIChangeFeed()
        {
            InitializeComponent();
        }

        private void btnConfirmChange_Click(object sender, System.EventArgs e)
        {
            PerformChange();
        }

        private void PerformChange()
        {
            PodcastFeed podcastFeed;

            if (comboBoxFeeds.SelectedItem == null)
            {
                Alert.NoItem();
                return;
            }
            else
            {
                podcastFeed = (PodcastFeed)comboBoxFeeds.SelectedItem;
            }

            if (txtBoxName.Text != "")
            {
                podcastFeed.Name = txtBoxName.Text;
            }

            if (txtBoxUrl.Text != "")
            {
                podcastFeed.Url = txtBoxUrl.Text;
            }

            if (txtBoxFrequency.Text != "")
            {
                podcastFeed.UpdateInterval = Convert.ToInt32(txtBoxFrequency.Text);
            }

            if (comboBoxCategories.SelectedItem != null)
            {
                podcastFeed.Category = (Category)comboBoxCategories.SelectedItem;
            }

            UnitOfWork.PodcastFeed.Update(podcastFeed);

            UpdateComboBoxFeeds();
            FeedUpdated();
            Alert.FeedChanged();

            txtBoxName.Clear();
            txtBoxUrl.Clear();
            txtBoxFrequency.Clear();
        }

        private void UIChangeFeed_Load(object sender, System.EventArgs e)
        {
            UpdateComboBoxFeeds();
            UpdateComboBoxCategories();
        }

        private void UpdateComboBoxFeeds()
        {
            comboBoxFeeds.Items.Clear();
            var podcastFeeds = UnitOfWork.PodcastFeed.getAll();

            foreach(PodcastFeed feed in podcastFeeds)
            {
                comboBoxFeeds.Items.Add(feed);
            }
        }

        private void UpdateComboBoxCategories()
        {
            comboBoxCategories.Items.Clear();
            var categories = UnitOfWork.Category.getAll();

            foreach(Category category in categories)
            {
                comboBoxCategories.Items.Add(category);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UIChangeFeed_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;
            //    Hide();
            //}
        }
    }
}
