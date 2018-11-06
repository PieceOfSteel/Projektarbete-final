using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Projekt_C.Core.Domain;
using Projekt_C.Core.Repositories;
using Projekt_C.Core.Utilities;

namespace Projekt_C.Persistence.Repositories
{
    public class FeedRepository : IRepository<PodcastFeed>
    {
        public string Path { get; set; }

        public FeedRepository()
        {

        }

        public FeedRepository(string path)
        {
            Path = path;
            if(!File.Exists(Path))
            {
                CreateFile();
            }
        }

        public void Add(PodcastFeed obj)
        {
            if (IdExists(obj.Id))
            {
                Alert.IdTaken();
                return;
            }

            if (obj.Id == 0)
            {
                obj.Id = GetFreeId();
            }

            var filestream = new FileStream(Path, FileMode.Open);
            var doc = new XmlDocument();
            doc.Load(filestream);

            XmlNode feedNode = doc.CreateElement("PodcastFeed");

            XmlAttribute idAttribute = doc.CreateAttribute("Id");
            idAttribute.Value = obj.Id.ToString();
            feedNode.Attributes.Append(idAttribute);

            XmlElement feedsElement = doc.DocumentElement;
            feedsElement.AppendChild(feedNode);

            XmlNode nameNode = doc.CreateElement("Name");
            nameNode.AppendChild(doc.CreateTextNode(obj.Name));
            feedNode.AppendChild(nameNode);

            XmlNode urlNode = doc.CreateElement("Url");
            urlNode.AppendChild(doc.CreateTextNode(obj.Url));
            feedNode.AppendChild(urlNode);

            XmlNode updateNode = doc.CreateElement("UpdateInterval");
            updateNode.AppendChild(doc.CreateTextNode(obj.UpdateInterval.ToString()));
            feedNode.AppendChild(updateNode);

            XmlNode categoryNode = doc.CreateElement("Category");
            categoryNode.AppendChild(doc.CreateTextNode(obj.Category.Id.ToString()));
            feedNode.AppendChild(categoryNode);

            filestream.Close();
            filestream = new FileStream(Path, FileMode.Create);
            doc.Save(filestream);
            filestream.Close();

        }

        public PodcastFeed Get(int id)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            var feedElement =
                doc.Root
                .Elements("PodcastFeed")
                .SingleOrDefault(elementId => elementId.Attribute("Id").Value == id.ToString());

            filestream.Close();

            var podcastFeed = new PodcastFeed();
            podcastFeed.Id = Convert.ToInt32(feedElement.Attribute("Id").Value);
            podcastFeed.Name = feedElement.Element("Name").Value;
            podcastFeed.Url = feedElement.Element("Url").Value;
            podcastFeed.UpdateInterval = Convert.ToInt32(feedElement.Element("UpdateInterval").Value);
            
            var categoryId = Convert.ToInt32(feedElement.Element("Category").Value);
            podcastFeed.Category = UnitOfWork.Category.Get(categoryId);
            
            return podcastFeed;
        }

        public PodcastFeed getByName(string name)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            var feedElement =
                doc.Root
                .Elements("PodcastFeed")
                .SingleOrDefault(elementName => elementName.Element("Name").Value == name);

            filestream.Close();

            var feedElementId = Convert.ToInt32(feedElement.Attribute("Id").Value);
            var podcastFeed = Get(feedElementId);
            
            return podcastFeed;
        }

        public List<PodcastFeed> getAll()
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            var feedElements = doc.Root.Elements("PodcastFeed");
            var length = feedElements.Count();

            filestream.Close();

            var podcastFeeds = new List<PodcastFeed>();
            foreach (var element in feedElements)
            {
                var feedElementId = Convert.ToInt32(element.Attribute("Id").Value);
                podcastFeeds.Add(Get(feedElementId));
            }
            
            return podcastFeeds;
        }

        public void Remove(PodcastFeed obj)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);
            
            doc.Root
                .Elements("PodcastFeed")
                .Where(x => (int)x.Attribute("Id") == obj.Id)
                .Remove();

            filestream.Close();
            filestream = new FileStream(Path, FileMode.Create);
            doc.Save(filestream);
            filestream.Close();
        }

        public void Update(PodcastFeed obj)
        {
            //Remove existing object that has the same id as the incoming object
            Remove(Get(obj.Id));

            //Add the incoming object to database
            Add(obj);
        }

        private void CreateFile()
        {
            var filestream = new FileStream(Path, FileMode.Create);
            var doc = new XmlDocument();

            var xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);

            XmlElement feedsElement = doc.CreateElement("PodcastFeeds");
            doc.AppendChild(feedsElement);

            doc.Save(filestream);
            filestream.Close();
        }

        private bool IdExists(int id)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            foreach (XElement element in doc.Root.Elements("PodcastFeed"))
            {
                if (id.ToString() == element.Attribute("Id").Value)
                {
                    filestream.Close();
                    return true;
                }
            }

            filestream.Close();
            return false;
        }

        public int GetFreeId()
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            var everyId = from XElement element in doc.Root.Elements("PodcastFeed")
                          orderby element.Attribute("Id").Value
                          select Convert.ToInt32(element.Attribute("Id").Value);

            int newId = 1;
            foreach (int usedId in everyId)
            {
                if (newId == usedId)
                {
                    newId += 1;
                }
                else
                {
                    break;
                }
            }

            filestream.Close();
            return newId;
        }
    }
}
