using AppStartCMD.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppStartCMD.Pages.ViewComponents
{
    public class MateriaCountViewComponent : ViewComponent
    {
        private readonly IMateriaData materiaData;

        public MateriaCountViewComponent(IMateriaData materiaData)
        {
            this.materiaData = materiaData;
        }

        public IViewComponentResult Invoke()
        {
            var count = materiaData.GetCount();
            return View(count);
        }
    }
}
