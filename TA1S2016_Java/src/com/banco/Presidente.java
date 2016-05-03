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
public class Presidente extends Funcionario implements Autenticavel {

    protected String senha;
    
    @Override
    public Double getBonificacao() {
        return this.getSalario() * 1;
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
