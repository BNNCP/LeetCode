using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.Crm.Sdk;
public class CloneMachine
{
    public Dictionary<Guid, Guid> clonedRecrods = new Dictionary<Guid, Guid>
    //Collection sort by parentbundleid == null
    //if not, use two point swap with the last(nth) entity
    public Entity cloneStart(EntityCollection collection, string targetEntityName)
    {
        int index = 0;
        int endPointer = collection.entities.length - 1;
        while (index < collection.entities.length)
        {
            //clone the other field
            //need to specify which entity to clone
            Entity target = new Entity(targetEntityName);
            if (collection.entities[index].Contains("parentbundleid"))
            {
                EntityRefference parentref = collection.entities[index].GetAttributeValue<EntityRefference>("parentbundleid");
                if (clonedRecrods.ContainsKey(parentref.Id))
                {
                    target["parentbundleid"] = new EntityRefference(targetEntityName, clonedRecrods[parentref.Id]);
                }
                else
                {
                    Entity tempContainer = collection.entities[index];
                    collection.entities[index] = collection.entities[endPointer];
                    collection.entities[endPointer] = tempContainer;
                    endPointer--;
                    continue;
                }
            }

            switch (collection.entities[index].Logicalname)
            {
                case "quote":
                    Quote quote = new Quote(collection.entities[index]);
                    target = quote.Execute(target, targetEntityName);
                    break;
                case "opportunity":
                    Opportunity opportunity = new Opportunity(collection.entities[index]);
                    target = opportunity.Execute(target, targetEntityName);
                    break;
                case "salesorder":
                    SalesOrder salesOrder = new SalesOrder(collection.entities[index]);
                    target = salesOrder.Execute(target, targetEntityName);
                    break;
                case "quotedetail":
                    QuoteDetail quoteDetail = new QuoteDetail(collection.entities[index]);
                    target = quoteDetail.Execute(target, targetEntityName);
                    break;
                case "opportunityproduct":
                    OpportunityProduct opportunityProduct = new OpportunityProduct(collection.entities[index]);
                    target = opportunityProduct.Execute(target, targetEntityName);
                    break;
                case "salesorderdetail":
                    SalesOrderDetail salesOrderDetail = new SalesOrderDetail(collection.entities[index]);
                    target = salesOrderDetail.Execute(target, targetEntityName);
                    break;
                case "twtoto_opportunityproduct_backup":
                    OpportunityProductBackup opportunityProductBackup = new OpportunityProductBackup(enticollection.entities[index]);
                    target = opportunityProductBackup.Execute(target, targetEntityName);
                    break;
                case "twtoto_salesorderdetail_backup":
                    SalesOrderDetailBackup salesOrderDetailBackup = new SalesOrderDetailBackup(collection.entities[index]);
                    target = salesOrderDetailBackup.Execute(target, targetEntityName);
                    break;
            }
            Guid targetId = service.create(target);
            clonedRecrods.Add(collection.entities[index].Id, targetId);
            index++;
        }
    }
}

