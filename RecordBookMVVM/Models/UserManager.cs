using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordBookMVVM.Models
{
    public class UserManager
    {
        public static ObservableCollection<User> _DatabaseUser = new ObservableCollection<User>() 
        { 
            new User(){Email ="thst0000@naver.com",Name="홍길동"},
            new User(){Email ="thst1111@naver.com",Name="김유신"},
            new User(){Email ="thst2222@naver.com",Name="강감찬"},
        };

        public static ObservableCollection<User> GetUsers()
        {

            return _DatabaseUser;
        }
        public static void AddUser(User user)
        {
            _DatabaseUser.Add(user);
        }
    }
}
