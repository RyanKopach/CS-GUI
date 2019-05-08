package gui;

/**
 *
 * @author ryan.kopach580
 */
public class GUI {

    
}
package CS 


import java.awt.Frame;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.awt.Panel;
import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.Button;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Label;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class GUI {
    private static Frame mainFrame;
    private static Panel topPanel;
    private static Panel bottomPanel;
    private static Button button1;
    private static Button button2;
    private static Label instructionLabel;
    private static Label pushedButton1;
    private static Label pushedButton2;
    private static FlowLayout centeredText;
    private static Font labelFont;
           
    public static void main(String args []){
        GUIMaker();
        eventHandlers();
    }//closes main
    
   
    public static void GUIMaker(){
       
        mainFrame = new Frame("CS");
        
        
        mainFrame.setLayout(new BorderLayout());

       
        mainFrame.setSize(500,250);
        
        centeredText = new FlowLayout(FlowLayout.CENTER,35,35);
        topPanel = new Panel(centeredText);
        bottomPanel = new Panel(centeredText);
        
     
        mainFrame.add(topPanel, BorderLayout.NORTH);
        mainFrame.add(bottomPanel, BorderLayout.SOUTH);
        
       
        button1 = new Button("Button 1");
        button2 = new Button("Button 2");
        Dimension buttonSize = new Dimension(175,55);
        button1.setPreferredSize(buttonSize);
        button2.setPreferredSize(buttonSize);
        
        
        Font buttonFont = new Font("",Font.PLAIN, 30);
        button1.setFont(buttonFont);
        button2.setFont(buttonFont);
        
        
        topPanel.add(button1);
        topPanel.add(button2);
        
        
        instructionLabel = new Label("Push A Button");
        pushedButton1 = new Label("You pushed Button 1");
        pushedButton2 = new Label("You pushed Button 2");
        
        
        bottomPanel.add(instructionLabel);
        
      
        labelFont = new Font("",Font.PLAIN,25);
        instructionLabel.setFont(labelFont);
        pushedButton1.setFont(labelFont);
        pushedButton2.setFont(labelFont);
        
        
        instructionLabel.setForeground(Color.GREEN);
        pushedButton1.setForeground(Color.GREEN);
        pushedButton2.setForeground(Color.GREEN);
        
       
        mainFrame.setVisible(true);
    }//Close GUIMaker
    
    
    public static void eventHandlers(){
        
        button1.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent ae) {
                bottomPanel.removeAll();
                bottomPanel.add(pushedButton1);
                mainFrame.setVisible(true);
            }
        });
             button2.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent ae) {
                bottomPanel.removeAll();
                bottomPanel.add(pushedButton2);
                mainFrame.setVisible(true);
            }
        });
        
    }//close eventHandlers
}//Glose GUI
