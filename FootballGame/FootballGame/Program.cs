using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Program
    {
        public static void Main()
        {
            Goalkeeper gk1 = new Goalkeeper("Gosho", 25, 1, 180);
            Defender defender1 = new Defender("Vanko", 28, 5, 185);
            Midfield midfield1 = new Midfield("Pesho", 26, 8, 175);
            Striker striker1 = new Striker("Dragan", 23, 9, 180);
            Defender defender2 = new Defender("Ivan", 28, 4, 185);
            Midfield midfield2 = new Midfield("Ivo", 26, 3, 175);
            Striker striker2 = new Striker("Miro", 23, 19, 180);
            Defender defender3 = new Defender("Mirko", 22, 10, 185);
            Defender defender4 = new Defender("Vilko", 28, 12, 185);
            Midfield midfield3 = new Midfield("Petko", 26, 16, 175);
            Striker striker3 = new Striker("Drago", 23, 18, 180);

            Coach coach1 = new Coach("Iliev", 45);

            Team team1 = new Team(coach1);
            team1.Players.Add(gk1);
            team1.Players.Add(defender1);
            team1.Players.Add(midfield1);
            team1.Players.Add(striker2);
            team1.Players.Add(defender2);
            team1.Players.Add(midfield2);
            team1.Players.Add(striker3);
            team1.Players.Add(defender3);
            team1.Players.Add(defender4);
            team1.Players.Add(midfield3);
            team1.Players.Add(striker3);

            Goalkeeper gk2 = new Goalkeeper("Dimaka", 27, 1, 185);
            Defender defender11 = new Defender("Daniel", 30, 4, 180);
            Midfield midfield12 = new Midfield("Nikolai", 29, 7, 175);
            Striker striker13 = new Striker("Dimo", 24, 10, 182);
            Defender defender14 = new Defender("Mitko", 30, 18, 180);
            Midfield midfield15 = new Midfield("Ilko", 29, 15, 175);
            Striker striker16 = new Striker("Milko", 24, 12, 182);
            Defender defender17 = new Defender("Daniel", 30, 29, 180);
            Defender defender18 = new Defender("Niki", 30, 24, 180);
            Midfield midfield19 = new Midfield("Niko", 29, 23, 175);
            Striker striker20 = new Striker("Krisko", 24, 22, 182);


            Coach coach2 = new Coach("Petrov", 42);

            Team team2 = new Team(coach2);
            team2.Players.Add(gk2);
            team2.Players.Add(defender11);
            team2.Players.Add(midfield12);
            team2.Players.Add(striker13);
            team2.Players.Add(defender14);
            team2.Players.Add(midfield15);
            team2.Players.Add(striker16);
            team2.Players.Add(defender17);
            team2.Players.Add(defender18);
            team2.Players.Add(midfield19);
            team2.Players.Add(striker20);


            Referee referee = new Referee("Marqn", 35);

            AssistantReferee ar1 = new AssistantReferee("Paco", 30);
            AssistantReferee ar2 = new AssistantReferee("Stefan", 33);

            Game game = new Game(team1, team2, referee, new List<AssistantReferee> { ar1, ar2 });

        
            game.AddGoal(10, striker1);
            game.AddGoal(30, striker2);

            game.SetResult("Team 1 wins", team1);

            Console.WriteLine("Game Result: " + game.Result);
            Console.WriteLine("Winner: " + game.Winner.Coach.Name);
        }

    }
}
