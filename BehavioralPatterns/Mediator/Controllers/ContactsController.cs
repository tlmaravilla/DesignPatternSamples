using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediator.Data;
using Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private IMediator mediator;

        // Expression body constructor
        public ContactsController(IMediator mediator) => this.mediator = mediator;


        [HttpGet("{id}")]
        public async Task<Contact> GetContact([FromRoute]ContactsQuery contactsQuery) => await mediator.Send(contactsQuery);
    }
}
