using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppStartCMD.Core;
using AppStartCMD.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppStartCMD.Pages.Sections.Materias
{
    public class EditModel : PageModel
    {
        private readonly IMateriaData materiaData;

        [BindProperty]
        public Materia Materia { get; set; }

        public EditModel(IMateriaData materiaData)
        {
            this.materiaData = materiaData;
        }

        public void OnGet(int? materiaId)
        {
            if (materiaId.HasValue)
                Materia = materiaData.GetById((int)materiaId);
            else
                Materia = new Materia();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if(Materia.Id > 0)
                    materiaData.Update(Materia);
                else
                    materiaData.Insert(Materia);

                materiaData.Commit();

                TempData["Mensagem"] = "Matéria salva com sucesso!";

                return RedirectToPage("./Detail", new { materiaId = Materia.Id });
            }

            return Page();
        }
    }
}