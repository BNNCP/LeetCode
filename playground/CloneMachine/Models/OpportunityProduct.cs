internal class OpportunityProduct
{
    private Entity entity { get; set; }
    public OpportunityProduct(Entity _entity)
    {
        this.entity = _entity;
    }

    public void Execute(Entity target, string action)
    {
        Dictionary<string, Action> ActionMap = new Dictionary<string, Action>
        {
            {(string)OpportunityProductAction.CopyToBackup,()=>this.CopyToBackup(target)},
            {(string)OpportunityProductAction.CopyToOrder,()=>this.CopyToOrder(target)},
              {(string)OpportunityProductAction.CopyToQuote,()=>this.CopyToQuote(target)},
        }
        return ActionMap[action].Invoke(target);
    }

    private Entity CopyToBackup(Entity target)
    {
        return target;
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