/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.banco;

import java.util.Date;

/**
 *
 * @author Antonio Lopes
 */
public class Gerente extends Funcionario {
    
    private int numeroDeSubordinados;

    public int getNumeroDeSubordinados() {
        return numeroDeSubordinados;
    }

    public void setNumeroDeSubordinados(int numeroDeSubordinados) {
        this.numeroDeSubordinados = numeroDeSubordinados;
    }

    public Gerente(int numeroDeSubordinados, String nome, Double salario) {
        super(nome, salario);
        this.numeroDeSubordinados = numeroDeSubordinados;
    }
    
    @Override
    public Double getBonificacao() {
        return this.getSalario() * 0.15;
    }    
}
