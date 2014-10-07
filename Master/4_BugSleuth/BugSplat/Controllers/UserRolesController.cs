using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using BugSleuth.Models;

namespace BugSleuth.Controllers
{
    public class UserRolesController : Controller
    {
        // create two private member variables for this controller class (you will need these throughout the controllers here):
        //      1) a connection to the AspNet tables (this is represented by the ApplicationDbContext object)
        //      2) a connection to your BugTracker tables (represented by the BugTrackerEntities object, unless you called it something different)
        private ApplicationDbContext AspDb = new ApplicationDbContext();
        private BugSleuthEntities BtDb = new BugSleuthEntities();
        
        // GET: AssignUsers
        [Authorize(Roles = "Administrator")]
        public ActionResult AssignUsers(string id)
        {
            // 1) locate the role in the DB (you have the id of the role right here)
            
            // 2) instantiate the view model
            
            // 3) add the role ID and Name to the model
            
            // 4) instantiate the user list that is part of the view model
            
            // 5) loop through all of the system users (in the AspNetUsers table) and, as long as the user is NOT already in the role,
            //      add the corresponding BTUser to the list (you'll need to find the user in the BTUsers table)
            
            
            // 6) instantiate the MultiSelectList object (in the model) using the newly built list
            //      with appropriate value and display parameters (HINT: see whiteboard!)
            
            // 7) send the model to the view
            
        }

        // POST: AssignUsers
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ValidateAntiForgeryToken]
        public ActionResult AssignUsers(UserRolesViewModel model)
        {
            // check the model state - if it's valid, continue, if not, return the view with the current model (see last comment)

                // check the SelectedUsers attribute of the model - if it's NOT null, continue
                
                    // loop through the elements in model.SelectedUsers (they should be AspNetUserId's) - for each one in the array, 
                    //      1) locate the user in the AspNetUser table, 
                    //      2) add the user to the role specified in the model
                    //      3) if the user is already in the "Unassigned" role, remove him/her from that role
                    



                    // redirect to the roles list
                    
                }
            }
            // if we got here, there's a problem - return the view with the model
            
        }

        // GET: UsersInRole
        [Authorize(Roles = "Administrator")]
        public ActionResult UsersInRole(string id)
        {
            // 1) locate the role in the DB (you have the id of the role right here)
            
            // 2) instantiate the view model
            // 3) add the role ID and Name to the model
            

            // 4) instantiate the user list that is part of the view model
            
            // 5) loop through all of the system users (in the AspNetUsers table), and if the user is in the role,
            //      add the corresponding BTUser to the list (you'll need to find the user in the BTUsers table)
            



            // 6) instantiate the MultiSelectList object (in the model) using Allison's newly built list
            //      with appropriate value and display parameters 
            
            // 7) send the model to the view
            
        }


        // POST: UsersInRole
        [HttpPost]
        [Authorize(Roles="Administrator")]
        [ValidateAntiForgeryToken]
        public ActionResult UsersInRole(UserRolesViewModel model)
        {
            // check the model state - if it's valid, continue, if not, return the view with the current model (see last comment)
            
                // check the SelectedUsers attribute of the model - if it's NOT null, continue
                
                    // loop through the elements in model.SelectedUsers (they should be AspNetUserId's) - for each one in the array, 
                    //      1) locate the user in the AspNetUser table, 
                    //      2) remove the user from the role specified in the model
                    //      3) check the number of roles the user is assigned to (user.Roles.Count) - if it is zero, add the user to the "Unassigned" role
                    
                    // redirect to the roles list
                    return RedirectToAction("Index", "Roles");
                }
            }
            // if we got here, there's a problem - return the view with the model
            return View(model);
        }
    }
}