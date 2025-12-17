using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Myoffice_ACPD.Model
{
    public class MyOffice_ACPD
    {
        
        // [ACPD_SID][char](20) NOT NULL,
        [Key]
        [StringLength(20)]
        public string ACPD_SID { get; set; }
        
        // [ACPD_Cname] [nvarchar] (60) NULL,
        [StringLength(60)]
        public string? ACPD_Cname { get; set; }
        
        //[ACPD_Ename][nvarchar] (40) NULL,
        [StringLength(40)]
        public string? ACPD_Ename { get; set; }
        
        //[ACPD_Sname][nvarchar] (40) NULL,
        [StringLength(40)]
        public string? ACPD_Sname { get; set; }
        
        //[ACPD_Email][nvarchar] (60) NULL,
        [StringLength(60)]
        public string? ACPD_Email { get; set; }
        
        //[ACPD_Status][tinyint] NULL,
        public byte? ACPD_Status { get; set; }
        
        //[ACPD_Stop][bit] NULL,
        public bool? ACPD_Stop { get; set; }
        
        //[ACPD_StopMemo][nvarchar] (60) NULL,
        [StringLength(60)]
        public string? ACPD_StopMemo { get; set; }
        
        //[ACPD_LoginID][nvarchar] (30) NULL,
        [StringLength(30)]
        public string? ACPD_LoginID { get; set; }
        
        //[ACPD_LoginPWD][nvarchar] (60) NULL,
        [StringLength(60)]
        public string? ACPD_LoginPWD { get; set; }
        
        //[ACPD_Memo][nvarchar] (600) NULL,
        [StringLength(600)]
        public string? ACPD_Memo { get; set; }
        
        //[ACPD_NowDateTime][datetime] NULL,
        public DateTime? ACPD_NowDateTime { get; set; }
        
        //[ACPD_NowID][nvarchar] (20) NULL,
        [StringLength(20)]
        public string? ACPD_NowID { get; set; }
        
        //[ACPD_UPDDateTime][datetime] NULL,
        public DateTime? ACPD_UPDDateTime { get; set; }
        
        //[ACPD_UPDID][nvarchar] (20) NULL,
        [StringLength(20)]
        public string? ACPD_UPDID { get; set; }








    }
}
