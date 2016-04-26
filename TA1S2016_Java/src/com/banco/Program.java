/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.banco;

/**
 *
 * @author Antonio Lopes
 */
public class Program {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
//        Conta contaDoCiclano = new Conta("Ciclano de Tal", 500.0, 1000.0);
//                
//        System.out.println(String.format("Saldo de %s é %f",
//                contaDoCiclano.getNome(), contaDoCiclano.getSaldo()));
//        
//        contaDoCiclano.deposita(250);
//        contaDoCiclano.deposita(250);
//
//        Conta contaDoFulano = new Conta();
//        contaDoFulano.setNome("Fulano de Tal");
//        contaDoFulano.deposita(1000);
//
//        contaDoFulano.transfere(contaDoCiclano, 500);
//
//        System.out.println(String.format("Saldo do %1s: %2f", contaDoCiclano.getNome(), contaDoCiclano.getSaldo()));
//        System.out.println(String.format("Saldo do %1s: %2f", contaDoFulano.getNome(), contaDoFulano.getSaldo()));
        
        
        Funcionario funcionario = new Funcionario("Funcionário", 5000.0);
        //funcionario.setN
        System.out.println("Bonif. do Funcionário: " + funcionario.getBonificacao());
        
        Gerente gerente = new Gerente(1, "Gerente", 5000.0);
        System.out.println("Bonif. do Gerente: " + gerente.getBonificacao());
    }
    
}
