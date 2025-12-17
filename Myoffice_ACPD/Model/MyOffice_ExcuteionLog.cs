using System.ComponentModel.DataAnnotations;

namespace Myoffice_ACPD.Model
{
    public class MyOffice_ExcuteionLog
    {
        //[DeLog_AutoID] [bigint] IDENTITY(1,1) NOT NULL,
        [Key]
        public long DeLog_AutoID { get; set; }
        //[DeLog_DocID] [uniqueidentifier] NOT NULL,
        public Guid DeLog_DocID { get; set; }
        //[DeLog_StoredPrograms] [nvarchar](120) NOT NULL,
        [StringLength(120)]
        public string DeLog_StoredPrograms { get; set; }
        //[DeLog_GroupID] [uniqueidentifier] NOT NULL,
        public Guid DeLog_GroupID { get; set; }
        //[DeLog_isCustomDebug] [bit] NOT NULL,
        public bool DeLog_isCustomDebug { get; set; }

        //[DeLog_ExecutionProgram] [nvarchar](120) NOT NULL,
        [StringLength(120)]
        public string DeLog_ExecutionProgram { get; set; }
        //[DeLog_ExecutionInfo] [nvarchar](max) NULL,
        public string? DeLog_ExecutionInfo { get; set; }
        //[DeLog_verifyNeeded] [bit] NULL,
        public bool? DeLog_verifyNeeded { get; set; }
        //[DeLog_ExDateTime] [datetime] NOT NULL,
        public DateTime DeLog_ExDateTime { get; set; }




    }
}
