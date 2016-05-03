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
public interface Autenticavel {
    
    String senha = "01234";
    
    
    String getSenha();
    
    void setSenha(String senha);
    
    boolean autentica(String senha);
}
