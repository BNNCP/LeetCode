using System.Collections.Generic;
internal class QuoteDetail
{
    private Entity entity { get; set; }
    public QuoteDetail(Entity _entity)
    {
        this.entity = _entity;
    }

    public void Execute(Entity target, string action)
    {
        Dictionary<string, Action> ActionMap = new Dictionary<string, Action>
        {
            {(string)QuoteDetailAction.CopyToBackup,()=>this.CopyToBackup(target)},
            {(string)QuoteDetailAction.CopyToQuote,()=>this.CopyToQuote(target)},
            {(string)QuoteDetailAction.CopyToOpportunity,()=>this.CopyToOpportunity(target)},
        }
        return ActionMap[action].Invoke(target);
    }

    private Entity CopyToBackup(Entity target)
    {
        return target;
    }

    private Entity CopyToQuote(Entity target)
    {
        return target;
    }

    private Entity CopyToOpportunity(Entity target)
    {
        return target;
    }
}