
//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace exam
{

using System;
    using System.Collections.Generic;
    
public partial class Users
{

    public Users()
    {

        this.Comments = new HashSet<Comments>();

        this.Requests = new HashSet<Requests>();

        this.Requests1 = new HashSet<Requests>();

    }


    public long id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string ThirdName { get; set; }

    public string PhoneNumber { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }

    public long UserRoleId { get; set; }



    public virtual ICollection<Comments> Comments { get; set; }

    public virtual ICollection<Requests> Requests { get; set; }

    public virtual ICollection<Requests> Requests1 { get; set; }

    public virtual UserRole UserRole { get; set; }

}

}
