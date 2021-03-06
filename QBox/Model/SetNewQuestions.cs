﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class SetNewQuestions
    {
       public static void SetQuestion(Question question)
        {

            using (var db = new Model())
            {
               
                db.Questions.Add(question);
                db.Entry(question.Course).State = EntityState.Unchanged;
                db.SaveChanges();
                
            }

        }
        public static void SetCourse(Course corse)
        {
            using (var db = new Model())
            {
                
                db.Courses.Add(corse);
                db.SaveChanges();

            }

        }
        public static List<Question> GetQuestion()
        {
            List<Question> x = new List<Question>();
            using (var db = new Model())
            {
                x = db.Questions.Include("Course").Include("Answer").ToList();

            }

            return x;
        }
        public static List<Question> GetQuestion(Course corse, int Items)
        {
            Random rnd = new Random();

            List<Question> x = new List<Question>();
            using (var db = new Model())
            {
                x = db.Questions.Include("Course").Include("Answer").ToList();

            }
            var y = new List<Question>();
            foreach (var item in x)
            {
                if(item.Course.ID==corse.ID)
                {
                    y.Add(item);
                }
            }
            var z = y.GetRange(rnd.Next(1,y.Count - Items), Items);

            return z;
        }
        public static List<Course> GetCourse()
        {

            List<Course> x = new List<Course>();
            using (var db = new Model())
            {
                x = db.Courses.ToList();
            }

            return x;
        }


        public static void SetStats(Stat stat)
        {
            using (var db = new Model())
            {

                db.Stats.Add(stat);
                db.Entry(stat.Course).State = EntityState.Unchanged;
                db.SaveChanges();

            }
        }

        public static List<Stat> GetStats()
        {
            List<Stat> x = new List<Stat>();
            using (var db = new Model())
            {
                x = db.Stats.Include("Course").ToList();
            }

            return x;
        }


    }
}
