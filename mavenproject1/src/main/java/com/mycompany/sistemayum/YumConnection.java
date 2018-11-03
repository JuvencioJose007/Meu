package com.mycompany.sistemayum;

import java.sql.Connection;
import java.sql.Statement;
import java.sql.PreparedStatement;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

public class YumConnection {

    private final String connectionUrl
            = "jdbc:sqlserver://juvencio007.database.windows.net:1433; "
            + "database=Juvencio;"
            + "user=;"
            + "password=;"
            + "encrypt=true;"
            + "trustServerCertificate=false;"
            + "hostNameInCertificate=*.database.windows.net;"
            + "loginTimeout=60;";

    YumOshi yum = new YumOshi();
    private boolean resultado = false;

    public Boolean enviarDados() {
        try {
            // cria um preparedStatement
            Connection connection = DriverManager.getConnection(connectionUrl);
            PreparedStatement stmt = connection.prepareStatement("insert into computadore (OS, HDTOTAL, RAMTOTAL, RAMDISPONIVEL) values (?, ?, ?, ?)");

            // preenche os valores
            stmt.setString(1, yum.getSistemaOperacional());
            stmt.setString(2, yum.getHdTotal());
            stmt.setString(3, yum.getRamTotal());
            stmt.setString(4, yum.getRamDisponivel());

            // executa
            stmt.execute();
            stmt.close();

            resultado = true;

        } catch (Exception e) {
            System.out.println(e);
        }
        return resultado;
    }

    public boolean logar(String email, String senha) {

        String comando = String.format("select * from usuario where email = '%s' and senha = '%s'", email, senha);
        System.out.println("comando: " + comando);
        try {
            Connection connection = DriverManager.getConnection(connectionUrl);

            Statement stmt;
            stmt = connection.createStatement();
            //boolean results = stmt.execute(comando);
            ResultSet results = stmt.executeQuery(comando);
            if(results.next()){
                resultado = true;
            }
            stmt.close();
            System.out.println("result: " + results);

            //resultado = results;
        } catch (SQLException ex) {
            System.out.println("Exception: " + ex);
        }
        return resultado;
    }
}
