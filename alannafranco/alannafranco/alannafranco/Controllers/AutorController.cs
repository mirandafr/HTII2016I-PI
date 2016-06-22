using System.Linq;
using System.Web.Mvc;
using alannafranco.Models;
using System.Net;
using System.Data.Entity;


namespace alannafranco.Controllers
{
    public class AutorController : Controller
    {
        private AppContext db = new AppContext();

        // GET: Autor
        public ActionResult Index()
        {
            return View(db.Autores.ToList());
        }

        //GET: Autor/Insert
        public ActionResult Insert()
        {
            return View();
        }

        //POST: Autor/Insert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert([Bind(Include = "Id,Nome")] Autor autor)
        {
            if (ModelState.IsValid)
            {
                db.Autores.Add(autor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(autor);
        }

        //GET: Autor/Update/<id>
        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autor autor = db.Autores.Find(id);
            if (autor == null)
            {
                return HttpNotFound();
            }
            return View(autor);
        }

        //POST: Autor/Update/<id>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update([Bind(Include = "Id,Nome")] Autor autor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(autor);
        }

        //GET: Autor/Delete/<id>
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autor autor = db.Autores.Find(id);
            if (autor == null)
            {
                return HttpNotFound();
            }
            return View(autor);
        }

        //POST:Autor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Autor autor = db.Autores.Find(id);
            db.Autores.Remove(autor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }

} 