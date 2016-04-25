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
     * @param args 
     */
    public static void main(String[] args) {

        Gerente gerente = new Gerente();
        
        
        
        
        
        gerente.setSalario(5000.0);






        
        imprime(gerente);

        Funcionario funcionario = new Funcionario();
        funcionario.setNome("Ciclano de Tal");
        funcionario.setSalario(5000.0);
        
        imprime(funcionario);
    }
    
    static void imprime(Funcionario funcionario) {
        System.out.println(String.format("%s - Bonificação de %s é %s", funcionario.getClass(),
                funcionario.getNome(), funcionario.getBonificacao()));
    }
    
    //class com.banco.Gerente - Bonificação de Fulano de Tal é 750.0
    //class com.banco.Funcionario - Bonificação de Ciclano de Tal é 500.0
}
