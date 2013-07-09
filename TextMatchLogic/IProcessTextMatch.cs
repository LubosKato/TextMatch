namespace TextMatchLogic
{
    public interface IProcessTextMatch
    {
        string MainText { get; set; }
        string SubText { get; set; }
        string Process();
    }
}