using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_entity.Models;

namespace mvc_entity.Controllers
{
    public class MonsterController : Controller
    {
        // GET: Monster
        public ActionResult Index()
        {
            List<monster> monsterList = new List<monster>();
            using (PokemonModels pokemonModel = new PokemonModels())
            {
                monsterList = pokemonModel.monsters.ToList<monster>();
            }
            return View(monsterList);
        }

        // GET: Monster/Details/5
        public ActionResult Details(int id)
        {
            monster monsterModel = new monster();
            using (PokemonModels pokemonModel = new PokemonModels())
            {
                monsterModel = pokemonModel.monsters.Where(x => x.id == id).FirstOrDefault();
            }
            return View(monsterModel);
        }

        // GET: Monster/Create
        public ActionResult Create()
        {
            return View(new monster());
        }

        // POST: Monster/Create
        [HttpPost]
        public ActionResult Create(monster monsterModel)
        {
            using (PokemonModels pokemonModel = new PokemonModels())
            {
                pokemonModel.monsters.Add(monsterModel);
                pokemonModel.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: Monster/Edit/5
        public ActionResult Edit(int id)
        {
            monster monsterModel = new monster();
            using (PokemonModels pokemonModel = new PokemonModels())
            {
                monsterModel = pokemonModel.monsters.Where(x => x.id == id).FirstOrDefault();
            }
            return View(monsterModel);
        }

        // POST: Monster/Edit/5
        [HttpPost]
        public ActionResult Edit(monster monsterModel)
        {
            using (PokemonModels pokemonModel = new PokemonModels())
            {
                pokemonModel.Entry(monsterModel).State = System.Data.Entity.EntityState.Modified;
                pokemonModel.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: Monster/Delete/5
        public ActionResult Delete(int id)
        {
            monster monsterModel = new monster();
            using (PokemonModels pokemonModel = new PokemonModels())
            {
                monsterModel = pokemonModel.monsters.Where(x => x.id == id).FirstOrDefault();
            }
            return View(monsterModel);
        }

        // POST: Monster/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            using (PokemonModels pokemonModel = new PokemonModels())
            {
                monster monsterModel = pokemonModel.monsters.Where(x => x.id == id).FirstOrDefault();
                pokemonModel.monsters.Remove(monsterModel);
                pokemonModel.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
