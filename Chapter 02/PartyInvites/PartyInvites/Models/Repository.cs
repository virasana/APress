using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static Dictionary<string, GuestResponse> responses;
        public Repository()
        {
            responses = new Dictionary<string, GuestResponse>()
            {
                ["Bob"] = { Name = "Bob", Email = "bob@bob.com", Phone = "123-456", WillAttend = false },
                ["Alice"] = { Name = "Bob", Email = "alice@alice.com", Phone = "456-789", WillAttend = true },
                ["Paul"] = { Name = "Bob", Email = "paul@paul.com", Phone = "789-101", WillAttend = false }
            };
        }

        public static void Add(GuestResponse newResponse)
        {
            if (responses.ContainsKey(newResponse.Name.ToLowerInvariant()))
            {
                responses[newResponse.Name] = newResponse;
            }
            else
            {
                responses.Add(newResponse.Name, newResponse);
            }
        }
        public static IEnumerable<GuestResponse> Responses
        {
            get { return responses.Values; }
        }
    }
}
