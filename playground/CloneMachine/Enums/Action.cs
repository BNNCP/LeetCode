public enum OpportunityAction
{
    CopyToOrder = "salesorder",
    CopyTpQuote = "quote",
}

public enum QuoteAction
{
    CopyToOpporunity = "opportunity",
    CopyToOrder = "salesorder",
}

public enum SalesOrderAction
{
    CopyToOpportunity = "opportunity",
    CopyToQuote = "quote",
}


public enum OpportunityProductAction
{
    CopyToBackup = "twtoto_opportunityproduct_backup",
    CopyToOrder = "salesorderdetail",
    CopyTpQuote = "quotedetail",
}

public enum QuoteDetailAction
{
    CopyToBackup = "twtoto_quotedetail_backup",
    CopyToOpporunity = "opportunityproduct",
    CopyToOrder = "salesorderdetail",
}

public enum SalesOrderDetailAction
{
    CopyToBackup = "twtoto_salesorderdetail_backup",
    CopyToOpportunity = "opportunityproduct",
    CopyToQuote = "quotedetail",
}

public enum OpportunityProductBackupAction
{
    CopyToOpportunity = "opportunityproduct",
}

public enum SalesOrderDetailBackupAction
{
    CopyToOrder = "salesordedetail",
}