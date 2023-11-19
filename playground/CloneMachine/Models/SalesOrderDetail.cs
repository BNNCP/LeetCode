public class SalesOrderDetail
{
    private Entity entity { get; set; }
    public SalesOrderDetail(Entity _entity)
    {
        this.entity = _entity
    }

    public void Execute(Entity target, string action)
    {
        Dictionary<string, Action> ActionMap = new Dictionary<string, Action>
        {
            {(string)SalesOrderDetailAction.CopyToBackup,()=>this.CopyToBackup(target)},
            {(string)SalesOrderDetailAction.CopyToOrder,()=>this.CopyToOrder(target)},
              {(string)SalesOrderDetailAction.CopyToOpportunity,()=>this.CopyToOpportunity(target)},
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

    private Entity CopyToOpportunity(Entity target)
    {
        return target;
    }
}