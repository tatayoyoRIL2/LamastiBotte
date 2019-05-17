using LamastiBotte.Core.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamastiBotte.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            accueilVue vue = new accueilVue();
            vue.ShowDialog();
            vue.Dispose();
        }
    }
}
