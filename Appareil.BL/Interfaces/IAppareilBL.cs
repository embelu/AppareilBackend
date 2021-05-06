using Appareil.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appareil.BL.Interfaces
{
    public interface IAppareilBL
    {
        public AppareilDTO GetById(int id);
        public List<AppareilDTO> GetAll();
        public int Create(AppareilDTO appareilDTO);
        public int Delete(int id);
        public int Update(AppareilDTO appareilDTO);
    }
}
