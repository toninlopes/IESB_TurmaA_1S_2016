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
public class Gerente extends Funcionario {
    private String senha;
    private int numeroDeSubordinados;

    @Override
    public double getBonificacao() {
        return this.salario * 0.15;
    } 
    
    public boolean autentica(String senha) {
        if (this.getSenha().equals(senha)) {
            return true;
        } else {
            return false;
        }
    }
    
    public String getSenha() {
        return senha;
    }
    public void setSenha(String senha) {
        this.senha = senha;
    }

    public int getNumeroDeSubordinados() {
        return numeroDeSubordinados;
    }
    public void setNumeroDeSubordinados(int numeroDeSubordinados) {
        this.numeroDeSubordinados = numeroDeSubordinados;
    }
}
