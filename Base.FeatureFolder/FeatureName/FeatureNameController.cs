using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Base.FeatureFolder.Features.FeatureName
{
    [ApiController]
    [Route(Constants.RouteName)]
    public class FeatureNameController : ControllerBase
    {
        private readonly IMediator mediator;
        public FeatureNameController(IMediator mediator)
        {
            this.mediator = mediator ??
                throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet(Name = Constants.ListActionName)]
        public async Task<ActionResult<List.Result>> List(List.Query query)
        {
            var model = await mediator.Send(query);
            return this.Ok(model.Items);
        }

        [HttpGet("{reference}", Name = Constants.DetailActionName)]
        public async Task<IActionResult> Detail(Detail.Query query)
        {
            var model = await mediator.Send(query);
            return model != null ? (IActionResult)Ok(model) : (IActionResult)NotFound();
        }
    }
}
