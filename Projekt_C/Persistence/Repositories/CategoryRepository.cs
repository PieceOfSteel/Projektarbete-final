using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Projekt_C.Core;
using Projekt_C.Core.Domain;
using Projekt_C.Core.Repositories;
using Projekt_C.Core.Utilities;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Projekt_C.Persistence.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        public string Path { get; set; }

        public CategoryRepository()
        {

        }

        public CategoryRepository(string path)
        {
            Path = path;
            if (!File.Exists(Path))
            {
                CreateFile();
            }
        }

        public void Add(Category obj)
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

            XmlNode categoryNode = doc.CreateElement("Category");

            XmlAttribute idAttribute = doc.CreateAttribute("Id");
            idAttribute.Value = obj.Id.ToString();
            categoryNode.Attributes.Append(idAttribute);

            XmlElement categoriesElement = doc.DocumentElement;
            categoriesElement.AppendChild(categoryNode);

            XmlNode nameNode = doc.CreateElement("Name");
            nameNode.AppendChild(doc.CreateTextNode(obj.Name));
            categoryNode.AppendChild(nameNode);

            filestream.Close();
            filestream = new FileStream(Path, FileMode.Create);
            doc.Save(filestream);
            filestream.Close();

        }

        public Category Get(int id)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);
            
            var categoryElement =
                doc.Root
                .Elements("Category")
                .SingleOrDefault(elementId => elementId.Attribute("Id").Value == id.ToString());

            filestream.Close();

            var category = new Category();
            category.Id = Convert.ToInt32(categoryElement.Attribute("Id").Value);
            category.Name = categoryElement.Element("Name").Value;
            
            return category;
        }

        public Category getByName(string name)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            var categoryElement = from XElement element in doc.Descendants("Categories").Elements("Category")
                              where element.Element("Name").ToString() == name
                              select element;

            if (categoryElement == null)
            {
                throw new NullReferenceException();
            }

            filestream.Close();

            var category = new Category();
            category.Id = Convert.ToInt32(categoryElement.Attributes("Id"));
            category.Name = categoryElement.Descendants("Name").ToString();
            
            return category;
        }

        public List<Category> getAll()
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);
            
            var categoryElements = doc.Root.Elements("Category");
            filestream.Close();

            var categories = new List<Category>();
            foreach(var element in categoryElements)
            {
                categories.Add(new Category {
                    Id = Convert.ToInt32(element.Attribute("Id").Value),
                    Name = element.Element("Name").Value
                });
            }
            
            return categories;
        }

        public void Remove(Category obj)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            /*
            var categoryElement = from element in doc.Root.Elements("PodcastFeed")
                       where element.Attribute("Id").Value == obj.Id.ToString()
                       select element;
            */

            doc.Root
                .Elements("Category")
                .Where(x => (int)x.Attribute("Id") == obj.Id)
                .Remove();

            filestream.Close();
            filestream = new FileStream(Path, FileMode.Create);
            doc.Save(filestream);
            filestream.Close();
        }

        public void Update(Category obj)
        {
            //Remove existing object with the same id as the incoming object
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

            XmlElement categoriesElement = doc.CreateElement("Categories");
            doc.AppendChild(categoriesElement);

            doc.Save(filestream);
            filestream.Close();
        }

        private bool IdExists(int id)
        {
            var filestream = new FileStream(Path, FileMode.Open);
            var doc = XDocument.Load(filestream);

            foreach (XElement element in doc.Root.Elements("Category"))
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

            var everyId = from XElement element in doc.Descendants("Categories").Elements("Category")
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
