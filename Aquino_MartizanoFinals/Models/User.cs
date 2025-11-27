using System.ComponentModel.DataAnnotations;

namespace Aquino_MartizanoFinals.Models
{
    public class User
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public AttendanceStatus Week1 { get; set; }
        public AttendanceStatus Week2 { get; set; }
        public AttendanceStatus Week3 { get; set; }

    }
    //attendance status
    public enum AttendanceStatus
    {
        Present,
        Excused,
        Absent,
        None
    }

}
