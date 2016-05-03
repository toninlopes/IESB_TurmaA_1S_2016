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
public class Coordenador extends Funcionario implements Autenticavel {

    private String senha;
    
    @Override
    public Double getBonificacao() {
        return this.getSalario() * 0.075;
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
