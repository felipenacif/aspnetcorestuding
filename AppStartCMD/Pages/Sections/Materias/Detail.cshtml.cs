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
    public class DetailModel : PageModel
    {
        private readonly IMateriaData materiaData;

        public Materia Materia { get; set; }

        [TempData]
        public string Mensagem { get; set; }

        public DetailModel(IMateriaData materiaData)
        {
            this.materiaData = materiaData;
        }

        public void OnGet(int materiaId)
        {
            Materia = materiaData.GetById(materiaId);
        }
    }
}