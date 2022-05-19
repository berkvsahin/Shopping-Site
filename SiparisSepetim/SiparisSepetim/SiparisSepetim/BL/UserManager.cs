using OL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    //Busines Layer
    public class UserManager
    {
        public List<ObjUser> GetUsers()
        {
            DL.Sql sql = new DL.Sql();

            string Script = "Select * from TblUsers";
            DataTable dt = sql.ExecuteDatatable(Script);

            List<ObjUser> Users = new List<ObjUser>();

            foreach (DataRow dr in dt.Rows)
            {
                ObjUser user = new ObjUser();
                //UserId  //name
                user.UserId = Convert.ToInt32(dr["UserId"]);
                user.name = dr["name"].ToString();
                user.surname = dr["surname"].ToString();
                user.eMail = dr["eMail"].ToString();
                user.pass = dr["pass"].ToString() ;
                Users.Add(user);
            }
            return Users;

        }


        //public ObjUser Getuser(int USerId)
        //{ 
        //    DL.Sql sql = new DL.Sql();

        //    string Script = "Select * from TblUsers where UserId="+ USerId;
        //    DataTable dt = sql.ExecuteDatatable(Script);
        //    ObjUser user = new ObjUser();
        //    if (dt.Rows.Count>0)
        //    {
        //        user.UserId = Convert.ToInt32(dt.Rows[0]["UserId"]);
        //        user.name = dt.Rows[0]["Name"].ToString();

        //    } 
        //    return user;

        //}

        public ObjUser Getlogin(string Email,string Pass)  
        {
            DL.Sql sql = new DL.Sql();

            string Script = "Select * from tblUsers where eMail='"+Email+"'"+ " and pass='"+Pass+"'";

            DataTable dt = sql.ExecuteDatatable(Script); // Tablo okuma
            ObjUser user = new ObjUser();
            if (dt.Rows.Count > 0)
            {
                user.UserId = Convert.ToInt32(dt.Rows[0]["UserId"]); // Login kontrolü için
                user.name = dt.Rows[0]["name"].ToString();

            }
            return user;

        }
        public ObjUser SetSign(ObjUser User) 
        {
            
            DL.Sql sql = new DL.Sql();
            string Script = "INSERT INTO TblUsers(name,surname,eMail,pass) VALUES (@name,@surname,@eMail,@pass)";

            
            sql.addparameter("@name",User.name);
            sql.addparameter("@surname",User.surname);
            sql.addparameter("@eMail",User.eMail);
            sql.addparameter("@pass",User.pass);

            sql.Execute(Script);
            return User; 

        }
    }
}
