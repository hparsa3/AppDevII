using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyFriends.Models;
using MyFriends.Data;

namespace MyFriends.Pages
{
 public class IndexModel : PageModel
    {
        private readonly FriendContext db;  
        public IndexModel(FriendContext db) => this.db = db;
        public List<Friend> Friends { get; set; } = new List<Friend>();  
      /*  public Friend FeaturedFriend { get; set; }  */
        public async Task OnGetAsync()
        {
            Friends = await db.Friends.ToListAsync();
           /* FeaturedFriend = Friends.ElementAt(new Random().Next(Friends.Count));*/
        }
    }
}