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
public class Diretor extends Funcionario implements Autenticavel {

//    public Diretor(String nome, Double salario) {
//        super(nome, salario);
//    }

    protected String senha;

    @Override
    public String getSenha() {
        return senha;
    }

    @Override
    public void setSenha(String senha) {
        this.senha = senha;
    }
    
    @Override
    public Double getBonificacao() {
        return this.getSalario() * 0.25;
    }

    @Override
    public boolean autentica(String senha) {
        return this.getSenha().equals(senha);
    }
}
