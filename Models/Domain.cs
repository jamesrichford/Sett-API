﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sett.Models
{
    public class Domain : ModelWithId
    {
        public Domain()
        {
            _id = Guid.NewGuid();
            _users = new List<User>();
        }

        private Guid _id;
        public Guid Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _uri;
        public string Uri
        {
            get { return _uri; }
            set { _uri = value; }
        }

        private string _pageBaseUri;
        public string PageBaseUri
        {
            get { return _pageBaseUri; }
            set { _pageBaseUri = value; }
        }

        private string _articleBaseUri;
        public string ArticleBaseUri
        {
            get { return _articleBaseUri; }
            set { _articleBaseUri = value; }
        }

        private ICollection<User> _users;
        public virtual ICollection<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value.ToList();
            }
        }
    }
}
