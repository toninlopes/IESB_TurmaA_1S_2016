/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.banco;

import com.banco.excecoes.SaldoInsuficienteException;
import com.banco.excecoes.ValorInvalidoException;

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
        
        
        //Funcionario funcionario = new Funcionario("Funcionário", 5000.0);
        //funcionario.setN
        //System.out.println("Bonif. do Funcionário: " + funcionario.getBonificacao());
        
//        Gerente gerente = new Gerente(1, "Gerente", 5000.0);
//        System.out.println("Bonif. do Gerente: " + gerente.getBonificacao());
        
        Estagiario estagiario = new Estagiario();
        estagiario.setNome("Beltrano de Tal");
        estagiario.setSalario(500.0);
        imprimeSalario(estagiario);
        
        Secretaria secretaria = new Secretaria("Ciltrano de Tal", 1500.0);
        imprimeSalario(secretaria);
               
        Coordenador coordenador = new Coordenador();
        coordenador.setNome("Deltrano de Tal");
        coordenador.setSalario(2500.0);
        imprimeSalario(coordenador);
        
        Gerente gerente = new Gerente(10, "Eltrano de Tal", 3500.0);
        imprimeSalario(gerente);

        Diretor diretor = new Diretor();
        diretor.setNome("Fulano de Tal");
        diretor.setSalario(5000.0);
        imprimeSalario(diretor);
        
        Presidente presidente = new Presidente();
        presidente.setNome("Zelano de Tal");
        presidente.setSalario(10000.0);
        imprimeSalario(presidente);
        
        
//        Conta[] contas = new Conta[3];
//        for (int i = 0; i < 10; i++) {
//            Conta conta = contas[i];
//        }
        
        Conta conta = new Conta();
        conta.setLimite(500.0);
        
        try {
            conta.saca(-800.0);
        } catch (SaldoInsuficienteException e) {
            System.out.println(e.getMessage());
        } catch (ValorInvalidoException e) {
            String msg = e.getMessage();
            System.out.println(msg);
        }
        
    }
    
   private static void imprimeSalario(Funcionario funcionario) {
       System.out.println("Funcionário: " + funcionario.getNome());
       System.out.println("Salário: " + funcionario.getSalario());
       System.out.println("Bonificação: " + funcionario.getBonificacao());
       System.out.println("");
   }
    
}
