using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace Cranz1.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public int UserInfoID { get; set; }

        [ForeignKey("UserInfoID")]
        public virtual UserInfo Info { get; set; }

        private ICollection<Deed> _deeds;
        public virtual ICollection<Deed> Deeds
        {
            get { return _deeds ?? (_deeds = new Collection<Deed>()); }
            set { _deeds = value; }
        }

        private ICollection<User> _followings;
        public virtual ICollection<User> Followings
        {
            get { return _followings ?? (_followings = new Collection<User>()); }
            set { _followings = value; }
        }

        private ICollection<User> _followers;
        public virtual ICollection<User> Followers
        {
            get { return _followers ?? (_followers = new Collection<User>()); }
            set { _followers = value; }
        }
    }
}