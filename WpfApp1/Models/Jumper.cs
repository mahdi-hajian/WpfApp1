using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WpfApp1.Models
{
    public class Jumper
    {
        public Jumper()
        {

        }
        public Jumper(string name, string nikName, GoalJetEnum goal, int speed, int width, int height, int flyHeight, TypeJetEnum type)
        {
            Name = name;
            NikName = nikName;
            Goal = goal;
            Speed = speed;
            Width = width;
            Height = height;
            FlyHeight = flyHeight;
            Type = type;
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public string NikName { get; set; }
        public GoalJetEnum Goal { get; set; }
        public int Speed { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int FlyHeight { get; set; }
        public TypeJetEnum Type { get; set; }
    }
    public enum TypeJetEnum
    {
        [Display(Name = "هلیکوپتر")]
        Helicopter,
        [Display(Name = "غربی")]
        West,
        [Display(Name = "شرقی")]
        East
    }
    public enum GoalJetEnum
    {
        [Display(Name = "شناسایی")]
        Exploration,
        [Display(Name = "حمله")]
        Attak,
        [Display(Name = "بمباران")]
        Bobmarment
    }
}
