﻿using System.Windows.Forms;
using WorldsHardestGame;
using System.Linq;

namespace irf_10_het_JV6INX
{
    public partial class Form1 : Form
    {
        GameController gc = new GameController();
        GameArea ga;

        int populationSize = 100;
        int nbrOfSteps = 10;
        int nbrOfStepsIncrement = 10;
        int generation = 1;
        public Form1()
        {
            InitializeComponent();
            ga = gc.ActivateDisplay();
            this.Controls.Add(ga);

            gc.GameOver += Gc_GameOver;

            //gc.AddPlayer();
            //gc.Start(true);

            for (int i = 0; i < populationSize; i++)
            {
                gc.AddPlayer(nbrOfSteps);
            }
            gc.Start();

        }

        private void Gc_GameOver(object sender)
        {
            generation++;
            label1.Text = string.Format("{0}. generáció",generation);

            var playerList = from p in gc.GetCurrentPlayers()
                             orderby p.GetFitness() descending
                             select p;
            var topPerformers = playerList.Take(populationSize / 2).ToList();
        }
    }
}
