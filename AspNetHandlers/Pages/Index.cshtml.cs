using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AspNetHandlers.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
        }

        public string Messsage { get; private set; }

        public void OnGetCreate(int id)
        {
            Messsage = $"Create GET Fired with Id '{id}'";
        }
        public void OnPostCreate(int id)
        {
            Messsage = $"Create POST Fired with Id '{id}'";
        }

        public void OnGetRetrieve(int id)
        {
            Messsage = $"Retrieve GET Fired with Id '{id}'";
        }
        public void OnPostRetrieve(int id)
        {
            Messsage = $"Retrieve POST Fired with Id '{id}'";
        }

        public void OnGetEdit(int id)
        {
            Messsage = $"Edit GET Fired with Id '{id}'";
        }
        public void OnPostEdit(int id)
        {
            Messsage = $"Edit POST Fired with Id '{id}'";
        }
        public void OnGetDelete(int id)
        {
            Messsage = $"Delete GET Fired with Id '{id}'";
        }

        public void OnPostDelete(int id)
        {
            Messsage = $"Delete POST Fired with Id '{id}'";
        }
        public void OnGetList()
        {
            Messsage = $"List GET Fired";
        }
        public void OnPostList()
        {
            Messsage = $"List POST Fired";
        }
    }
}
