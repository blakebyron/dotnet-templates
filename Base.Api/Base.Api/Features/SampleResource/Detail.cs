using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Base.Api.Features.SampleResource
{
    public class Detail
    {
        public class Query : IRequest<Result>
        {
            public string ID { get; set; }
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
