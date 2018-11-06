using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using MetroFramework.Forms;
using Projekt_C.Core.Domain;
using Projekt_C.Core.Utilities;
using Projekt_C.Persistence;

namespace Projekt_C
{
    public partial class Form1 : MetroForm
    {
        private Dictionary<int, TabPage> TabPages { get; set; }
        private Dictionary<int, UpdateClock> UpdateClocks { get; set; }
        private Dictionary<int, Rss> ActiveRss { get; set; }
        
        private UIChangeFeed ChangeFeedForm { get; set; }
        private UIchangeCategory ChangeCategoryForm { get; set; }
        
        public Form1()
        {
            InitializeComponent();

            TabPages = new Dictionary<int, TabPage>();
            UpdateClocks = new Dictionary<int, UpdateClock>();
            ActiveRss = new Dictionary<int, Rss>();

            InitializeForms();
        }

        private void InitializeForms()
        {
            ChangeFeedForm = new UIChangeFeed();
            ChangeCategoryForm = new UIchangeCategory();

            ChangeFeedForm.FeedUpdated += new FeedUpdateHandler(UpdateComboBoxFeeds);
            ChangeCategoryForm.CategoryUpdated += new CategoryUpdateHandler(UpdateComboBoxCategories);
            ChangeCategoryForm.CategoryUpdated += UpdateComboBoxFeeds;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var inputName = txtBoxNameOfFeed.Text;
            var inputUrl = txtBoxUrl.Text;
            var inputFreqency = txtBoxFrequency.Text;
            var inputCategory = (Category)comboBoxCategories.SelectedItem;

            bool allFieldsFilled;

            if (
                inputName       == ""   ||
                inputUrl        == ""   ||
                inputFreqency   == ""   ||
                inputCategory   == null
                )
            {
                allFieldsFilled = false;
                Alert.FieldsNotFilled();
            } else
            {
                allFieldsFilled = true;
            }

            if(allFieldsFilled) {
                var podcastFeed = new PodcastFeed
                {
                    Name = txtBoxNameOfFeed.Text,
                    Url = txtBoxUrl.Text,
                    UpdateInterval = Convert.ToInt32(txtBoxFrequency.Text),
                    Category = inputCategory
                };
                UnitOfWork.PodcastFeed.Add(podcastFeed);

                UpdateComboBoxFeeds();
                Alert.FeedAdded();

                txtBoxNameOfFeed.Clear();
                txtBoxUrl.Clear();
                txtBoxFrequency.Clear();
            }
        }
        
        public void CreateFeedList(PodcastFeed podcastFeed)
         {
            var feedTab = new TabPage();
            tabCtrlFeeds.TabPages.Add(feedTab);

            var feedList = new ListBox();
            feedList.Dock = DockStyle.Fill;
            feedTab.Controls.Add(feedList);
            
            var rss = WebFetcher.FetchRss(podcastFeed.Url);
            var feed = RssParser.GetPodcastFeed(rss);

            podcastFeed.PodcastEpisodes = feed.PodcastEpisodes;
            feedTab.Text = podcastFeed.Name;
            
            foreach (PodcastEpisode podcast in podcastFeed.PodcastEpisodes)
            {
                feedList.Items.Add(podcast.Name);
            }

            ActiveRss.Add(podcastFeed.Id, rss);
            TabPages.Add(podcastFeed.Id, feedTab);
            UpdateClocks.Add(podcastFeed.Id, new UpdateClock(podcastFeed));

            SetUpdateClocks();
            UpdateClocks[podcastFeed.Id].Start();
        }

        private void SetUpdateClocks()
        {
            foreach (KeyValuePair<int, UpdateClock> entry in UpdateClocks)
            {
                entry.Value.Tick += (sender, e) =>
                {
                    UpdateFeedList(entry.Value.TimerFeed);
                };
            }
        }

        private void Value_Tick(object sender, EventArgs e)
        {
            
        }

        public void RemoveFeedList(PodcastFeed podcastFeed)
        {
            UpdateClocks[podcastFeed.Id].Stop();
            var tabPage = TabPages[podcastFeed.Id];
            tabCtrlFeeds.TabPages.Remove(tabPage);

            TabPages.Remove(podcastFeed.Id);
            UpdateClocks.Remove(podcastFeed.Id);
            ActiveRss.Remove(podcastFeed.Id);
        }

        public void UpdateFeedList(PodcastFeed podcastFeed)
        {
            if(CheckForUpdate(podcastFeed))
            {
                RemoveFeedList(podcastFeed);
                CreateFeedList(podcastFeed);
            }
        }

        //Returns true if a new version of the feed is found, otherwise false
        private bool CheckForUpdate(PodcastFeed podcastFeed)
        {
            var rss = WebFetcher.FetchRss(podcastFeed.Url);
            
            if (rss.Content == ActiveRss[podcastFeed.Id].Content)
            {
                return false;
            } else
            {
                return true;
            }
        }
        
        private void btnChangeFeed_Click(object sender, EventArgs e)
        {
            InitializeForms();
            ChangeFeedForm.Show(this); 
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            InitializeForms();
            ChangeCategoryForm.Show(this);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var category = new Category();
            if(txtBoxNewCategory.Text != "")
            {
                category.Name = txtBoxNewCategory.Text;
            }
            else
            {
                Alert.FieldsNotFilled();
                return;
            }
            
            UnitOfWork.Category.Add(category);

            UpdateComboBoxCategories();
            Alert.CategoryAdded();
            txtBoxNewCategory.Clear();
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            var category = (Category)comboBoxShowCategories.SelectedItem;

            if(category == null)
            {
                Alert.NoItem();
                return;
            }

            var podcastFeeds = from podcastFeed in UnitOfWork.PodcastFeed.getAll()
                               where podcastFeed.Category.Id == category.Id
                               select podcastFeed;
            
            foreach(PodcastFeed podcastFeed in podcastFeeds)
            {
                CreateFeedList(podcastFeed);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateComboBoxCategories();
            UpdateComboBoxFeeds();
            
        }

        private void UpdateComboBoxCategories()
        {
            var categories = UnitOfWork.Category.getAll();

            comboBoxCategories.Items.Clear();
            comboBoxShowCategories.Items.Clear();

            foreach (Category category in categories)
            {
                comboBoxCategories.Items.Add(category);
                comboBoxShowCategories.Items.Add(category);
            }
        }

        private void UpdateComboBoxFeeds()
        {
            comboBoxFeeds.Items.Clear();
            var podcastFeeds = UnitOfWork.PodcastFeed.getAll();

            foreach (PodcastFeed feed in podcastFeeds)
            {
                comboBoxFeeds.Items.Add(feed);
            }
        }

        private void txtBoxUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            var selectedCategory = (Category)comboBoxShowCategories.SelectedItem;
            if (selectedCategory == null)
            {
                Alert.NoItem();
                return;
            }
            
            var podcastFeeds = UnitOfWork.PodcastFeed.getAll();
            var dependentFeeds = from podcast in podcastFeeds
                                   where podcast.Category.Id == selectedCategory.Id
                                   select podcast.Name;

            if (dependentFeeds.Count() > 0)
            {
                Alert.DependentFeeds(dependentFeeds.ToArray());
                return;
            }

            UnitOfWork.Category.Remove(selectedCategory);

            UpdateComboBoxCategories();
            Alert.CategoryRemoved();
        }

        private void btnRemoveFeed_Click(object sender, EventArgs e)
        {
            var selectedFeed = (PodcastFeed)comboBoxFeeds.SelectedItem;
            if (selectedFeed == null)
            {
                Alert.NoItem();
                return;
            }
            UnitOfWork.PodcastFeed.Remove(selectedFeed);
            try
            {
                RemoveFeedList(selectedFeed);
            } catch(Exception ex)
            {

            }
            

            UpdateComboBoxFeeds();
            Alert.FeedRemoved();
        }

        private void btnShowFeed_Click(object sender, EventArgs e)
        {
            var selectedPodcastFeed = (PodcastFeed)comboBoxFeeds.SelectedItem;
            if(selectedPodcastFeed == null)
            {
                Alert.NoItem();
                return;
            }
            CreateFeedList(selectedPodcastFeed);
        }

        private void btnShowFeedInfo_Click(object sender, EventArgs e)
        {
            var selectedFeed = (PodcastFeed)comboBoxFeeds.SelectedItem;
            if (selectedFeed == null)
            {
                Alert.NoItem();
                return;
            }
            MessageBox.Show(selectedFeed.GetInfo());
        }
    }
}
          

