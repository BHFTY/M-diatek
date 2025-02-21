﻿using Médiatek.dal;
using Médiatek.model;
using System.Collections.Generic;

namespace Médiatek.controller
{
    /// <summary>
    /// Contôleur de FmrGestion
    /// </summary>
    public class FmrGestionController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;
        /// <summary>
        /// objet d'accès aux opérations d'initialisation des comboBox
        /// </summary>
        private readonly InitAccess initAccess;
        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FmrGestionController()
        {
            personnelAccess = new PersonnelAccess();
            absenceAccess = new AbsenceAccess();
            initAccess = new InitAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos du personnel
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les absences d'un personnel
        /// </summary>
        /// <param name="personnel">object personnel concerné</param>
        /// <returns>liste d'absence d'un personnel</returns>
        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            return absenceAccess.GetLesAbsences(personnel);
        }

        /// <summary>
        /// Récupère et retourne les différents services
        /// </summary>
        /// <returns>Liste des services</returns>
        public List<Service> GetLesServices()
        {
            return initAccess.GetLesServices();
        }

        /// <summary>
        /// Récupère et retourne les différents motifs
        /// </summary>
        /// <returns>Liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return initAccess.GetLesMotifs();
        }
        /// <summary>
        /// Ajoute un personnel a la base de données
        /// </summary>
        /// <param name="personnel">object personnel a ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Ajoute une absence a la base de donnes
        /// </summary>
        /// <param name="absence">object absence ajouté la base de donnes</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Modifie un personnel dans la base de données
        /// </summary>
        /// <param name="personnel">object personnel a modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Modifie une absence dans la base de données
        /// </summary>
        /// <param name="absence">object absence a modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            absenceAccess.UpdateAbsence(absence);
        }

        /// <summary>
        /// Suprime un personnel dans la base de données
        /// </summary>
        /// <param name="personnel">object personnel a suprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }

        /// <summary>
        /// Suprime une absence dans la base de données
        /// </summary>
        /// <param name="absence">object absence a suprimer</param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }

        /// <summary>
        /// Suprime les absences d'un personne dans la base de données
        /// </summary>
        /// <param name="personnel">le personne dont les absences seronts suprimé</param>
        public void DelLesAbsences(Personnel personnel)
        {
            absenceAccess.DelLesAbsences(personnel);
        }
    }
}
