using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mediator.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Mediator.Queries
{
    public class ContactsQuery : IRequest<Contact>
    {
        // This of this as an input message
        public int Id { get; set; }
    }

    public class ContactsHandler : IRequestHandler<ContactsQuery, Contact>
    {
        private readonly ContactsContext _dbContext;

        public ContactsHandler(ContactsContext dbContext) => _dbContext = dbContext;

        public Task<Contact> Handle(ContactsQuery request, CancellationToken cancellationToken)
        {
            return _dbContext.Contacts.Where(c => c.Id == request.Id).SingleOrDefaultAsync(cancellationToken);
        }
    }
}
