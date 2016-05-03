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
public class Gerente extends Funcionario implements Autenticavel {
    
    private int numeroDeSubordinados;
    private String senha;

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

    @Override
    public String getSenha() {
        return this.senha;
    }

    @Override
    public void setSenha(String senha) {
        this.senha = senha;
    }
    
    @Override
    public boolean autentica(String senha) {
        return this.getSenha().equals(senha);
    }
}
