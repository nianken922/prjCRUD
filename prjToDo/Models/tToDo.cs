//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjToDo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tToDo
    {
        public int fId { get; set; }
        [DisplayName("標題")]        
        public string fTitle { get; set; }
        [DisplayName("圖示")]       
        public string fimage { get; set; }
        [DisplayName("上傳日期")]        
        public Nullable<System.DateTime> fDate { get; set; }
    }
}
