namespace PoCGantt.Models.Gantt
{
  public class Dependency
  {
    public int ID { get; set; }
    public int PredecessorId { get; set; }
    public int SuccessorId { get; set; }
    public int Type { get; set; }
  }
}
