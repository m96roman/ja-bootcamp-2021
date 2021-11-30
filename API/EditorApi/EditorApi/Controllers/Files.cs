using Editor.dll;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EditorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Files : ControllerBase
    {
        private readonly ILogger<Files> _logger;

        public Files(ILogger<Files> logger)
        {
            _logger = logger;
        }


        [HttpPut]
        [Route("/Files/{id}")]
        public void CopyFile(string id, [FromBody] string text)
        {
            EdtitorApi editor = new EdtitorApi();

            editor.CopyFile(id, text);
        }


        [HttpGet]
        [Route("/Files")]
        public IActionResult GetFileNames()
        {
            EdtitorApi editor = new EdtitorApi();

            string[] res = editor.GetFileNamesInStorage();

            return new JsonResult(res);
        }



        [HttpPost("/Files/{id}")]
        public int ReplacesCount(string id, string searchText, string replaceText)
        {
            EdtitorApi editor = new EdtitorApi();

            int res = editor.FindAndReplace(id, searchText, replaceText);

            return res;
        }


        [HttpGet]
        [Route("/Files/{id}")]
        public string GetParagraphs(string id, string searchText)
        {
            EdtitorApi editor = new EdtitorApi();

            string[] res = editor.SearchParagraphs(id, searchText);

            string parafraphs = JsonSerializer.Serialize(res);

            return parafraphs;
        }
    }
}
