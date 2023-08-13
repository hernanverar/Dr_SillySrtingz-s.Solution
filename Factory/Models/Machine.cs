using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Add Machine This field can't be empty!")]
    public string Designation { get; set; }
    public List<EngineerMachine> JoinEntities { get; set; }
  }
}