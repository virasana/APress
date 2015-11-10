using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PartyInvites.Controllesr
{
    public class RsvpController : ApiController
    {
        public IEnumerable<GuestResponse> ListAttendees()
        {
            return Repository.Responses.Where(x => x.WillAttend == true);
        }
    }
}
