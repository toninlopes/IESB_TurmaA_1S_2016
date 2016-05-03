/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.banco;

/**
 *
 * @author antonio.lopes
 */
public class Atendente extends Funcionario {

    public Atendente(String nome, Double salario) {
        super(nome, salario);
    }
    
    @Override
    public Double getBonificacao() {
        return this.getSalario() * 0.05;
    }
    
}
