using Microsoft.AspNetCore.Identity;

namespace IdentityCoreMvc.Identites
{
    public class MyUser : IdentityUser<int>
    {

        //public MyUser()
        //{
        //    Categoriler = new HashSet<Category>();
        //}
        public string? TcNo { get; set; }

        //Burasi Db'ye yansimaz. Sadece dbcontext sinfini sorgularken navigation property olarak tanimliyoruz
        public ICollection<Category>? Categoriler { get; set; }
    }
}
