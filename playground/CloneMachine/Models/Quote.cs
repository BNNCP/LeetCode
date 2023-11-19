using System.Collections.Generic;
internal class Quote
{
    private Entity entity { get; set; }
    public Quote(Entity _entity)
    {
        this.entity = _entity;
    }

    public void Execute(Entity target, string action)
    {
        Dictionary<string, Action> ActionMap = new Dictionary<string, Action>
        {
            {(string)QuoteAction.CopyToQuote,()=>this.CopyToQuote(target)},
              {(string)QuoteAction.CopyToOpportunity,()=>this.CopyToOpportunity(target)},
        }
        return ActionMap[action].Invoke(target);
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