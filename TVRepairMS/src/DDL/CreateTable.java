/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DDL;
import java.sql.*;
import javax.swing.*;
import UI.MainMenu;


/**
 *
 * @author Admin
 */
public class CreateTable extends javax.swing.JFrame {

    /**
     * Creates new form CreateTable
     */
    public CreateTable() {
        initComponents();
        hideAll();
    }
    
    private void clearfield()
    {
        txtName.setText("");
        cbocolumn.setSelectedIndex(0);
        
        txt1.setText("");
        cbo1.setSelectedIndex(0);
        chk1.setSelected(false);
        chkp1.setSelected(false);
        
        txt2.setText("");
        cbo2.setSelectedIndex(0);
        chk2.setSelected(false);
        chkp2.setSelected(false);
        
        txt3.setText("");
        cbo3.setSelectedIndex(0);
        chk3.setSelected(false);
        chkp3.setSelected(false);
        
        txt4.setText("");
        cbo4.setSelectedIndex(0);
        chk4.setSelected(false);
        chkp4.setSelected(false);

        txt5.setText("");
        cbo5.setSelectedIndex(0);
        chk5.setSelected(false);
        chkp5.setSelected(false);

        txt6.setText("");
        cbo6.setSelectedIndex(0);
        chk6.setSelected(false);
        chkp6.setSelected(false);

        txt7.setText("");
        cbo7.setSelectedIndex(0);
        chk7.setSelected(false);
        chkp7.setSelected(false);

        txt8.setText("");
        cbo8.setSelectedIndex(0);
        chk8.setSelected(false);
        chkp8.setSelected(false);
    }
    
    
    private String[] Data1()
    {
        String cName = txt1.getText();
        String dType = cbo1.getSelectedItem().toString();
        String st;
        String pKey;
        if (chk1.isSelected())
        {
            st = "NULL";
        }
        else
        {
            st = "NOT NULL";
        }
        if(chkp1.isSelected())
        {
            pKey = "PRIMARY KEY";
        }
        else
        {
            pKey = "";
        }
        String [] data = {cName, dType, st, pKey};
        return data;
    }
    private String [] Data2()
    {
        String cName = txt2.getText();
        String dType = cbo2.getSelectedItem().toString();
        String st;
        String pKey;
        if(chk2.isSelected())
        {
            st = "NULL";
        }
        else
        {
            st = "NOT NULL";
        }
        if(chkp2.isSelected())
        {
            pKey = "NULL";
        }
        else
        {
            pKey = "NOT NULL";
        }
        String [] previous = Data1();
        String [] current = {cName,dType,st,pKey};
        String [] result = new String[previous.length+ current.length];
        System.arraycopy(previous, 0, result, 0, previous.length);
        System.arraycopy(current,0, result,4,current.length);
        return result;
    }
    private String[] Data3()
    {
        String cName = txt3.getText();
        String dType = cbo3.getSelectedItem().toString();
        String st;
        String pKey;
        if(chk3.isSelected())
        {
            st = "NULL";
        }
        else
        {
            st = "NOT NULL";
        }
        if(chkp3.isSelected())
        {
            pKey = "PRIMARY KEY";
        }
        else
        {
            pKey = "";
        }
        String [] previous = Data2();
        String [] current = {cName, dType, st, pKey};
        String [] result = new String[previous.length+ current.length];
        System.arraycopy(previous, 0, result, 0, previous.length);
        System.arraycopy(current, 0, result, 8, current.length);
        return result;
    }
    private String[] Data4()
    {
        String cName = txt4.getText();
        String dType = cbo4.getSelectedItem().toString();
        String st;
        String pKey;
        if(chk4.isSelected())
        {
            st = "NULL";
        }
        else
        {
            st = "NOT NULL";
        }
        if(chkp4.isSelected())
        {
            pKey = "PRIMARY KEY";
        }
        else
        {
            pKey = "";
        }
        String [] previous = Data3();
        String [] current = {cName, dType, st, pKey};
        String [] result = new String[previous.length+ current.length];
        System.arraycopy(previous, 0, result, 0, previous.length);
        System.arraycopy(current, 0, result, 12, current.length);
        return result;
    }
    private String[] Data5()
    {
        String cName = txt5.getText();
        String dType = cbo5.getSelectedItem().toString();
        String st;
        String pKey;
        if(chk5.isSelected())
        {
            st = "NULL";
        }
        else
        {
            st = "NOT NULL";
        }
        if(chkp5.isSelected())
        {
            pKey = "PRIMARY KEY";
        }
        else
        {
            pKey = "";
        }
        String [] previous = Data4();
        String [] current = {cName, dType, st, pKey};
        String [] result = new String[previous.length+ current.length];
        System.arraycopy(previous, 0, result, 0, previous.length);
        System.arraycopy(current, 0, result, 16, current.length);
        return result;
    }
    private String[] Data6()
    {
        String cName = txt6.getText();
        String dType = cbo6.getSelectedItem().toString();
        String st;
        String pKey;
        if(chk6.isSelected())
        {
            st = "NULL";
        }
        else
        {
            st = "NOT NULL";
        }
        if(chkp6.isSelected())
        {
            pKey = "PRIMARY KEY";
        }
        else
        {
            pKey = "";
        }
        String [] previous = Data5();
        String [] current = {cName, dType, st, pKey};
        String [] result = new String[previous.length + current.length];
        System.arraycopy(previous, 0, result, 0, previous.length);
        System.arraycopy(current, 0, result, 20, current.length);
        return result;
    }
    private String[] Data7()
    {
        String cName = txt7.getText();
        String dType = cbo7.getSelectedItem().toString();
        String st;
        String pKey;
        if(chk7.isSelected())
        {
            st = "NULL";
        }
        else
        {
            st = "NOT NULL";
        }
        if(chkp7.isSelected())
        {
            pKey = "PRIMARY KEY";
        }
        else
        {
            pKey = "";
        }
        String [] previous = Data6();
        String [] current = {cName, dType, st, pKey};
        String [] result = new String[previous.length + current.length];
        System.arraycopy(previous, 0, result, 0, previous.length);
        System.arraycopy(current, 0, result, 24, current.length);
        return result;
    }
    private String[] Data8()
    {
        String cName = txt8.getText();
        String dType = cbo8.getSelectedItem().toString();
        String st;
        String pKey;
        if(chk8.isSelected())
        {
            st = "NULL";
        }
        else
        {
            st = "NOT NULL";
        }
        if(chkp8.isSelected())
        {
            pKey = "PRIMARY KEY";
        }
        else
        {
            pKey = "";
        }
        String [] previous = Data7();
        String [] current = {cName, dType, st, pKey};
        String [] result = new String[previous.length + current.length];
        System.arraycopy(previous, 0, result, 0, previous.length);
        System.arraycopy(current, 0, result, 28, current.length);
        return result;
    }
    private void hideAll()
    {
        btnCreatetable.setVisible(false);
        
        lbl1.setVisible(false);
        txt1.setVisible(false);
        cbo1.setVisible(false);
        chk1.setVisible(false);
        chkp1.setVisible(false);
        
        lbl2.setVisible(false);
        txt2.setVisible(false);
        cbo2.setVisible(false);
        chk2.setVisible(false);
        chkp2.setVisible(false);
        
        lbl3.setVisible(false);
        txt3.setVisible(false);
        cbo3.setVisible(false);
        chk3.setVisible(false);
        chkp3.setVisible(false);
        
        lbl4.setVisible(false);
        txt4.setVisible(false);
        cbo4.setVisible(false);
        chk4.setVisible(false);
        chkp4.setVisible(false);
        
        lbl5.setVisible(false);
        txt5.setVisible(false);
        cbo5.setVisible(false);
        chk5.setVisible(false);
        chkp5.setVisible(false);
        
        lbl6.setVisible(false);
        txt6.setVisible(false);
        cbo6.setVisible(false);
        chk6.setVisible(false);
        chkp6.setVisible(false);

        lbl7.setVisible(false);
        txt7.setVisible(false);
        cbo7.setVisible(false);
        chk7.setVisible(false);
        chkp7.setVisible(false);

        lbl8.setVisible(false);
        txt8.setVisible(false);
        cbo8.setVisible(false);
        chk8.setVisible(false);
        chkp8.setVisible(false);
    }
    
    

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        txtName = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        cbocolumn = new javax.swing.JComboBox<>();
        btnConfirm = new javax.swing.JButton();
        jPanel2 = new javax.swing.JPanel();
        lbl1 = new javax.swing.JLabel();
        txt1 = new javax.swing.JTextField();
        cbo1 = new javax.swing.JComboBox<>();
        chk1 = new javax.swing.JCheckBox();
        chkp1 = new javax.swing.JCheckBox();
        lbl2 = new javax.swing.JLabel();
        txt2 = new javax.swing.JTextField();
        cbo2 = new javax.swing.JComboBox<>();
        chk2 = new javax.swing.JCheckBox();
        chkp2 = new javax.swing.JCheckBox();
        lbl3 = new javax.swing.JLabel();
        txt3 = new javax.swing.JTextField();
        cbo3 = new javax.swing.JComboBox<>();
        chk3 = new javax.swing.JCheckBox();
        chkp3 = new javax.swing.JCheckBox();
        lbl4 = new javax.swing.JLabel();
        txt4 = new javax.swing.JTextField();
        cbo4 = new javax.swing.JComboBox<>();
        chk4 = new javax.swing.JCheckBox();
        chkp4 = new javax.swing.JCheckBox();
        lbl5 = new javax.swing.JLabel();
        txt5 = new javax.swing.JTextField();
        cbo5 = new javax.swing.JComboBox<>();
        chk5 = new javax.swing.JCheckBox();
        chkp5 = new javax.swing.JCheckBox();
        jLabel1 = new javax.swing.JLabel();
        btnCreatetable = new javax.swing.JButton();
        lbl6 = new javax.swing.JLabel();
        txt6 = new javax.swing.JTextField();
        cbo6 = new javax.swing.JComboBox<>();
        chk6 = new javax.swing.JCheckBox();
        chkp6 = new javax.swing.JCheckBox();
        lbl7 = new javax.swing.JLabel();
        txt7 = new javax.swing.JTextField();
        cbo7 = new javax.swing.JComboBox<>();
        chk7 = new javax.swing.JCheckBox();
        chkp7 = new javax.swing.JCheckBox();
        lbl8 = new javax.swing.JLabel();
        txt8 = new javax.swing.JTextField();
        cbo8 = new javax.swing.JComboBox<>();
        chk8 = new javax.swing.JCheckBox();
        chkp8 = new javax.swing.JCheckBox();
        btnBACK = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("CREATE TABLE");

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));
        jPanel1.setForeground(new java.awt.Color(153, 153, 153));

        jLabel2.setFont(new java.awt.Font("Segoe UI", 1, 14)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(153, 0, 51));
        jLabel2.setText("Table name");

        txtName.setFont(new java.awt.Font("Segoe UI", 1, 14)); // NOI18N
        txtName.setForeground(new java.awt.Color(102, 102, 102));

        jLabel3.setFont(new java.awt.Font("Segoe UI", 1, 14)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(153, 0, 51));
        jLabel3.setText("No of tables");

        cbocolumn.setFont(new java.awt.Font("Segoe UI", 1, 14)); // NOI18N
        cbocolumn.setForeground(new java.awt.Color(102, 102, 102));
        cbocolumn.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Select", "2", "3", "4", "5", "6", "7", "8" }));

        btnConfirm.setFont(new java.awt.Font("Segoe UI", 1, 14)); // NOI18N
        btnConfirm.setForeground(new java.awt.Color(153, 0, 51));
        btnConfirm.setText("CONFIRM");
        btnConfirm.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnConfirmActionPerformed(evt);
            }
        });

        jPanel2.setBorder(javax.swing.BorderFactory.createBevelBorder(javax.swing.border.BevelBorder.RAISED));
        jPanel2.setForeground(new java.awt.Color(0, 102, 102));

        lbl1.setBackground(new java.awt.Color(0, 102, 102));
        lbl1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lbl1.setForeground(new java.awt.Color(153, 0, 51));
        lbl1.setText("Column 1");

        txt1.setBackground(new java.awt.Color(153, 0, 0));
        txt1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        txt1.setForeground(new java.awt.Color(255, 255, 255));

        cbo1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        cbo1.setForeground(new java.awt.Color(153, 0, 51));
        cbo1.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Select", "int", "float", "double", "varchar(5)", "varchar(10)", "varchar(15)", "varchar(20)", "char" }));

        chk1.setBackground(new java.awt.Color(255, 255, 255));
        chk1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chk1.setForeground(new java.awt.Color(153, 0, 51));
        chk1.setText("NULL");
        chk1.setBorderPainted(true);

        chkp1.setBackground(new java.awt.Color(255, 255, 255));
        chkp1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chkp1.setForeground(new java.awt.Color(153, 0, 51));
        chkp1.setText("PRIMARY KEY");
        chkp1.setBorderPainted(true);

        lbl2.setBackground(new java.awt.Color(0, 102, 102));
        lbl2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lbl2.setForeground(new java.awt.Color(153, 0, 51));
        lbl2.setText("Column 2");

        txt2.setBackground(new java.awt.Color(153, 0, 0));
        txt2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        txt2.setForeground(new java.awt.Color(255, 255, 255));

        cbo2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        cbo2.setForeground(new java.awt.Color(153, 0, 51));
        cbo2.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Select", "int", "float", "double", "varchar(5)", "varchar(10)", "varchar(15)", "varchar(20)", "char" }));

        chk2.setBackground(new java.awt.Color(255, 255, 255));
        chk2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chk2.setForeground(new java.awt.Color(153, 0, 51));
        chk2.setText("NULL");
        chk2.setBorderPainted(true);

        chkp2.setBackground(new java.awt.Color(255, 255, 255));
        chkp2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chkp2.setForeground(new java.awt.Color(153, 0, 51));
        chkp2.setText("PRIMARY KEY");
        chkp2.setBorderPainted(true);

        lbl3.setBackground(new java.awt.Color(0, 102, 102));
        lbl3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lbl3.setForeground(new java.awt.Color(153, 0, 51));
        lbl3.setText("Column 3");

        txt3.setBackground(new java.awt.Color(153, 0, 0));
        txt3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        txt3.setForeground(new java.awt.Color(255, 255, 255));

        cbo3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        cbo3.setForeground(new java.awt.Color(153, 0, 51));
        cbo3.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Select", "int", "float", "double", "varchar(5)", "varchar(10)", "varchar(15)", "varchar(20)", "char" }));

        chk3.setBackground(new java.awt.Color(255, 255, 255));
        chk3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chk3.setForeground(new java.awt.Color(153, 0, 51));
        chk3.setText("NULL");
        chk3.setBorderPainted(true);

        chkp3.setBackground(new java.awt.Color(255, 255, 255));
        chkp3.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chkp3.setForeground(new java.awt.Color(153, 0, 51));
        chkp3.setText("PRIMARY KEY");
        chkp3.setBorderPainted(true);

        lbl4.setBackground(new java.awt.Color(0, 102, 102));
        lbl4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lbl4.setForeground(new java.awt.Color(153, 0, 51));
        lbl4.setText("Column 4");

        txt4.setBackground(new java.awt.Color(153, 0, 0));
        txt4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        txt4.setForeground(new java.awt.Color(255, 255, 255));

        cbo4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        cbo4.setForeground(new java.awt.Color(153, 0, 51));
        cbo4.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Select", "int", "float", "double", "varchar(5)", "varchar(10)", "varchar(15)", "varchar(20)", "char" }));

        chk4.setBackground(new java.awt.Color(255, 255, 255));
        chk4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chk4.setForeground(new java.awt.Color(153, 0, 51));
        chk4.setText("NULL");
        chk4.setBorderPainted(true);

        chkp4.setBackground(new java.awt.Color(255, 255, 255));
        chkp4.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chkp4.setForeground(new java.awt.Color(153, 0, 51));
        chkp4.setText("PRIMARY KEY");
        chkp4.setBorderPainted(true);

        lbl5.setBackground(new java.awt.Color(0, 102, 102));
        lbl5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lbl5.setForeground(new java.awt.Color(153, 0, 51));
        lbl5.setText("Column 5");

        txt5.setBackground(new java.awt.Color(153, 0, 0));
        txt5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        txt5.setForeground(new java.awt.Color(255, 255, 255));

        cbo5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        cbo5.setForeground(new java.awt.Color(153, 0, 51));
        cbo5.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Select", "int", "float", "double", "varchar(5)", "varchar(10)", "varchar(15)", "varchar(20)", "char" }));

        chk5.setBackground(new java.awt.Color(255, 255, 255));
        chk5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chk5.setForeground(new java.awt.Color(153, 0, 51));
        chk5.setText("NULL");
        chk5.setBorderPainted(true);

        chkp5.setBackground(new java.awt.Color(255, 255, 255));
        chkp5.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chkp5.setForeground(new java.awt.Color(153, 0, 51));
        chkp5.setText("PRIMARY KEY");
        chkp5.setBorderPainted(true);

        jLabel1.setBackground(new java.awt.Color(0, 102, 102));
        jLabel1.setFont(new java.awt.Font("Segoe UI", 1, 18)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(153, 0, 51));
        jLabel1.setText("TABLE CREATION");

        btnCreatetable.setBackground(new java.awt.Color(153, 0, 0));
        btnCreatetable.setFont(new java.awt.Font("Segoe UI", 1, 14)); // NOI18N
        btnCreatetable.setForeground(new java.awt.Color(255, 255, 255));
        btnCreatetable.setText("CREATE TABLE");
        btnCreatetable.setBorderPainted(false);
        btnCreatetable.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCreatetableActionPerformed(evt);
            }
        });

        lbl6.setBackground(new java.awt.Color(0, 102, 102));
        lbl6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lbl6.setForeground(new java.awt.Color(153, 0, 51));
        lbl6.setText("Column 6");

        txt6.setBackground(new java.awt.Color(153, 0, 0));
        txt6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        txt6.setForeground(new java.awt.Color(255, 255, 255));

        cbo6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        cbo6.setForeground(new java.awt.Color(153, 0, 51));
        cbo6.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Select", "int", "float", "double", "varchar(5)", "varchar(10)", "varchar(15)", "varchar(20)", "char" }));

        chk6.setBackground(new java.awt.Color(255, 255, 255));
        chk6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chk6.setForeground(new java.awt.Color(153, 0, 51));
        chk6.setText("NULL");
        chk6.setBorderPainted(true);

        chkp6.setBackground(new java.awt.Color(255, 255, 255));
        chkp6.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chkp6.setForeground(new java.awt.Color(153, 0, 51));
        chkp6.setText("PRIMARY KEY");
        chkp6.setBorderPainted(true);

        lbl7.setBackground(new java.awt.Color(0, 102, 102));
        lbl7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lbl7.setForeground(new java.awt.Color(153, 0, 51));
        lbl7.setText("Column 7");

        txt7.setBackground(new java.awt.Color(153, 0, 0));
        txt7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        txt7.setForeground(new java.awt.Color(255, 255, 255));

        cbo7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        cbo7.setForeground(new java.awt.Color(153, 0, 51));
        cbo7.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Select", "int", "float", "double", "varchar(5)", "varchar(10)", "varchar(15)", "varchar(20)", "char" }));

        chk7.setBackground(new java.awt.Color(255, 255, 255));
        chk7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chk7.setForeground(new java.awt.Color(153, 0, 51));
        chk7.setText("NULL");
        chk7.setBorderPainted(true);

        chkp7.setBackground(new java.awt.Color(255, 255, 255));
        chkp7.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chkp7.setForeground(new java.awt.Color(153, 0, 51));
        chkp7.setText("PRIMARY KEY");
        chkp7.setBorderPainted(true);

        lbl8.setBackground(new java.awt.Color(0, 102, 102));
        lbl8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        lbl8.setForeground(new java.awt.Color(153, 0, 51));
        lbl8.setText("Column 8");

        txt8.setBackground(new java.awt.Color(153, 0, 0));
        txt8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        txt8.setForeground(new java.awt.Color(255, 255, 255));

        cbo8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        cbo8.setForeground(new java.awt.Color(153, 0, 51));
        cbo8.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Select", "int", "float", "double", "varchar(5)", "varchar(10)", "varchar(15)", "varchar(20)", "char" }));

        chk8.setBackground(new java.awt.Color(255, 255, 255));
        chk8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chk8.setForeground(new java.awt.Color(153, 0, 51));
        chk8.setText("NULL");
        chk8.setBorderPainted(true);

        chkp8.setBackground(new java.awt.Color(255, 255, 255));
        chkp8.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        chkp8.setForeground(new java.awt.Color(153, 0, 51));
        chkp8.setText("PRIMARY KEY");
        chkp8.setBorderPainted(true);

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGap(49, 49, 49)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lbl1, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl2, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl3, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl4, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl5, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl6, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl7, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl8, javax.swing.GroupLayout.PREFERRED_SIZE, 82, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addGap(33, 33, 33)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(txt8, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 126, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txt2, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 126, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txt3, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 126, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txt4, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 126, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txt6, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 126, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txt7, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 126, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txt1, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 126, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txt5, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 126, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(40, 40, 40)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(cbo8, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(cbo1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(cbo2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(cbo3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(cbo4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(cbo5, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(cbo6, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(cbo7, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(244, 444, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addComponent(chk3, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(chk4, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(chk5, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(chk6, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(chk7, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(chk8, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 86, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGap(60, 60, 60)
                                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(chkp4)
                                    .addComponent(chkp3)
                                    .addComponent(chkp5)
                                    .addComponent(chkp6)
                                    .addComponent(chkp7)
                                    .addComponent(chkp8)))
                            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(chk1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(chk2, javax.swing.GroupLayout.PREFERRED_SIZE, 85, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGap(61, 61, 61)
                                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(chkp2)
                                    .addComponent(chkp1))
                                .addGap(80, 80, 80))))))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 162, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(360, 360, 360))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(btnCreatetable, javax.swing.GroupLayout.PREFERRED_SIZE, 397, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(236, 236, 236))))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addGap(51, 51, 51)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(chkp1)
                    .addComponent(lbl1)
                    .addComponent(cbo1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(chk1)
                    .addComponent(txt1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(chkp2)
                    .addComponent(lbl2)
                    .addComponent(cbo2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(chk2)
                    .addComponent(txt2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(chkp3)
                    .addComponent(lbl3)
                    .addComponent(txt3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cbo3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(chk3))
                .addGap(18, 18, 18)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(chkp4)
                    .addComponent(lbl4)
                    .addComponent(txt4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cbo4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(chk4))
                .addGap(18, 18, 18)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(chkp5)
                    .addComponent(lbl5)
                    .addComponent(txt5, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cbo5, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(chk5))
                .addGap(18, 18, 18)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(chkp6)
                    .addComponent(lbl6)
                    .addComponent(txt6, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cbo6, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(chk6))
                .addGap(18, 18, 18)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(chkp7)
                    .addComponent(lbl7)
                    .addComponent(txt7, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cbo7, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(chk7))
                .addGap(18, 18, 18)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt8, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lbl8)
                    .addComponent(cbo8, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(chkp8)
                    .addComponent(chk8))
                .addGap(37, 37, 37)
                .addComponent(btnCreatetable, javax.swing.GroupLayout.PREFERRED_SIZE, 39, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        btnBACK.setFont(new java.awt.Font("Segoe UI", 1, 14)); // NOI18N
        btnBACK.setForeground(new java.awt.Color(153, 0, 0));
        btnBACK.setText("BACK TO MAIN MENU");
        btnBACK.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBACKActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(29, 29, 29)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addComponent(jLabel2)
                                .addGap(18, 18, 18)
                                .addComponent(txtName, javax.swing.GroupLayout.PREFERRED_SIZE, 107, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, 89, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(btnConfirm, javax.swing.GroupLayout.PREFERRED_SIZE, 107, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(cbocolumn, javax.swing.GroupLayout.PREFERRED_SIZE, 107, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(btnBACK, javax.swing.GroupLayout.PREFERRED_SIZE, 204, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(18, 18, 18)
                .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addGap(70, 70, 70)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(txtName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(32, 32, 32)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(cbocolumn, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(26, 26, 26)
                .addComponent(btnConfirm)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 270, Short.MAX_VALUE)
                .addComponent(btnBACK, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(29, 29, 29))
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnConfirmActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnConfirmActionPerformed
        // TODO add your handling code here:
        if(cbocolumn.getSelectedItem().equals("Select"))
        {
            hideAll();
            JOptionPane.showMessageDialog(this,"Choose the number of column");
        }
        else if (cbocolumn.getSelectedItem().equals("2"))
        {
            hideAll();
            lbl1.setVisible(true);
            txt1.setVisible(true);
            cbo1.setVisible(true);
            chk1.setVisible(true);
            chkp1.setVisible(true);

            lbl2.setVisible(true);
            txt2.setVisible(true);
            cbo2.setVisible(true);
            chk2.setVisible(true);
            chkp2.setVisible(true);
            btnCreatetable.setVisible(true);
        }
        else if(cbocolumn.getSelectedItem().equals("3"))
        {
            hideAll();
            lbl1.setVisible(true);
            txt1.setVisible(true);
            cbo1.setVisible(true);
            chk1.setVisible(true);
            chkp1.setVisible(true);

            lbl2.setVisible(true);
            txt2.setVisible(true);
            cbo2.setVisible(true);
            chk2.setVisible(true);
            chkp2.setVisible(true);

            lbl3.setVisible(true);
            txt3.setVisible(true);
            cbo3.setVisible(true);
            chk3.setVisible(true);
            chkp3.setVisible(true);
            btnCreatetable.setVisible(true);
        }
        else if(cbocolumn.getSelectedItem().equals("4"))
        {
            hideAll();
            lbl1.setVisible(true);
            txt1.setVisible(true);
            cbo1.setVisible(true);
            chk1.setVisible(true);
            chkp1.setVisible(true);

            lbl2.setVisible(true);
            txt2.setVisible(true);
            cbo2.setVisible(true);
            chk2.setVisible(true);
            chkp2.setVisible(true);

            lbl3.setVisible(true);
            txt3.setVisible(true);
            cbo3.setVisible(true);
            chk3.setVisible(true);
            chkp3.setVisible(true);

            lbl4.setVisible(true);
            txt4.setVisible(true);
            cbo4.setVisible(true);
            chk4.setVisible(true);
            chkp4.setVisible(true);
            btnCreatetable.setVisible(true);
        }
        else if(cbocolumn.getSelectedItem().equals("5"))
        {
            hideAll();
            lbl1.setVisible(true);
            txt1.setVisible(true);
            cbo1.setVisible(true);
            chk1.setVisible(true);
            chkp1.setVisible(true);

            lbl2.setVisible(true);
            txt2.setVisible(true);
            cbo2.setVisible(true);
            chk2.setVisible(true);
            chkp2.setVisible(true);

            lbl3.setVisible(true);
            txt3.setVisible(true);
            cbo3.setVisible(true);
            chk3.setVisible(true);
            chkp3.setVisible(true);

            lbl4.setVisible(true);
            txt4.setVisible(true);
            cbo4.setVisible(true);
            chk4.setVisible(true);
            chkp4.setVisible(true);

            lbl5.setVisible(true);
            txt5.setVisible(true);
            cbo5.setVisible(true);
            chk5.setVisible(true);
            chkp5.setVisible(true);
            btnCreatetable.setVisible(true);
        }
        else if(cbocolumn.getSelectedItem().equals("6"))
        {
            hideAll();
            lbl1.setVisible(true);
            txt1.setVisible(true);
            cbo1.setVisible(true);
            chk1.setVisible(true);
            chkp1.setVisible(true);

            lbl2.setVisible(true);
            txt2.setVisible(true);
            cbo2.setVisible(true);
            chk2.setVisible(true);
            chkp2.setVisible(true);

            lbl3.setVisible(true);
            txt3.setVisible(true);
            cbo3.setVisible(true);
            chk3.setVisible(true);
            chkp3.setVisible(true);

            lbl4.setVisible(true);
            txt4.setVisible(true);
            cbo4.setVisible(true);
            chk4.setVisible(true);
            chkp4.setVisible(true);

            lbl5.setVisible(true);
            txt5.setVisible(true);
            cbo5.setVisible(true);
            chk5.setVisible(true);
            chkp5.setVisible(true);

            lbl6.setVisible(true);
            txt6.setVisible(true);
            cbo6.setVisible(true);
            chk6.setVisible(true);
            chkp6.setVisible(true);
            btnCreatetable.setVisible(true);
        }
        else if(cbocolumn.getSelectedItem().equals("7"))
        {
            hideAll();
            lbl1.setVisible(true);
            txt1.setVisible(true);
            cbo1.setVisible(true);
            chk1.setVisible(true);
            chkp1.setVisible(true);

            lbl2.setVisible(true);
            txt2.setVisible(true);
            cbo2.setVisible(true);
            chk2.setVisible(true);
            chkp2.setVisible(true);

            lbl3.setVisible(true);
            txt3.setVisible(true);
            cbo3.setVisible(true);
            chk3.setVisible(true);
            chkp3.setVisible(true);

            lbl4.setVisible(true);
            txt4.setVisible(true);
            cbo4.setVisible(true);
            chk4.setVisible(true);
            chkp4.setVisible(true);

            lbl5.setVisible(true);
            txt5.setVisible(true);
            cbo5.setVisible(true);
            chk5.setVisible(true);
            chkp5.setVisible(true);

            lbl6.setVisible(true);
            txt6.setVisible(true);
            cbo6.setVisible(true);
            chk6.setVisible(true);
            chkp6.setVisible(true);

            lbl7.setVisible(true);
            txt7.setVisible(true);
            cbo7.setVisible(true);
            chk7.setVisible(true);
            chkp7.setVisible(true);
            btnCreatetable.setVisible(true);
        }
        else if(cbocolumn.getSelectedItem().equals("8"))
        {
            lbl1.setVisible(true);
            txt1.setVisible(true);
            cbo1.setVisible(true);
            chk1.setVisible(true);
            chkp1.setVisible(true);

            lbl2.setVisible(true);
            txt2.setVisible(true);
            cbo2.setVisible(true);
            chk2.setVisible(true);
            chkp2.setVisible(true);

            lbl3.setVisible(true);
            txt3.setVisible(true);
            cbo3.setVisible(true);
            chk3.setVisible(true);
            chkp3.setVisible(true);

            lbl4.setVisible(true);
            txt4.setVisible(true);
            cbo4.setVisible(true);
            chk4.setVisible(true);
            chkp4.setVisible(true);

            lbl5.setVisible(true);
            txt5.setVisible(true);
            cbo5.setVisible(true);
            chk5.setVisible(true);
            chkp5.setVisible(true);

            lbl6.setVisible(true);
            txt6.setVisible(true);
            cbo6.setVisible(true);
            chk6.setVisible(true);
            chkp6.setVisible(true);

            lbl7.setVisible(true);
            txt7.setVisible(true);
            cbo7.setVisible(true);
            chk7.setVisible(true);
            chkp7.setVisible(true);

            lbl8.setVisible(true);
            txt8.setVisible(true);
            cbo8.setVisible(true);
            chk8.setVisible(true);
            chkp8.setVisible(true);
            btnCreatetable.setVisible(true);
        }
    }//GEN-LAST:event_btnConfirmActionPerformed

    private void btnCreatetableActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCreatetableActionPerformed
        // TODO add your handling code here:
        String tname = txtName.getText();
        if(cbocolumn.getSelectedItem().equals("2"))
        {
            String data[] = Data2();
            try
            {
                Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/tvrepairdb", "root", "root");
                String q = "create table "+tname+" ("
                        +""+data[0]+" "+ data[1]+" "+data[2]+" "+data[3]+","
                        +""+data[4]+" "+ data[5]+" "+data[6]+" "+data[7]+"" + ")";
                PreparedStatement pstmt= con.prepareStatement(q);
                pstmt.execute();
                JOptionPane.showMessageDialog(this, "Table is created with 2 columns.");
                clearfield();
                hideAll();
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, ex);
            }
        }
        else if (cbocolumn.getSelectedItem().equals("3"))
        {
            String data[] = Data3();
            try
            {
                Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/tvrepairdb", "root", "root");
                String q = "create table "+ tname + " ("
                        +""+data[0]+" "+data[1]+" "+data[2]+" "+data[3]+","
                        +""+data[4]+" "+data[5]+" "+data[6]+" "+data[7]+","
                        +""+data[8]+" "+data[9]+" "+data[10]+" "+data[11]+")";
                PreparedStatement pstmt= con.prepareStatement(q);
                pstmt.execute();
                JOptionPane.showMessageDialog(this, "Table is created with 3 columns.");
                clearfield();
                hideAll();
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, ex);
            }
        }
        else if (cbocolumn.getSelectedItem().equals("4"))
        {
            String data[]= Data4();
            try
            {
                Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/tvrepairdb", "root", "root");
                String q = "create table "+ tname + " ("
                        +""+data[0]+" "+data[1]+" "+data[2]+" "+data[3]+","
                        +""+data[4]+" "+data[5]+" "+data[6]+" "+data[7]+","
                        +""+data[8]+" "+data[9]+" "+data[10]+" "+data[11]+","
                        +""+data[12]+" "+data[13]+" "+data[14]+" "+data[15]+")";
                PreparedStatement pstmt= con.prepareStatement(q);
                pstmt.execute();
                JOptionPane.showMessageDialog(this, "Table is created with 4 columns.");
                clearfield();
                hideAll();
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, ex);
            }
        }
        else if (cbocolumn.getSelectedItem().equals("5"))
        {
            String data[]= Data5();
            try
            {
                Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/tvrepairdb", "root", "root");
                String q = "create table "+ tname + " ("
                        +""+data[0]+" "+data[1]+" "+data[2]+" "+data[3]+","
                        +""+data[4]+" "+data[5]+" "+data[6]+" "+data[7]+","
                        +""+data[8]+" "+data[9]+" "+data[10]+" "+data[11]+","
                        +""+data[12]+" "+data[13]+" "+data[14]+" "+data[15]+","
                        +""+data[16]+" "+data[17]+" "+data[18]+" "+data[19]+")";
                PreparedStatement pstmt= con.prepareStatement(q);
                pstmt.execute();
                JOptionPane.showMessageDialog(this, "Table is created with 5 columns.");
                clearfield();
                hideAll();
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, ex);
            }
        }
        else if (cbocolumn.getSelectedItem().equals("6"))
        {
            String data[]= Data6();
            
            try
            {
                Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/tvrepairdb", "root", "root");
                String q = "create table "+ tname + " ("
                        +""+data[0]+" "+data[1]+" "+data[2]+" "+data[3]+","
                        +""+data[4]+" "+data[5]+" "+data[6]+" "+data[7]+","
                        +""+data[8]+" "+data[9]+" "+data[10]+" "+data[11]+","
                        +""+data[12]+" "+data[13]+" "+data[14]+" "+data[15]+","
                        +""+data[16]+" "+data[17]+" "+data[18]+" "+data[19]+","
                        + "" + data[20] + " " + data[21] + " " + data[22] + " " + data[23] + ")";
                PreparedStatement pstmt= con.prepareStatement(q);
                pstmt.execute();
                JOptionPane.showMessageDialog(this, "Table is created with 6 columns.");
                clearfield();
                hideAll();
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, ex);
            }
        }
        else if (cbocolumn.getSelectedItem().equals("7"))
        {
            String data[]= Data7();
            try
            {
                Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/tvrepairdb", "root", "root");
                String q = "create table "+ tname + " ("
                        +""+data[0]+" "+data[1]+" "+data[2]+" "+data[3]+","
                        +""+data[4]+" "+data[5]+" "+data[6]+" "+data[7]+","
                        +""+data[8]+" "+data[9]+" "+data[10]+" "+data[11]+","
                        +""+data[12]+" "+data[13]+" "+data[14]+" "+data[15]+","
                        +""+data[16]+" "+data[17]+" "+data[18]+" "+data[19]+","
                        +""+data[20]+" "+data[21]+" "+data[22] +" "+data[23]+","
                        +""+data[24]+" "+data[25]+" "+data[26]+" "+data[27]+")";
                PreparedStatement pstmt= con.prepareStatement(q);
                pstmt.execute();
                JOptionPane.showMessageDialog(this, "Table is created with 7 columns.");
                clearfield();
                hideAll();
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, ex);
            }
        }
        else if (cbocolumn.getSelectedItem().equals("8"))
        {
            String data[]= Data8();
            
            try
            {
                Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/tvrepairdb", "root", "root");
                String q = "create table "+ tname + " ("
                        +""+data[0]+" "+data[1]+" "+data[2]+" "+data[3]+","
                        +""+data[4]+" "+data[5]+" "+data[6]+" "+data[7]+","
                        +""+data[8]+" "+data[9]+" "+data[10]+" "+data[11]+","
                        +""+data[12]+" "+data[13]+" "+data[14]+" "+data[15]+","
                        +""+data[16]+" "+data[17]+" "+data[18]+" "+data[19]+","
                        +""+data[20]+" "+data[21]+" "+data[22] +" "+data[23]+","
                        +""+data[24]+" "+data[25]+" "+data[26]+" "+data[27]+","
                        +""+data[28]+" "+data[29]+" "+data[30]+" "+data[31]+")";
                PreparedStatement pstmt= con.prepareStatement(q);
                pstmt.execute();
                JOptionPane.showMessageDialog(this, "Table is created with 8 columns.");
                clearfield();
                hideAll();
            }
            catch(Exception ex)
            {
                JOptionPane.showMessageDialog(this, ex);
            }
        }
        
    }//GEN-LAST:event_btnCreatetableActionPerformed

    private void btnBACKActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBACKActionPerformed
        // TODO add your handling code here:
        MainMenu mm = new MainMenu();
        mm.setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnBACKActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(CreateTable.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(CreateTable.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(CreateTable.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(CreateTable.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new CreateTable().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnBACK;
    private javax.swing.JButton btnConfirm;
    private javax.swing.JButton btnCreatetable;
    private javax.swing.JComboBox<String> cbo1;
    private javax.swing.JComboBox<String> cbo2;
    private javax.swing.JComboBox<String> cbo3;
    private javax.swing.JComboBox<String> cbo4;
    private javax.swing.JComboBox<String> cbo5;
    private javax.swing.JComboBox<String> cbo6;
    private javax.swing.JComboBox<String> cbo7;
    private javax.swing.JComboBox<String> cbo8;
    private javax.swing.JComboBox<String> cbocolumn;
    private javax.swing.JCheckBox chk1;
    private javax.swing.JCheckBox chk2;
    private javax.swing.JCheckBox chk3;
    private javax.swing.JCheckBox chk4;
    private javax.swing.JCheckBox chk5;
    private javax.swing.JCheckBox chk6;
    private javax.swing.JCheckBox chk7;
    private javax.swing.JCheckBox chk8;
    private javax.swing.JCheckBox chkp1;
    private javax.swing.JCheckBox chkp2;
    private javax.swing.JCheckBox chkp3;
    private javax.swing.JCheckBox chkp4;
    private javax.swing.JCheckBox chkp5;
    private javax.swing.JCheckBox chkp6;
    private javax.swing.JCheckBox chkp7;
    private javax.swing.JCheckBox chkp8;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JLabel lbl1;
    private javax.swing.JLabel lbl2;
    private javax.swing.JLabel lbl3;
    private javax.swing.JLabel lbl4;
    private javax.swing.JLabel lbl5;
    private javax.swing.JLabel lbl6;
    private javax.swing.JLabel lbl7;
    private javax.swing.JLabel lbl8;
    private javax.swing.JTextField txt1;
    private javax.swing.JTextField txt2;
    private javax.swing.JTextField txt3;
    private javax.swing.JTextField txt4;
    private javax.swing.JTextField txt5;
    private javax.swing.JTextField txt6;
    private javax.swing.JTextField txt7;
    private javax.swing.JTextField txt8;
    private javax.swing.JTextField txtName;
    // End of variables declaration//GEN-END:variables
}
