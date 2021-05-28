using Appareil.BL.Interfaces;
using Appareil.BL.Models;
using Appareil.Repository.Entities;
using Appareil.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appareil.BL.Implementations
{
    public class AppareilBL : IAppareilBL
    {
        private readonly IAppareilRepository _appareilRepository;

        public AppareilBL(IAppareilRepository appareilRepository)
        {
         _appareilRepository = appareilRepository;
        }

        public int Create(AppareilDTO appareilDTO)
        {
            AppareilsLudo appareilsLudo = new AppareilsLudo();

            //appareilsLudo.Id = appareilDTO.Id;
            appareilsLudo.Name = appareilDTO.Name;
            appareilsLudo.Status = appareilDTO.Status;

            return _appareilRepository.Create(appareilsLudo);
        }

        public int Delete(int id)
        {
            AppareilsLudo appareilsLudoToDelete = _appareilRepository.GetById(id);
            return _appareilRepository.Delete(appareilsLudoToDelete);
        }

        public List<AppareilDTO> GetAll()
        {
            List<AppareilDTO> appareils = new List<AppareilDTO>();

            List<AppareilsLudo> appareilsLudos = _appareilRepository.GetAll();

            foreach (var item in appareilsLudos)
            {
                appareils.Add(new AppareilDTO() {Id = item.Id, Name = item.Name, Status = item.Status.Trim() });
            }

            return appareils;

        }

        public AppareilDTO GetById(int id)
        {
            AppareilDTO appareilDTO = new AppareilDTO(); 
 
            AppareilsLudo appareilsLudo = _appareilRepository.GetById(id);

            appareilDTO.Id = appareilsLudo.Id;
            appareilDTO.Name = appareilsLudo.Name;
            appareilDTO.Status = appareilsLudo.Status;
                    
            return appareilDTO;
        }

        public int Update(AppareilDTO appareilDTO)
        {
            AppareilsLudo appareilsLudoToUpdate = _appareilRepository.GetById(appareilDTO.Id);

            appareilsLudoToUpdate.Name = appareilDTO.Name;
            appareilsLudoToUpdate.Status = appareilDTO.Status;

            return _appareilRepository.Update(appareilsLudoToUpdate); 
        }
    }
}
