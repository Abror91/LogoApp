using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestApp.DAL.Entities;
using TestApp.DAL.Interfaces;
using TestApp.UI.Models;

namespace TestApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _db;
        public HomeController()
        {

        }
        public HomeController(IUnitOfWork db)
        {
            _db = db;
        }

        public async Task<ActionResult> Logos(int? categoryId, int? tagId, string searchString)
        {
            var logos = await GetLogos(categoryId, tagId, searchString);
            await PopulateCategoriesData();
            await PopulateTagByCategory(categoryId);
            return View(logos);
        }

        public async Task<ActionResult> Details(int? logoId)
        {
            var i = await _db.Logos.GetLogo(logoId);
            var logo = new LogoViewModel
            {
                Id = i.Id,
                CompanyName = i.CompanyName,
                CategoryId = i.CategoryId,
                ImagePath = i.ImagePath
            };
            logo.Category = new CategoryViewModel
            {
                Id = i.Category.Id,
                Name = i.Category.Name
            };
            foreach(var item in i.Tags)
            {
                var tag = new TagViewModel { Id = item.Id, Name = item.Name };
                logo.Tags.Add(tag);
            }
            return View(logo);
        }
        

        public ActionResult Download(string imagePath, string format, string companyName)
        {
            Response.AddHeader("Content-Disposition", "attachment;filename=" + companyName + format);
            Response.WriteFile(imagePath);
            Response.End();
            return null;
        }

        public async Task<IEnumerable<LogoViewModel>> GetLogos(int? categoryId, int? tagId, string searchString)
        {
            var items = await _db.Logos.GetLogos(categoryId, tagId, searchString);
            var logos = new List<LogoViewModel>();
            foreach (var i in items)
            {
                var logo = new LogoViewModel
                {
                    Id = i.Id,
                    CompanyName = i.CompanyName,
                    CategoryId = i.CategoryId,
                    ImagePath = i.ImagePath
                };
                logo.Category = new CategoryViewModel
                {
                    Id = i.Category.Id,
                    Name = i.Category.Name
                };
                logos.Add(logo);
            }
            return logos;
        }

        private async Task PopulateCategoriesData()
        {
            var items = await _db.Categories.GetCategories();
            var mapper = new MapperConfiguration(c => c.CreateMap<Category, CategoryViewModel>()).CreateMapper();
            ViewBag.Categories = mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(items);
        }

        private async Task PopulateTagByCategory(int? categoryId)
        {
            if (categoryId == null)
                return;
            var items = await _db.Tags.GetTagsByCategory(categoryId);
            var mapper = new MapperConfiguration(c => c.CreateMap<Tag, TagViewModel>()).CreateMapper();
            ViewBag.Tags = mapper.Map<IEnumerable<Tag>, IEnumerable<TagViewModel>>(items);
        }
    }
}
