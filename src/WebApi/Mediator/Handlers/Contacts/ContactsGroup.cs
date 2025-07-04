using Microsoft.EntityFrameworkCore;
using SharedModels.Dtos.Contacts;
using Shiny.Mediator;
using WebApi.Data;
using WebApi.Mediator.Requests.Contacts;

namespace WebApi.Mediator.Handlers.Contacts
{
    [MediatorHttpGroup("/contacts", RequiresAuthorization = true)]
    public class ContactsGroup
        : IRequestHandler<AddContactRequest, ContactDto>,
            IRequestHandler<GetContactRequest, ContactDto?>,
            IRequestHandler<GetAllContactsRequest, IEnumerable<ContactDto>>,
            IRequestHandler<DeleteContactRequest, bool>
    {
        private readonly AppDbContext _db;

        public ContactsGroup(AppDbContext db) => _db = db;

        [MediatorHttpPost("Add", "/")]
        public async Task<ContactDto> Handle(
            AddContactRequest request,
            IMediatorContext context,
            CancellationToken ct
        )
        {
            var contact = new ContactDto(
                request.WixId,
                request.Name,
                request.Email,
                request.Phone,
                request.Branche
            )
            {
                Id = Guid.NewGuid(),
            };

            _db.Contacts.Add(contact);
            await _db.SaveChangesAsync(ct);
            return contact;
        }

        [MediatorHttpGet("Get", "/{Id:guid}")]
        public async Task<ContactDto?> Handle(
            GetContactRequest request,
            IMediatorContext context,
            CancellationToken ct
        )
        {
            return await _db.Contacts.FirstOrDefaultAsync(x => x.Id == request.Id, ct);
        }

        [MediatorHttpGet("GetAll", "/")]
        public async Task<IEnumerable<ContactDto>> Handle(
            GetAllContactsRequest request,
            IMediatorContext context,
            CancellationToken ct
        )
        {
            return await _db.Contacts.ToListAsync(ct);
        }

        [MediatorHttpDelete("Delete", "/{Id:guid}")]
        public async Task<bool> Handle(
            DeleteContactRequest request,
            IMediatorContext context,
            CancellationToken ct
        )
        {
            var entity = await _db.Contacts.FirstOrDefaultAsync(x => x.Id == request.Id, ct);
            if (entity != null)
            {
                _db.Contacts.Remove(entity);
                await _db.SaveChangesAsync(ct);
                return true!;
            }
            else
            {
                return false;
            }
        }
    }
}
