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
    public class DeleteModel : PageModel
    {
        private readonly IMateriaData materiaData;

        [BindProperty]
        public Materia Materia { get; set; }

        public DeleteModel(IMateriaData materiaData)
        {
            this.materiaData = materiaData;
        }

        public void OnGet(int materiaId)
        {
            Materia = materiaData.GetById(materiaId);
        }

        public IActionResult OnPost()
        {
            if (Materia.Id > 0)
                materiaData.Delete(Materia.Id);

            materiaData.Commit();

            TempData["Mensagem"] = "Matéria excluida com sucesso!";

            return RedirectToPage("./Index");
        }
    }
}