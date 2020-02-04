/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package finalproject;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.stage.Stage;

/**
 * FXML Controller class
 *
 * @author Kevin
 */
public class EditSceneController implements Initializable {
    
    //Variables
    
    private Team selectedTeam;
    @FXML
    private Label teamNametxt;
    @FXML
    private Label coachtxt;
    @FXML
    private Label citytxt;
    @FXML
    private Label playerstxt;
    @FXML
    private Label agetxt;
    @FXML
    private Label winstxt;
    @FXML
    private Label lossestxt;
    @FXML
    private Button doneBttn;

    /**
     * Initializes the controller class.
     * @param team
     */
    
    // Passing information from the other controller to display teams' information
    
       public void initData(Team team) {
        selectedTeam = team;
        
        teamNametxt.setText(selectedTeam.getTeamName());
        coachtxt.setText(selectedTeam.getCoach());
        citytxt.setText(selectedTeam.getCity());
        playerstxt.setText(selectedTeam.getPlayers());
        agetxt.setText(selectedTeam.getAge());
        winstxt.setText(selectedTeam.getWins());
        lossestxt.setText(selectedTeam.getLosses());
    }
       
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        // TODO
    }    
    
    // Brings users back to main window
    
    @FXML
    private void doneBttnHandle(ActionEvent event) throws IOException {
        FXMLLoader loader = new FXMLLoader();
        loader.setLocation(getClass().getResource("FXMLDocument.fxml"));
        Parent fullInfoParent = loader.load();
        
        Scene fullInfoScene = new Scene(fullInfoParent);
        
        Stage window = (Stage)((Node)event.getSource()).getScene().getWindow();
        
        window.setScene(fullInfoScene);
        
    }
    
}
