using Microsoft.AspNetCore.Mvc;
using Service.DTO;
using Service.Interface;

namespace HE170291TranNamTruongMVC.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsArticleService _newsService;

        public NewsController(INewsArticleService newsService)
        {
            _newsService = newsService;
        }

        public async Task<IActionResult> Detail(string id)
        {
            var newsDetail = await _newsService.GetNewsDetailAsync(id);
            if (newsDetail == null)
                return NotFound();

            return View(newsDetail);
        }

        public async Task<IActionResult> GetNewsDetail(string id)
        {
            var newsArticle = await _newsService.GetNewsArticleByIdAsync(id);

            if (newsArticle == null)
            {
                return NotFound();
            }

            return PartialView("_NewsDetailPartial", newsArticle);
        }
    }
}
