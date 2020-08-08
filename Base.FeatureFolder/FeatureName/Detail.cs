using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Base.FeatureFolder.Features.FeatureName
{
    public class Detail
    {
        public class Query : IRequest<Result>
        {
            public string Reference { get; set; }
        }

        public class Result
        {
            public string Name { get; set; }
        }

        public class QueryHandler : IRequestHandler<Query, Result>
        {
            public QueryHandler()
            {

            }

            public Task<Result> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = new Result();
                return Task.FromResult(result);
            }
        }
    }
}
