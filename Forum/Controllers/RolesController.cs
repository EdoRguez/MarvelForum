using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Forum.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RolesController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RolesController(RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // GET: Roles
        public async Task<IActionResult> Index()
        {
            return View(await _roleManager.Roles.ToListAsync());
        }

        // GET: Roles/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationRole = await _roleManager.FindByIdAsync(id); //_context.ApplicationRole.FirstOrDefaultAsync(m => m.Id == id);
            if (applicationRole == null)
            {
                return NotFound();
            }

            return View(applicationRole);
        }

        // GET: Roles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Name")] RoleVM roleVM) // ,CreatedDate,Id,NormalizedName,ConcurrencyStamp
        {
            ApplicationRole applicationRole = new ApplicationRole();

            if (ModelState.IsValid)
            {
                applicationRole.Name = roleVM.Name;
                applicationRole.Description = roleVM.Description;
                applicationRole.CreatedDate = DateTime.Now;
                var result = await _roleManager.CreateAsync(applicationRole);
                if(result.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(roleVM);
        }

        // GET: Roles/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationRole = await _roleManager.FindByIdAsync(id); //_context.ApplicationRole.FindAsync(id);
            if (applicationRole == null)
            {
                return NotFound();
            }

            RoleVM roleVM = new RoleVM() { Id = id, Name = applicationRole.Name, Description = applicationRole.Description };

            return View(roleVM);
        }

        // POST: Roles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Description,Name")] RoleVM roleVM) // CreatedDate,Id,NormalizedName,ConcurrencyStamp
        {
            ApplicationRole applicationRole = await _roleManager.FindByIdAsync(id);

            if (applicationRole == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    applicationRole.Name = roleVM.Name;
                    applicationRole.Description = roleVM.Description;
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (await _roleManager.RoleExistsAsync(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(roleVM);
        }

        // GET: Roles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationRole = await _roleManager.FindByIdAsync(id);
            if (applicationRole == null)
            {
                return NotFound();
            }

            return View(applicationRole);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var applicationRole = await _roleManager.FindByIdAsync(id);
            await _roleManager.DeleteAsync(applicationRole);
            return RedirectToAction(nameof(Index));
        }

        private Task<bool> ApplicationRoleExists(string id)
        {
            return _roleManager.RoleExistsAsync(id);
        }

        public async Task<IActionResult> AddUserRole()
        {
            ViewBag.RolesList = await _roleManager.Roles.ToListAsync();

            return View();
        }

        // POST: Roles/AddUserRole/Name
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUserRole(string email, string role)
        {
            if(email == null)
            {
                return View();
            }

            bool roleExist = await _roleManager.RoleExistsAsync(role);
            if(!roleExist)
            {
                return View();
            }

            ApplicationUser user = await _userManager.FindByEmailAsync(email);
            if(user == null)
            {
                return View();
            }

            await _userManager.AddToRoleAsync(user, role);

            return RedirectToAction(nameof(Index));
        }
    }
}
