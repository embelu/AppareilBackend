using Appareil.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appareil.Repository.Interfaces
{
    public interface IAppareilRepository
    {
        public AppareilsLudo GetById(int id);
        public List<AppareilsLudo> GetAll();
        public int Create(AppareilsLudo appareilsLudo);
        public int Delete(AppareilsLudo appareilsLudo);
        public int Update(AppareilsLudo appareilsLudo);
    }
}
