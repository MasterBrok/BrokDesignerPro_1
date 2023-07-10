using BrokFindTeacher.Models;
using System.Collections.Generic;

namespace BrokFindTeacher.Repository
{
    public class RepositoryPerson
    {
		private List<Person> _list;
        public RepositoryPerson()
        {
            _list = new List<Person>()
            {
                new Person(){Name="Hani",Role="Network Security",Image="C:\\Users\\ManTech\\Desktop\\WPF(C#)\\MyProjectWPF\\BrokFindTeacher\\BrokFindTeacher\\Resources\\Images\\Hani.jpg",Language="English"},
                new Person(){Name="Ben",Role="Js And Full Stack",Image="C:\\Users\\ManTech\\Desktop\\WPF(C#)\\MyProjectWPF\\BrokFindTeacher\\BrokFindTeacher\\Resources\\Images\\Ben.jpg",Language="Spanish"},
                new Person(){Name="Brok",Role="Dot Net",Image="C:\\Users\\ManTech\\Desktop\\WPF(C#)\\MyProjectWPF\\BrokFindTeacher\\BrokFindTeacher\\Resources\\Images\\Brok.jpg",Language="Persian"},
            };
        }
        public List<Person> People
		{
			get { return _list; }
		}
	}
}
