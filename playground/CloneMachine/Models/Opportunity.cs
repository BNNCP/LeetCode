internal class Opportunity
{
    private Entity entity { get; set; }
    public Opportunity(Entity _entity)
    {
        this.entity = _entity;
    }

    public void Execute(Entity target, string action)
    {
        Dictionary<string, Action> ActionMap = new Dictionary<string, Action>
        {
            {(string)OpportunityAction.CopyToOrder,()=>this.CopyToOrder(target)},
              {(string)OpportunityAction.CopyToQuote,()=>this.CopyToQuote(target)},
        }
        return ActionMap[action].Invoke(target);
    }

    private Entity CopyToOrder(Entity target)
    {
        return target;
    }

    private Entity CopyToQuote(Entity target)
    {
        return target;
    }
}