using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Base.Api.Features.SampleResource
{
    public class List
    {

        public class Query : IRequest<Result>
        {
        }

        public class Result
        {

            public IEnumerable<SampleResource> Items { get; set; }

            public class SampleResource
            {
                public string Name { get; set; }
            }

            public Result()
            {
                this.Items = new List<SampleResource>();
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
