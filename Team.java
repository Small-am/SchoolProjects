/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package finalproject;

/**
 *
 * @author Kevin
 */
public class Team {
    
    //variables
    private String teamName;
    private String city;
    private String coach;
    private String players;
    private String age;
    private String wins;
    private String losses;
    

    //Constructor

    public Team(String teamName, String city, String coach, String players, String age, String wins, String losses) {
        this.teamName = teamName;
        this.city = city;
        this.coach = coach;
        this.players = players;
        this.age = age;
        this.wins = wins;
        this.losses = losses;
    }

    public String getTeamName() {
        return teamName;
    }

    public void setTeamName(String teamName) {
        this.teamName = teamName;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public String getCoach() {
        return coach;
    }

    public void setCoach(String coach) {
        this.coach = coach;
    }

    public String getAge() {
        return age;
    }

    public void setAge(String age) {
        this.age = age;
    }

     public String getPlayers() {
        return players;
    }

    public void setPlayers(String players) {
        this.players = players;
    }

    public String getWins() {
        return wins;
    }

    public void setWins(String wins) {
        this.wins = wins;
    }

    public String getLosses() {
        return losses;
    }

    public void setLosses(String losses) {
        this.losses = losses;
    }

    @Override
    public String toString() {
        return getCity() + " " + getTeamName();
    }

   
   

    
    
    
    
}
