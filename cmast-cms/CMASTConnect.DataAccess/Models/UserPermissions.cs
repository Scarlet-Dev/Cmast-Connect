using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMASTConnect.DTO
{
    public class UserPermissions
    {
        // User Management
        public string CreateUser = "CREATE_USER";
        public string EditUser = "EDIT_USER";
        public string SetUserPermissions = "SET_USER_PERMISSIONS";
        public string DropUser = "DROP_USER";

        // Post Management
        public string CreatePost = "CREATE_POST";
        public string EditPost = "EDIT_POST";
        public string DeletePost = "DELETE_POST";
        public string PublishPost = "PUBLISH_POST";
        public string UnPublishPost = "UNPUBLISH_POST";

        // Forms Management
        public string CreateForm = "CREATE_FORM";
        public string EditForm = "EDIT_FORM";
        public string DeleteForm = "DELETE_FORM";
        public string PublishForm = "PUBLISH_FORM";
        public string UnPublishForm = "UNPUBLISH_FORM";
        
    }
}
