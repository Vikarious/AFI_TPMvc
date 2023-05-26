using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using TPLOCAL1.Models;
using System.Reflection;

//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be name with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {

        //methode "naturally" call by router
        public ActionResult Index ( string id )
        {
            if (string.IsNullOrWhiteSpace ( id ))
                //retourn to the Index view (see routing in Program.cs)
                return View ();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "ListeAvis":
                        //TODO : code reading of the xml files provided

                        OpinionList opinion = new OpinionList ();

                        var model = opinion.GetAvis ( "XlmFile/DataAvis.xml" );
                        // Provide the model to the view.
                        return View ( id, model );
                    case "Formulaire":
                        //TODO : call the Form view with data model empty
                        return View ( id );
                    default:
                        //retourn to the Index view (see routing in Program.cs)
                        return View ();
                }
            }
        }


        //methode to send datas from form to validation page
        [HttpPost]
        public ActionResult ValidationFormulaire ( FormulaireModel formulaire )
        {
            //TODO : test if model's fields are set
            //if not, display an error message and stay on the form page
            //else, call ValidationForm with the datas set by the user


            string? nom = formulaire.Name;
            string? prenom = formulaire.Firstname;
            string? sexe = formulaire.Sex;
            string? adresse = formulaire.Adress;
            int codepostal = formulaire.PostalCode;
            string? ville = formulaire.City;
            string? mail = formulaire.Mail;
            string? datedebformation = formulaire.StartFormation;
            string? typeformation = formulaire.FormationType;
            string? cobol = formulaire.Cobol;
            string? csharp = formulaire.Csharp;

            ViewData["Formulaire"] = formulaire;

            if (ModelState.IsValid)
            {
                return View ( formulaire );
            }
            return View ( "Formulaire" );
        }
    }
}