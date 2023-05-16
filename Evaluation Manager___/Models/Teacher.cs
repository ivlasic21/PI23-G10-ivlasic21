﻿using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models
{
    public class Teacher : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool CheckPassword (string password) {
            return Password == password; //meni ce ovo bit u person jer se 3 tipa može prijaviti
        }

        public void PerformEvaluation(Student student, Activity activity, int points) { 
            var evaluation = EvaluationRepository.GetEvaluation(student, activity); 
            if (evaluation != null) {
                EvaluationRepository.InsertEvaluation(student, activity, this, points); // this predstavja teacher
            } else {
                EvaluationRepository.UpdateEvaluation(evaluation, this, points);
            }
        }
    }
}