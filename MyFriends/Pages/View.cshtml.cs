using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFriends.Data;
using MyFriends.Models;

namespace MyFriends.Pages
{
    public class ViewModel : PageModel
    {
         private readonly FriendContext db;
        public ViewModel(FriendContext db) => this.db = db;

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
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // FIX IT: InvalidOperationException: The property 'Friend.Id' has a temporary value 
            // db.Attach(Friend).State = EntityState.Modified;
            var FriendFromDB = db.Friends.FirstOrDefault(x => x.ID == Id);
            FriendFromDB.Name = Friend.Name;
            FriendFromDB.Age = Friend.Age;
            await db.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
