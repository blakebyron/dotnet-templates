using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Base.FeatureFolder.Features.FeatureName
{
    public class List
    {

        public class Query : IRequest<Result>
        {
        }

        public class Result
        {

            public IEnumerable<FeatureName> Items { get; set; }

            public class FeatureName
            {
                public string Name { get; set; }
            }

            public Result()
            {
                this.Items = new List<FeatureName>();
            }
        }

        public class QueryHandler : IRequestHandler<Query, Result>
        {

            public QueryHandler()
            {
            }
            public Task<Result> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = new Result();
                return Task.FromResult<Result>(result);
            }
        }
    }
}
