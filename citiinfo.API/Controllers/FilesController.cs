using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace citiinfo.API.Controllers{

    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _contentTypeProvider;

        public FilesController(FileExtensionContentTypeProvider contentTypeProvider)
        {
            _contentTypeProvider = contentTypeProvider ?? throw new System.ArgumentNullException(nameof(contentTypeProvider));
        }

        [HttpGet("{fileId}")]
        public ActionResult GetFiles(int fileId)
        {
            // return File();
            var pathToFile = "declaraciq_cl19_kolichestvo.pdf";
            if (!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }

            if (!_contentTypeProvider.TryGetContentType(pathToFile, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var file = System.IO.File.ReadAllBytes(pathToFile);
            return File(file, contentType, Path.GetFileName(pathToFile));

        }
    }
}