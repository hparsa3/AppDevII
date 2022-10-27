using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using  MyFriends.Data;
using MyFriends.Models;

namespace MyFriends.Pages
{
    public class DeleteModel : PageModel
    {
       private readonly FriendContext db;
        public DeleteModel(FriendContext db) => this.db = db;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty]
        public Friend Friend { get; set; }


        public void OnGet()
        {
            Friend = db.Friends.Find(Id);
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var FriendFromDB = await db.Friends.FindAsync(Id);
            db.Friends.Remove(FriendFromDB);
            await db.SaveChangesAsync();

            return RedirectToPage("/DeleteSuccess");
        }
    }
}
