internal class OpportunityProductBackup
{
    private Entity entity { get; set; }
    public OpportunityProductBackup(Entity _entity)
    {
        this.entity = _entity;
    }

    public void Execute(Entity target, string action)
    {
        Dictionary<string, Action> ActionMap = new Dictionary<string, Action>
        {
              {(string)OpportunityProductBackupAction.CopyToOpportunity,()=>this.CopyToOpportunity(target)},
        }
        return ActionMap[action].Invoke(target);
    }

    private Entity CopyToOpportunity(Entity target)
    {
        return target;
    }
}