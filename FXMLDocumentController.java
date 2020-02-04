/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package finalproject;

import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;
import java.net.URL;
import java.util.Optional;
import java.util.ResourceBundle;
import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.Alert.AlertType;
import javafx.scene.control.Button;
import javafx.scene.control.ButtonType;
import javafx.scene.control.ListView;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

/**
 *
 * @author Kevin
 */
public class FXMLDocumentController implements Initializable {
    
    
    // Variables for GUI
    
    ObservableList<Team> team = FXCollections.observableArrayList();

    private Team selectedTeam;
    @FXML
    private TextField TeamNametxt;
    @FXML
    private TextField NumOfPlayerstxt;
    @FXML
    private TextField Coachtxt;
    @FXML
    private TextField Agetxt;
    @FXML
    private TextField Citytxt;
    @FXML
    private TextField Winstxt;
    @FXML
    private TextField Lossestxt;
    @FXML
    private ListView<Team> listView;
    @FXML
    private Button deleteButtonPushed;
    @FXML
    private Button Addbttn;
    @FXML
    private Button fullinfo;
    private int selectedIndex = -1;
    @FXML
    private TextField search;

    @FXML
    private Button updateButton;
    @FXML
    private Button saveButton;

    @Override
    public void initialize(URL url, ResourceBundle rb) {
        
        // Add objects to the list 
        listView.getItems().add(new Team("Bounce", "Toronto", "Nick Nurse", "14", "21", "41", "41"));
        listView.getItems().add(new Team("Saints", "Brampton", "Jamie Miller", "12", "19", "44", "38"));
        listView.getItems().add(new Team("Monarchs", "Mississauga", "Mark Brown", "15", "18", "34", "47"));
        listView.getItems().add(new Team("WildCats", "Burlington", "Rick Lee", "11", "20", "45", "37"));
        listView.getItems().add(new Team("Kings", "Toronto", "Daniel Morris", "14", "21", "41", "41"));

        search.textProperty().addListener(new ChangeListener() {
           
           public void changed(ObservableValue observable, Object oldValue, Object newValue) {
                filterTeamList((String) oldValue, (String) newValue);
           }
       });
    }

    /* 
     When the delete button is pushed, when a team is selected from the list,
     a confirmation dialog will pop up to confirm the command
     */
    @FXML
    public void deleteButtonPushed() {
        ObservableList<Team> selectedTeam, allTeams;
        allTeams = listView.getItems();

        selectedTeam = listView.getSelectionModel().getSelectedItems();

        Alert alert = new Alert(AlertType.CONFIRMATION);
        alert.setTitle("Confirmation Dialog");
        alert.setHeaderText(null);
        alert.setContentText("Are you sure to delete the team?");
        Optional<ButtonType> action = alert.showAndWait();

        if (action.isPresent() && action.get() == ButtonType.OK) {
            for (Team team : selectedTeam) {
                allTeams.remove(team);
            }
        }

    }
    
    // Adds a team when the proper information is typed into the textfields
    
    @FXML
    private void AddBttnHandle(ActionEvent e) throws IOException {
        
        Team newTeam = new Team(TeamNametxt.getText(), Citytxt.getText(),
                Coachtxt.getText(), NumOfPlayerstxt.getText(), Agetxt.getText(),
                Winstxt.getText(), Lossestxt.getText());

        listView.getItems().add(newTeam);
        
        TeamNametxt.clear();
        Coachtxt.clear();
        Citytxt.clear();
        NumOfPlayerstxt.clear();
        Agetxt.clear();
        Winstxt.clear();
        Lossestxt.clear();

    }

    /* 
    When a team is selected from the list, the button will bring user to
    */  
    @FXML
    private void fullInfoButtonHandle(ActionEvent event) throws IOException {
        FXMLLoader loader = new FXMLLoader();
        loader.setLocation(getClass().getResource("EditScene.fxml"));
        Parent tableViewParent = loader.load();

        Scene tableViewScene = new Scene(tableViewParent);

        EditSceneController controller = loader.getController();
        controller.initData(listView.getSelectionModel().getSelectedItem());
        
        
        Stage window = (Stage) ((Node) event.getSource()).getScene().getWindow();
        
        window.setScene(tableViewScene);
        
    }
    
    /*
    When team is selected from list, all the object's attributes will appear
    in the textfield for updating/editing purposes
    */
    @FXML
    private void listViewClicked() {

        String selectedTeamName = listView.getSelectionModel().getSelectedItem().getTeamName();
        String selectedCoach = listView.getSelectionModel().getSelectedItem().getCoach();
        String selectedCity = listView.getSelectionModel().getSelectedItem().getCity();
        String selectedPlayers = listView.getSelectionModel().getSelectedItem().getPlayers();
        String selectedAge = listView.getSelectionModel().getSelectedItem().getAge();
        String selectedWins = listView.getSelectionModel().getSelectedItem().getWins();
        String selectedLosses = listView.getSelectionModel().getSelectedItem().getLosses();

        TeamNametxt.setText(selectedTeamName);
        Coachtxt.setText(selectedCoach);
        Citytxt.setText(selectedCity);
        NumOfPlayerstxt.setText(selectedPlayers);
        Agetxt.setText(selectedAge);
        Winstxt.setText(selectedWins);
        Lossestxt.setText(selectedLosses);
    }
    
    // Updates the textfield for selected team, and brings a confirmation dialog

    @FXML
    private void updateButtonHandle(ActionEvent event) {
        ObservableList<Team> selectedTeam, allTeams;
        Team newTeam = new Team(TeamNametxt.getText(), Citytxt.getText(),
                Coachtxt.getText(), NumOfPlayerstxt.getText(), Agetxt.getText(),
                Winstxt.getText(), Lossestxt.getText());
        allTeams = listView.getItems();

        selectedTeam = listView.getSelectionModel().getSelectedItems();

        Alert alert = new Alert(AlertType.CONFIRMATION);
        alert.setTitle("Confirmation Dialog");
        alert.setHeaderText(null);
        alert.setContentText("Are you sure you want to update team's info?");
        Optional<ButtonType> action = alert.showAndWait();

        if (action.isPresent() && action.get() == ButtonType.OK) {
            for (Team team : selectedTeam) {
                allTeams.remove(team);
                allTeams.add(newTeam);
            }
        }
        TeamNametxt.clear();
        Coachtxt.clear();
        Citytxt.clear();
        NumOfPlayerstxt.clear();
        Agetxt.clear();
        Winstxt.clear();
        Lossestxt.clear();
    }
    
    //Using the search textfield, will filter the proper teams
    public void filterTeamList(String oldValue, String newValue) {
        ObservableList<Team> filterList = FXCollections.observableArrayList();
        if (search == null || newValue.isEmpty()) {
            listView.setItems(team);
        } else {
            newValue = newValue.toLowerCase();
            for (Team team: listView.getItems()) {
                String filterTeamName = team.getTeamName();
                String filterCity = team.getCity();
                if (filterTeamName.toLowerCase().contains(newValue) || filterCity.toLowerCase().contains(newValue)) {
                    filterList.add(team);
                }
            }
            listView.setItems(filterList);
        }
    }

    @FXML
    private void SaveHandle(ActionEvent event) throws IOException {
        File teamFile = new File("TeamList.txt");
        PrintWriter output = new PrintWriter(teamFile);
        output.println(listView);
        output.close();
        ((Node) event.getSource()).getScene().getWindow().hide();
    }
}