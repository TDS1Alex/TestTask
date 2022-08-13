using System;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using System.Collections.Generic;

using TestTask.App.Command;
using TestTask.App.Query;
using TestTask.App.Dtos;
using TestTask.App.Command.StatementHCS;
using TestTask.App.Command.StatementSP;
using TestTask.App.Query.StatementHCS;

namespace TestTask.Controllers
{
    [Route("test/")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class TestTaskController: ControllerBase
    {
        private readonly IMediator _mediator;
        public TestTaskController(IMediator mediator) => _mediator = mediator;

        [HttpPost("addSP")]
        public async Task<Result> Add([FromBody] AddStatementSPCommand query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost("addHCS")]
        public async Task<Result> Add([FromBody] AddStatementHCSCommand query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost("listHCS")]
        public async Task<ListDto<ApplicantDto>> List([FromBody] StatementHCSListQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost("listSP")]
        public async Task<ListDto<ApplicantDto>> List([FromBody] StatementSPListQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost("getSP")]
        public async Task<ApplicantDto> Get([FromBody] StatementSPQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost("getHCS")]
        public async Task<ApplicantDto> Get([FromBody] StatementHCSQuery query)
        {
            return await _mediator.Send(query);
        }
    }
}
