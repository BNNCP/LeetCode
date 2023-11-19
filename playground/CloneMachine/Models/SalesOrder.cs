public class SalesOrder
{
    private Entity entity { get; set; }
    public SalesOrder(Entity _entity)
    {
        this.entity = _entity
    }

    public void Execute(Entity target, string action)
    {
        Dictionary<string, Action> ActionMap = new Dictionary<string, Action>
        {
            {(string)SalesOrderAction.CopyToOrder,()=>this.CopyToOrder(target)},
              {(string)SalesOrderAction.CopyToOpportunity,()=>this.CopyToOpportunity(target)},
        }
        return ActionMap[action].Invoke(target);
    }

    private Entity CopyToOrder(Entity target)
    {
        return target;
    }

    private Entity CopyToOpportunity(Entity target)
    {
        return target;
    }
}