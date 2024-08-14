using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CodeFirst.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IRepository<Movie> _repository;

        public MovieController()
        {
            _repository = new Repository<Movie>(new ApplicationDbContext());
        }

        // GET: Movie
        public ActionResult Index()
        {
            var movies = _repository.GetAll();
            return View(movies);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(movie);
                _repository.Save();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            var movie = _repository.GetById(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movie/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(movie);
                _repository.Save();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            var movie = _repository.GetById(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _repository.Delete(id);
            _repository.Save();
            return RedirectToAction("Index");
        }

        // GET: Movie/ReleasedInYear/2020
        public ActionResult ReleasedInYear(int year)
        {
            var movies = _repository.GetAll()
                        .Where(m => m.DateofRelease.Year == year)
                        .ToList();
            return View(movies);
        }
    }
}