using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppStartCMD.Core;
using AppStartCMD.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AppStartCMD.Pages.Sections.Materias
{
    public class IndexModel : PageModel
    {
        public string SubTituloTela { get; set; }
        public IEnumerable<Materia> Materias { get; set; }


        private readonly IMateriaData materiaData;
        private readonly ILogger<IndexModel> logger;

        [TempData]
        public string Mensagem { get; set; }


        public IndexModel(IMateriaData materiaData, ILogger<IndexModel> logger)
        {
            this.materiaData = materiaData;
            this.logger = logger;
        }


        public void OnGet()
        {
            logger.LogError("Erro de teste");

            SubTituloTela = "Exibe todas as matérias cadastradas";
            Materias = materiaData.GetAll();
        }

    }
}