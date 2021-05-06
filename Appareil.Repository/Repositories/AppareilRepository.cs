using Appareil.Repository.Entities;
using Appareil.Repository.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Appareil.Repository.Repositories
{
    public class AppareilRepository : IAppareilRepository
    {
        readonly DB_FormationContext _context;

        public AppareilRepository(DB_FormationContext dB_FormationContext)
        {
            _context = dB_FormationContext;
        }

        public int Create(AppareilsLudo appareilsLudo)
        {
            _context.AppareilsLudos.Add(appareilsLudo);
            _context.SaveChanges();

            return appareilsLudo.Id;
        }

        public int Delete(AppareilsLudo appareilsLudo)
        {
            _context.AppareilsLudos.Remove(appareilsLudo);
            _context.SaveChanges();

            return appareilsLudo.Id;
        }

        public List<AppareilsLudo> GetAll()
        {
            return _context.AppareilsLudos.ToList();
        }

        public AppareilsLudo GetById(int id)
        {
            return _context.AppareilsLudos.Where(x => x.Id == id).FirstOrDefault();
        }

        public int Update(AppareilsLudo appareilsLudo)
        {
            _context.AppareilsLudos.Update(appareilsLudo);
            _context.SaveChanges();

            return appareilsLudo.Id;
        }
    }
}
