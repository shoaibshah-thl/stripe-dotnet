namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class SourceTransactionService : ServiceNested<SourceTransaction>,
        INestedListable<SourceTransaction, SourceTransactionsListOptions>
    {
        public SourceTransactionService()
            : base(null)
        {
        }

        public SourceTransactionService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/sources/{PARENT_ID}/source_transactions";

        public virtual StripeList<SourceTransaction> List(string sourceId, SourceTransactionsListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(sourceId, options, requestOptions);
        }

        public virtual Task<StripeList<SourceTransaction>> ListAsync(string sourceId, SourceTransactionsListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListNestedEntitiesAsync(sourceId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SourceTransaction> ListAutoPaging(string sourceId, SourceTransactionsListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(sourceId, options, requestOptions);
        }
    }
}
