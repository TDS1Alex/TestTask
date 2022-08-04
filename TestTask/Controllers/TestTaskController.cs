using System;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;

using TestTask.App.Command;
using TestTask.App.Query;
using TestTask.App.Dtos;
using TestTask.App.Command.StatementHCS;
using TestTask.App.Command.StatementSP;

namespace TestTask.Controllers
{
    [Route("test/")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class TestTaskController: ControllerBase
    {
        private readonly IMediator _mediator;
        public TestTaskController(IMediator mediator) => _mediator = mediator;

        [HttpPost("add")]
        public async Task<Result> Add([FromBody] AddStatementSPCommand query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost("add")]
        public async Task<Result> Add([FromBody] AddStatementHCSCommand query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost("list")]
        public async Task<ListDto<ApplicantDto>> List([FromBody] StatementListQuery query)
        {
            return await _mediator.Send(query);
        }
    }
}
